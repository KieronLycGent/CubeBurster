using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace CubeBurster
{
    public partial class frmFilms : Form
    {
        public frmFilms()
        {
            InitializeComponent();
        }

        private void frmFilms_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= ../../cubeburster.accdb");
            con.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT f.titel,f.jaaruitgave,f.regisseur,f.hoofdrol,g.genre,f.aantal,f.prijs,f.trailer FROM tblfilms f, tblgenres g WHERE f.genreID = g.genreID AND aantal > 0", con);
            DataSet inhoud = new DataSet();
            adapter.Fill(inhoud);
            inhoud.DataSetName = "alleFilms";
            dgvFilms.DataSource = inhoud.Tables[0];
        }
    }
}
