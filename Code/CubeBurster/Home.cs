﻿using System;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void BtnInhoudDatagrid_Click(object sender, EventArgs e)
        {
            /*
            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= ../../cubeburster.accdb";
            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);
            try
            {
                verbinding.Open();
                String sql = "SELECT * from tblaccounts";
                OleDbDataAdapter oledbAdapter = new OleDbDataAdapter(sql, verbinding);
                DataSet mijnDataSat = new DataSet();
                oledbAdapter.Fill(mijnDataSat);
                mijnDataSat.DataSetName = "omschrijving fouten";
                datagridview1.DataSource = mijnDataSat.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemen bij vullen van tabel." + ex);
            }
            finally
            {
                verbinding.Close();
            }
            */
        }

        private void AccountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AanmeldenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistreren registratie = new frmRegistreren();
            registratie.Show();
        }

        private void inloggenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Enkel zichtbaar voor admins!!!
        }

        private void werknemerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Enkel zichtbaar voor werknemers!!!
        }

        private void filmsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrerenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}