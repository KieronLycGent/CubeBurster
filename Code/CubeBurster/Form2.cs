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

namespace CubeBurster
{
    public partial class frmRegistreren : Form
    {
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
                verbinding.Open();
                OleDbCommand opdracht = new OleDbCommand("INSERT INTO tblaccounts (accountID, accountType, naam, voornaam, geb_dat, email, paswoord, postID , adres, geactiveerd) VALUES(999,1,?,?,?,?,?,?,?,?,0)",verbinding);
                //----------------------------------------------------------------------------------------------------
                // postcode moet veranderd worden in postID later
                //----------------------------------------------------------------------------------------------------
                opdracht.Parameters.AddWithValue("", txtNaam.Text);
                opdracht.Parameters.AddWithValue("", txtVoornaam.Text);
                opdracht.Parameters.AddWithValue("", dtpGebdat.Text);
                opdracht.Parameters.AddWithValue("", txtEmail.Text);
                opdracht.Parameters.AddWithValue("", txtPaswoord1.Text);
                opdracht.Parameters.AddWithValue("", txtPostcode.Text);
                opdracht.Parameters.AddWithValue("", txtAdres.Text);

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
