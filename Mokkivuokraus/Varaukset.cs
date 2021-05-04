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
        Mokki mokkiform = new Mokki();
        

        public Varaukset()
        {
            InitializeComponent();
        }

        private void Varaukset_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'villageNewbiesDataset.asiakas' table. You can move, or remove it, as needed.
            this.asiakasTableAdapter.Fill(this.villageNewbiesDataset.asiakas);
            varausDGV();
           
            varauksenPalvelutDGV();
            timer1Kellonaika.Start();
            tbMokkiID.Text = mokkinumero;
            tbAsiakasID.Text = asiakasnumero;
           
        }

        public void varausDGV()
        {

            string kysely = "SELECT * FROM varaus ORDER BY varaus_id";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(kysely, connection);
            adapter.Fill(table);
            dgvVaraus.DataSource = table;
            
        }

        public void varauksenPalvelutDGV()
        {

            string kysely = "SELECT * FROM varauksen_palvelut ORDER BY varaus_id";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(kysely, connection);
            adapter.Fill(table);
            dgvVarauksenPalvelut.DataSource = table;
        }

        private string kyselytieto = "";

        private void btnVaraa_Click(object sender, EventArgs e)
        {
            string lisaavaraus = "";
            string paivat = DateTime.Now.ToString("yyyy-MM-dd");
            string alkupaiva = dtpVarattuAlkupvm.Value.Date.ToString("yyyy-MM-dd");
            string loppupaiva = dtpVarattuLoppupvm.Value.Date.ToString("yyyy-MM-dd");
            try
            {
                lisaavaraus = "insert into varaus(asiakas_id, mokki_mokki_id, varattu_pvm, vahvistus_pvm," +
                    "varattu_alkupvm, varattu_loppupvm)VALUES(" +
                        int.Parse(tbAsiakasID.Text) + ",'" + int.Parse(tbMokkiID.Text) + "','" + paivat + "','"
                        + paivat + "','" + alkupaiva + "','" +
                        loppupaiva + "')";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                kyselytieto = tietokanta.SuoritaKysely(lisaavaraus);
                KyselynSuoritus(kyselytieto);
                varausDGV();
            }
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

        private string mokkinumero;
        private string asiakasnumero;
        private string palvelunumero;
        private string mokkihinta;
        private string palveluhinta;
        private string palveluhinta_alv;
        
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

        public void palveluID(string palvelu)
        {
            palvelunumero = palvelu.ToString();
        }

        public void palveluHinta(string phinta, string hinta_alv)
        {
            palveluhinta = phinta.ToString();
            palveluhinta_alv = hinta_alv.ToString();
        }

        private void mokkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mokki mokkiForm = new Mokki();
            mokkiForm.Show();
        }

        private void asiakasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Asiakas asiakasForm = new Asiakas();
            asiakasForm.Show();
        }

        private void palvelutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Palvelu palveluForm = new Palvelu();
            palveluForm.Show();
        }

        private void toimintaalueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aloitus aloitusForm = new Aloitus();
            aloitusForm.Show();
        }

        private void timer1Kellonaika_Tick(object sender, EventArgs e)
        {
            tsslKello.Text = DateTime.Now.ToString();
        }

        private void dgvVaraus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbVarausID.Text = dgvVaraus.CurrentRow.Cells[0].Value.ToString();
            tbAsiakasID.Text = dgvVaraus.CurrentRow.Cells[1].Value.ToString();
            tbMokkiID.Text = dgvVaraus.CurrentRow.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbVarausID.Text == "")
                MessageBox.Show("Varaustieto puuttuu", "Virhe");
            else
            {
                tbVarausPalveluVarausID.Text = tbVarausID.Text;
                tbPalveluID.Text = palvelunumero;
                tabControl1.SelectedIndex = 1;
            }
        }

        private void btnLisaaPalvelu_Click(object sender, EventArgs e)
        {
            string lisaavarauksenpalvelut = "";

            try
            {
                
                lisaavarauksenpalvelut = "insert into varauksen_palvelut(varaus_id,palvelu_id,lkm) " +
                    "values('" + int.Parse(tbVarausPalveluVarausID.Text) +
                    "','" + int.Parse(tbPalveluID.Text) + "','" + int.Parse(tbLukumaara.Text) + "')";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                kyselytieto = tietokanta.SuoritaKysely(lisaavarauksenpalvelut);
                KyselynSuoritus(kyselytieto);
                varauksenPalvelutDGV();
            }
        }
    }
}
