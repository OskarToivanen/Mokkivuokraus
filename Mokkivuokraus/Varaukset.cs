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
        private string kysymys;
        private void Varaukset_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'villageNewbiesDataset.toimintaalue' table. You can move, or remove it, as needed.
            this.toimintaalueTableAdapter.Fill(this.villageNewbiesDataset.toimintaalue);
            // TODO: This line of code loads data into the 'villageNewbiesDataset.mokki' table. You can move, or remove it, as needed.
            this.mokkiTableAdapter.Fill(this.villageNewbiesDataset.mokki);
            // TODO: This line of code loads data into the 'villageNewbiesDataset.asiakas' table. You can move, or remove it, as needed.
            this.asiakasTableAdapter.Fill(this.villageNewbiesDataset.asiakas);
            asiakasNimi();
            kysymys = "SELECT * FROM varaukset";
            varausDGV(kysymys);
            varauksenPalvelutDGV();
            timer1Kellonaika.Start();

        }

        private void asiakasNimi()
        {
            string kysely = "SELECT * FROM asiakkaat";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(kysely, connection);
            adapter.Fill(table);
            cbAsiakas.DataSource = table;
            cbAsiakas.DisplayMember = "nimi";
            cbAsiakas.ValueMember = "asiakas_id";
            tyhjennä();
        }
        
        public void varausDGV(string answer)
        {
            if (answer == "SELECT * FROM varaukset")
                answer = "SELECT * FROM varaukset";
            else
                answer = kysymys;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(answer, connection);
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
                    "varattu_alkupvm, varattu_loppupvm)VALUES(" + int.Parse(cbAsiakasID.Text) + "," +
                        int.Parse(tbMokkiID.Text) + ",'" + paivat + "','"
                        + paivat + "','" + alkupaiva + "','" +
                        loppupaiva + "')";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                kyselytieto = tietokanta.SuoritaKysely(lisaavaraus);
                KyselynSuoritus(kyselytieto);
                kysymys = "SELECT * FROM varaukset";
                varausDGV(kysymys);



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
            if (kysymys == "SELECT * FROM mokki WHERE toimintaalue_id IN (SELECT toimintaalue_id FROM toimintaalue WHERE nimi ='" + cbToimintaalue.Text + "')")
            {
                tbMokkiID.Text = dgvVaraus.CurrentRow.Cells[0].Value.ToString();
                tbMokkinimi.Text = dgvVaraus.CurrentRow.Cells[3].Value.ToString();


            }
            else
            {
                tbVarausID.Text = dgvVaraus.CurrentRow.Cells[0].Value.ToString();
                tbMokkinimi.Text = dgvVaraus.CurrentRow.Cells[1].Value.ToString();
                cbAsiakas.Text = dgvVaraus.CurrentRow.Cells[3].Value.ToString();
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
            // varausDGV();
        }

        private string toimintaalueID;
        public void toimintaID(string toimiID)
        {
            toimintaalueID = toimiID;
        }

        private void tyhjennä()
        {
            tbVarausID.Text = "";
            cbToimintaalue.Text = "";
            tbMokkiID.Text = "";
            tbMokkinimi.Text = "";
            cbAsiakas.Text = "";
            cbAsiakasID.Text = "";
        }

        private void tyhjennäTiedotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tyhjennä();
        }

        private void btnUusiVaraus_Click(object sender, EventArgs e)
        {
            tyhjennä();
            cbToimintaalue.Enabled = true;
            tbMokkiID.Enabled = true;
            cbAsiakas.Enabled = true;
            btnVaraa.Enabled = true;
            cbToimintaalue.Focus();
            kysymys = "SELECT * FROM mokki order by mokki_id";
            varausDGV(kysymys);
        }

        private void cbToimintaalue_SelectedIndexChanged(object sender, EventArgs e)
        {
            kysymys = "SELECT * FROM mokki WHERE toimintaalue_id IN " +
               "(SELECT toimintaalue_id FROM toimintaalue WHERE nimi ='" + cbToimintaalue.Text + "')";
            tbVarausID.Text = "";
            varausDGV(kysymys);
        }

        private void cbAsiakas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kysely = "SELECT * FROM asiakkaat WHERE asiakas_id IN " +
               "(SELECT asiakas_id FROM asiakkaat WHERE nimi ='" + cbAsiakas.Text + "')";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(kysely, connection);
            adapter.Fill(table);
            cbAsiakasID.DataSource = table;
            cbAsiakasID.DisplayMember = "asiakas_id";
            cbAsiakasID.ValueMember = "nimi";

        }

        private void btnPeruVaraus_Click(object sender, EventArgs e)
        {
            tyhjennä();
            kysymys = "SELECT * FROM varaukset";
            varausDGV(kysymys);
            cbToimintaalue.Enabled = false;
            tbMokkiID.Enabled = false;
            cbAsiakas.Enabled = false;
            btnVaraa.Enabled = false;
        }
    }
}
