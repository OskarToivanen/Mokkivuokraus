using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Mokkivuokraus
{
    public partial class Laskut : Form
    {
        SQL tietokanta = new SQL();
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;" +
            "database=vn;username=root;Password=Ruutti;");

        private string varausnumero;
        private string mokkihinta;
        private string palveluhinta;

        public Laskut()
        {
            InitializeComponent();
        }

        private void Laskut_Load(object sender, EventArgs e)
        {
            laskutDGV();
            tbVarausID.Text = varausnumero;
            timer1KellonAika.Start();
        }

        public void laskutDGV()
        {

            string kysely = "select * from hinnat"; //"SELECT * FROM lasku ORDER BY lasku_id";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(kysely, connection);
            adapter.Fill(table);
            dgvLaskut.DataSource = table;
        }

        private void timer1KellonAika_Tick(object sender, EventArgs e)
        {
            tsslKello.Text = DateTime.Now.ToString();
        }

        public void varausID(string varaus)
        {
            varausnumero = varaus.ToString();
        }

        public void mokkiHinta(string hinta, string palvelu)
        {
            mokkihinta = hinta.ToString();
            palveluhinta = palvelu.ToString();

        }
    }
}
