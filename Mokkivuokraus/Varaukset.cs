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
using System.Globalization;

namespace Mokkivuokraus
{
    public partial class Varaukset : Form
    {
        SQL tietokanta = new SQL();
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;" +
            "database=vn;username=root;Password=Ruutti;");

        Varaustiedot varaustiedot = new Varaustiedot();

        public Varaukset()
        {
            InitializeComponent();
        }

        private void Varaukset_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'villageNewbiesDataset.asiakas' table. You can move, or remove it, as needed.
            this.asiakasTableAdapter.Fill(this.villageNewbiesDataset.asiakas);
            varausDGV();
            laskutDGV();
           

        }

        public void varausDGV()
        {

            string kysely = "SELECT * FROM varaus ORDER BY varaus_id";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(kysely, connection);
            adapter.Fill(table);
            dgvVaraus.DataSource = table;
            tbMokkiID.Text = varaustiedot.mokkiID.ToString();
        }

        public void laskutDGV()
        {
            string kysely = "SELECT * FROM lasku ORDER BY varaus_id";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(kysely, connection);
            adapter.Fill(table);
            dgvLaskut.DataSource = table;
        }

        private string kyselytieto = "";

        private void btnVaraa_Click(object sender, EventArgs e)
        {
            string lisaavaraus = "";
            string paivat = DateTime.Now.ToString("yyyy-MM-dd");
            string alkupaiva = dtpVarattuAlkupvm.Value.Date.ToString("yyyy-MM-dd");
            string loppupaiva = dtpVarattuLoppupvm.Value.Date.ToString("yyyy-MM-dd");
            

            lisaavaraus = "insert into varaus(asiakas_id, mokki_mokki_id, varattu_pvm, vahvistus_pvm," +
                "varattu_alkupvm, varattu_loppupvm)values(" +
                    tbAsiakasID.Text + ",'" + tbMokkiID.Text + "','" + paivat + "','"
                    + paivat + "','" + alkupaiva + "','" +
                    loppupaiva + "')";

            kyselytieto = tietokanta.SuoritaKysely(lisaavaraus);
            KyselynSuoritus(kyselytieto);
            varausDGV();
        }

        private void KyselynSuoritus(string tieto)
        {
            // tuodaan SQL-luokasta tieto onko kysely onnistunut vai ei
            if (tieto == "Kysely suoritettu")
                MessageBox.Show(tieto);
            else if (tieto == "Kyselyä ei suoritettu")
                MessageBox.Show(tieto);
            else
                MessageBox.Show(tieto);
        }

        private void dgvLaskut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbLaskuID.Text = dgvLaskut.CurrentRow.Cells[0].Value.ToString();
            tbLaskuVarausID.Text = dgvLaskut.CurrentRow.Cells[1].Value.ToString();
            tbSumma.Text = dgvLaskut.CurrentRow.Cells[2].Value.ToString();
            tbALV.Text = dgvLaskut.CurrentRow.Cells[3].Value.ToString();

        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            varausDGV();
        }
    }
}
