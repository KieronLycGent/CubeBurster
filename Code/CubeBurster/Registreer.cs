using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace CubeBurster
{
    public partial class frmRegistreren : Form
    {
        public static class SecurePasswordHasher
        {
            /// <summary>
            /// Size of salt.
            /// </summary>
            private const int SaltSize = 16;

            /// <summary>
            /// Size of hash.
            /// </summary>
            private const int HashSize = 20;

            /// <summary>
            /// Creates a hash from a password.
            /// </summary>
            /// <param name="password">The password.</param>
            /// <param name="iterations">Number of iterations.</param>
            /// <returns>The hash.</returns>
            public static string Hash(string password, int iterations)
            {
                // Create salt
                byte[] salt;
                new RNGCryptoServiceProvider().GetBytes(salt = new byte[SaltSize]);

                // Create hash
                var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
                var hash = pbkdf2.GetBytes(HashSize);

                // Combine salt and hash
                var hashBytes = new byte[SaltSize + HashSize];
                Array.Copy(salt, 0, hashBytes, 0, SaltSize);
                Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

                // Convert to base64
                var base64Hash = Convert.ToBase64String(hashBytes);

                // Format hash with extra information
                return string.Format("$MYHASH$V1${0}${1}", iterations, base64Hash);
            }

            /// <summary>
            /// Creates a hash from a password with 10000 iterations
            /// </summary>
            /// <param name="password">The password.</param>
            /// <returns>The hash.</returns>
            public static string Hash(string password)
            {
                return Hash(password, 10000);
            }

            /// <summary>
            /// Checks if hash is supported.
            /// </summary>
            /// <param name="hashString">The hash.</param>
            /// <returns>Is supported?</returns>
            public static bool IsHashSupported(string hashString)
            {
                return hashString.Contains("$MYHASH$V1$");
            }

            /// <summary>
            /// Verifies a password against a hash.
            /// </summary>
            /// <param name="password">The password.</param>
            /// <param name="hashedPassword">The hash.</param>
            /// <returns>Could be verified?</returns>
            public static bool Verify(string password, string hashedPassword)
            {
                // Check hash
                if (!IsHashSupported(hashedPassword))
                {
                    throw new NotSupportedException("The hashtype is not supported");
                }

                // Extract iteration and Base64 string
                var splittedHashString = hashedPassword.Replace("$MYHASH$V1$", "").Split('$');
                var iterations = int.Parse(splittedHashString[0]);
                var base64Hash = splittedHashString[1];

                // Get hash bytes
                var hashBytes = Convert.FromBase64String(base64Hash);

                // Get salt
                var salt = new byte[SaltSize];
                Array.Copy(hashBytes, 0, salt, 0, SaltSize);

                // Create hash with given salt
                var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
                byte[] hash = pbkdf2.GetBytes(HashSize);

                // Get result
                for (var i = 0; i < HashSize; i++)
                {
                    if (hashBytes[i + SaltSize] != hash[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
            public frmRegistreren()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRegistreer_Click(object sender, EventArgs e)
        {
            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= ../../cubeburster.accdb";
            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);
            /*
             * try
            {
                verbinding.Open();
                OleDbCommand opdracht = new OleDbCommand("SELECT PostID from tblpost");
            }
            */
            try
            {
                var hash = SecurePasswordHasher.Hash(txtPaswoord.Text);
                verbinding.Open();
                MessageBox.Show("hier");
                OleDbCommand opdracht = new OleDbCommand("INSERT INTO tblaccounts (naam, voornaam, geb_dat, email, paswoord, postID, adres) VALUES(?,?,?,?,?,?,?)", verbinding);
                //OleDbCommand opdracht = new OleDbCommand("INSERT INTO tblaccounts (accountID, accountType, naam, voornaam, geb_dat, email, paswoord, postID , adres, geactiveerd) VALUES(999,1,?,?,?,?,?,?,?,?,0)",verbinding);
                //----------------------------------------------------------------------------------------------------
                // postcode moet veranderd worden in postID later
                //----------------------------------------------------------------------------------------------------

                opdracht.Parameters.AddWithValue("", txtNaam.Text);
                opdracht.Parameters.AddWithValue("", txtVoornaam.Text);
                opdracht.Parameters.AddWithValue("", dtpGebdat.Text);
                opdracht.Parameters.AddWithValue("", txtEmail.Text);
                opdracht.Parameters.AddWithValue("", hash);
                opdracht.Parameters.AddWithValue("", txtPostcode.Text);
                opdracht.Parameters.AddWithValue("", txtAdres.Text);

                // Hash
                //var hash = SecurePasswordHasher.Hash("mypassword");

                // Verify
                //var result = SecurePasswordHasher.Verify("mypassword", hash);

                opdracht.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemen bij vullen van tabel." + ex);
            }
            finally
            {
                verbinding.Close();
            }
        }
    }
}
