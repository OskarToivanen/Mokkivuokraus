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
    public partial class Palvelu : Form
    {

        SQL tietokanta = new SQL();
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;" +
            "database=vn;username=root;Password=Ruutti;");

        public Palvelu()
        {
            InitializeComponent();
        }

        private void Palvelu_Load(object sender, EventArgs e)
        {
            palveluDGV();
        }

        public void palveluDGV()
        {
            string kysely = "";
            if(toimintaalueID == null)
                kysely = "SELECT * FROM palvelu ORDER BY palvelu_id";
            else
            kysely = "SELECT * FROM palvelu WHERE toimintaalue_id IN " +
                    "(SELECT toimintaalue_id FROM mokki WHERE toimintaalue_id ='" + toimintaalueID + "')";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(kysely, connection);
            adapter.Fill(table);
            dgvPalvelu.DataSource = table;

        }

        private void dgvPalvelu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dgvPalvelu.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dgvPalvelu.CurrentRow.Cells[4].Value.ToString();
            textBox3.Text = dgvPalvelu.CurrentRow.Cells[5].Value.ToString();
        }
        
        private string palvelunumero;
        private string asiakasnumero;
        private string mokkinumero;
        private string mokkihinta;
        private string palveluhinta;
        private string palveluhintaalv;
        private string toimintaalueID;
        private void button1_Click(object sender, EventArgs e)
        {
            palvelunumero = textBox1.Text;
            palveluhinta = textBox2.Text;
            palveluhintaalv = textBox3.Text;
            Varaukset varausform = new Varaukset();
            varausform.palveluID(palvelunumero);
            varausform.palveluHinta(palveluhinta, palveluhintaalv);
            varausform.mokkiID(mokkinumero);
            varausform.mokkiHinta(mokkihinta);
            varausform.asiakasID(asiakasnumero);
            varausform.Show();
        }

        public void asiakasID(string asiakas)
        {
            asiakasnumero = asiakas.ToString();
        }

        public void mokkiID(string mokki)
        {
            mokkinumero = mokki.ToString();
        }
        public void mokkiHinta(string hinta)
        {
            mokkihinta = hinta.ToString();
        }

        public void toimintaID(string toimiID)
        {
            toimintaalueID = toimiID.ToString();
        }
    }
}
