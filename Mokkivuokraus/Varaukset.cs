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
            // TODO: This line of code loads data into the 'villageNewbiesDataset.mokki' table. You can move, or remove it, as needed.
            this.mokkiTableAdapter.Fill(this.villageNewbiesDataset.mokki);
            // TODO: This line of code loads data into the 'villageNewbiesDataset.asiakas' table. You can move, or remove it, as needed.
            this.asiakasTableAdapter.Fill(this.villageNewbiesDataset.asiakas);
            varausDGV();
           
            varauksenPalvelutDGV();
            timer1Kellonaika.Start();
           
        }

        public void varausDGV()
        {

            string kysely = "select * from varaukset";//"SELECT * FROM varaus ORDER BY varaus_id";
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
                            int.Parse(tbMokkiID.Text) + ",'" + int.Parse(tbAsiakas.Text) + "','" + paivat + "','"
                            + paivat + "','" + alkupaiva + "','" +
                            loppupaiva + "')";
                    kyselytieto = tietokanta.SuoritaKysely(lisaavaraus);
                    Palvelu palveluform = new Palvelu();
                    palveluform.Show();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
                //kyselytieto = tietokanta.SuoritaKysely(lisaavaraus);
                //KyselynSuoritus(kyselytieto);
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
            tbMokkiID.Text = dgvVaraus.CurrentRow.Cells[2].Value.ToString();
            tbAsiakas.Text = dgvVaraus.CurrentRow.Cells[3].Value.ToString();
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

        private void btnLisaaPalveluVaraukseen_Click(object sender, EventArgs e)
        {
            if (tbVarausID.Text == "")
                MessageBox.Show("Varaustieto puuttuu", "Virhe");
            else
            {
                tbVarausPalveluVarausID.Text = tbVarausID.Text;
               
                tabControl1.SelectedIndex = 1;
            }
        }

        private void btnLisaaLasku_Click(object sender, EventArgs e)
        {

            Laskut laskutform = new Laskut();
            laskutform.Show();
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Haluatko varmasti poistaa tiedot?",
                   "Poista", MessageBoxButtons.YesNo);
            string poistavaraus = "";
            if (result == DialogResult.Yes)
            {
                if (tbVarausID.Text != "")
                poistavaraus = "DELETE FROM varaus WHERE varaus_id ="
                            + int.Parse(tbVarausID.Text);
                
            }
            kyselytieto = tietokanta.SuoritaKysely(poistavaraus);
            KyselynSuoritus(kyselytieto);
            varausDGV();
        }
    }
}
