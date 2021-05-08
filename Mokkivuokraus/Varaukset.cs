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
        private string muutoskysely;
        private void Varaukset_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'villageNewbiesDataset.toimintaalue' table. You can move, or remove it, as needed.
            this.toimintaalueTableAdapter.Fill(this.villageNewbiesDataset.toimintaalue);
            // TODO: This line of code loads data into the 'villageNewbiesDataset.mokki' table. You can move, or remove it, as needed.
            this.mokkiTableAdapter.Fill(this.villageNewbiesDataset.mokki);
            // TODO: This line of code loads data into the 'villageNewbiesDataset.asiakas' table. You can move, or remove it, as needed.
            this.asiakasTableAdapter.Fill(this.villageNewbiesDataset.asiakas);
            asiakasNimi();
            muutoskysely = "SELECT * FROM varaustiedot";
            varausDGV(muutoskysely);
            palveluDGV();
            timer1Kellonaika.Start();

        }

        private void asiakasNimi()
        {
            // Tuodaan tieto järjestelmässä olevista asiakkaista combobox kenttään
            string kysely = "SELECT * FROM asiakkaat";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(kysely, connection);
            adapter.Fill(table);
            cbAsiakas.DataSource = table;
            cbAsiakas.DisplayMember = "nimi";
            cbAsiakas.ValueMember = "asiakas_id";
            tyhjenna();
        }

        private void varausDGV(string answer)
        {
            if (answer == "SELECT * FROM varaustiedot")
                answer = "SELECT * FROM varaustiedot";
            else
                answer = muutoskysely;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(answer, connection);
            adapter.Fill(table);
            dgvVaraus.DataSource = table;

        }

        private void palveluDGV()
        {
            string kysely = "SELECT p.palvelu_id, p.toimintaalue_id, p.nimi, p.kuvaus, p.hinta, p.alv " +
                "FROM toimintaalue ta JOIN palvelu p " +
                "ON ta.toimintaalue_id = p.toimintaalue_id where ta.toimintaalue_id " +
                "IN(SELECT ta.toimintaalue_id WHERE ta.nimi ='" + tbPalveluAlueID.Text + "')";//"SELECT * FROM palvelu ORDER BY palvelu_id";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(kysely, connection);
            adapter.Fill(table);
            dgvPalvelu.DataSource = table;

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
                muutoskysely = "SELECT * FROM varaustiedot";
                tyhjenna();
                lukitse();
                varausDGV(muutoskysely);
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
            // Kun toiminta-alueen nimi muuttuu niin tehdään tämä lause ja etsitään mokit toiminta-alueen perusteella
            if (muutoskysely == "SELECT * FROM mokki WHERE toimintaalue_id IN (SELECT toimintaalue_id FROM toimintaalue WHERE nimi ='" + cbToimintaalue.Text + "')")
            {
                tbMokkiID.Text = dgvVaraus.CurrentRow.Cells[0].Value.ToString();
                tbMokkinimi.Text = dgvVaraus.CurrentRow.Cells[2].Value.ToString();


            }//Uusi varaus painikkeella etsitään kaikki järjestelmässä olevat valmiiksi olevat mokit
            else if (muutoskysely == "SELECT * FROM mokki order by mokki_id")
            {
                tbMokkiID.Text = dgvVaraus.CurrentRow.Cells[0].Value.ToString();
                tbMokkinimi.Text = dgvVaraus.CurrentRow.Cells[3].Value.ToString();
            }
            else// muuten näytetään vain tehdyt varaukset
            {
                tbVarausPalveluVarausID.Text = dgvVaraus.CurrentRow.Cells[0].Value.ToString();
                tbVarausID.Text = dgvVaraus.CurrentRow.Cells[0].Value.ToString();
                tbMokkiID.Text = dgvVaraus.CurrentRow.Cells[1].Value.ToString();
                tbMokkinimi.Text = dgvVaraus.CurrentRow.Cells[2].Value.ToString();
                tbPalveluAlueID.Text = dgvVaraus.CurrentRow.Cells[3].Value.ToString();
                cbAsiakas.Text = dgvVaraus.CurrentRow.Cells[4].Value.ToString();
            }


        }

        private void btnLisaaPalvelu_Click(object sender, EventArgs e)
        {
            string lisaavarauksenpalvelut = "";

            try
            {

                lisaavarauksenpalvelut = "insert into varauksen_palvelut(varaus_id,palvelu_id,lkm) " +
                    "values('" + int.Parse(tbVarausPalveluVarausID.Text) +
                    "','" + int.Parse(tbPalveluID.Text) + "','" + int.Parse(nudLukumaara.Value.ToString()) + "')";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                kyselytieto = tietokanta.SuoritaKysely(lisaavarauksenpalvelut);
                KyselynSuoritus(kyselytieto);
            }
        }

        private void btnLisaaLasku_Click(object sender, EventArgs e)
        {
            if (tbVarausID.Text == "")
                MessageBox.Show("Varausnumero virheellinen!","Virhe");
            else
            {
                Laskutustiedot laskutform = new Laskutustiedot();
                laskutform.Show();
            }
            
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
            muutoskysely = "SELECT * FROM varaustiedot";
            varausDGV(muutoskysely);
        }

        private string toimintaalueID;
        public void toimintaID(string toimiID)
        {
            toimintaalueID = toimiID;
        }

        private void lukitse()
        {
            cbToimintaalue.Enabled = false;
            cbAsiakas.Enabled = false;
            btnVaraa.Enabled = false;
        }
        private void tyhjenna()
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
            tyhjenna();
        }

        private void btnUusiVaraus_Click(object sender, EventArgs e)
        {
            tyhjenna();
            cbToimintaalue.Enabled = true;
            cbAsiakas.Enabled = true;
            btnVaraa.Enabled = true;
            btnLisaaVarausPalvelu.Enabled = false;
            dtpVarattuAlkupvm.Enabled = true;
            dtpVarattuLoppupvm.Enabled = true;
            cbToimintaalue.Focus();
            muutoskysely = "SELECT * FROM mokki order by mokki_id"; //Uusi varaus painikkeella etsitään kaikki järjestelmässä olevat valmiiksi olevat mokit
            varausDGV(muutoskysely);
        }

        private void cbToimintaalue_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kun toiminta-alueen nimi muuttuu niin tehdään tämä lause ja etsitään mokit toiminta-alueen perusteella
            muutoskysely = "SELECT * FROM mokki WHERE toimintaalue_id IN " +
               "(SELECT toimintaalue_id FROM toimintaalue WHERE nimi ='" + cbToimintaalue.Text + "')";
            tbVarausID.Text = "";
            varausDGV(muutoskysely);
        }

        private void cbAsiakas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kun asiakkaan nimi muuttuu muutetaan myös asiakasID/asiakasnumeroa
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
            tyhjenna();
            muutoskysely = "SELECT * FROM varaustiedot";
            varausDGV(muutoskysely);
            cbToimintaalue.Enabled = false;
            tbMokkiID.Enabled = false;
            cbAsiakas.Enabled = false;
            btnVaraa.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void tbVarausID_TextChanged(object sender, EventArgs e)
        {
            if (tbVarausID.Text != "")
            {
                btnLisaaVarausPalvelu.Enabled = true;
                btnLisaaLasku.Enabled = true;
            }
                
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            palveluDGV();
        }

        private void dgvPalvelu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbPalveluID.Text = dgvPalvelu.CurrentRow.Cells[0].Value.ToString();
        }

        private void laskutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Laskutustiedot laskutform = new Laskutustiedot();
            laskutform.Show();
        }
    }
}
