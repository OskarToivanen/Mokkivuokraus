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
    public partial class Asiakas : Form
    {
        SQL tietokanta = new SQL();
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;" +
            "database=vn;username=root;Password=Ruutti;");

        public Asiakas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Asiakas_Load(object sender, EventArgs e)

        {

            // TODO: This line of code loads data into the 'villageNewbiesDataset.asiakas' table. You can move, or remove it, as needed.
            this.asiakasTableAdapter.Fill(this.villageNewbiesDataset.asiakas);

        }

        public void paivitaDGV()
        {
            asiakasDGV();
        }

        public void asiakasDGV()
        {
            string kysely = "SELECT * FROM asiakas ORDER BY asiakas_id";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(kysely, connection);
            adapter.Fill(table);
            dgvAsiakas.DataSource = table;
        }

        private void dvgAsiakas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblAsiakasId.Text = dgvAsiakas.CurrentRow.Cells[0].Value.ToString();

        }

        private string kyselytieto = "";
        private void btnLisaa_Click(object sender, EventArgs e)
        {
            string lisaaAsiakas = "";
            try
            {
                DialogResult result;
                if (tbEtunimi.Text != "" && tbSukunimi.Text != "")
                {
                    result = MessageBox.Show("Lisätäänkö uusi asiakas",
                             "Lisää asiakas", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        lisaaAsiakas = "INSERT INTO `vn`.`asiakas` (`postinro`, `etunimi`, `sukunimi`, `lahiosoite`, `email`, `puhelinnro`) VALUES('" + tbPostinumero.Text + "', '" + tbEtunimi.Text + "', '" + tbSukunimi.Text + "', '" + tbLahiosoite.Text + "', '" + tbSahkoposti.Text + "', '" + tbPuhelinnumero.Text + "');SELECT LAST_INSERT_ID();";
                        kyselytieto = tietokanta.SuoritaKysely(lisaaAsiakas);
                        KyselynSuoritus(kyselytieto);
                        asiakasDGV();
                        Tyhjenna();
                    }
                }
                else if (tbEtunimi.Text == "" | tbSukunimi.Text == "")
                {
                    result = MessageBox.Show("Täytä tarvittavat kentät",
                         "Virhe", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void KyselynSuoritus(string tieto)
        {
            if (tieto == "Kysely suoritettu")
                MessageBox.Show(tieto);
            else if (tieto == "Kyselyä ei suoritettu")
                MessageBox.Show(tieto);
            else
                MessageBox.Show(tieto);
        }

        public void Tyhjenna()
        {
            tbPostinumero.Text = "";
            tbEtunimi.Text = "";
            tbSukunimi.Text = "";
            tbLahiosoite.Text = "";
            tbSahkoposti.Text = "";
            tbPuhelinnumero.Text = "";

        }

        private void btnPaivita_Click(object sender, EventArgs e)
        {
            paivitaDGV();
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            string poistaAsiakas = "";
            try
            {
                DialogResult result = MessageBox.Show("Haluatko varmasti poistaa tiedot?",
                    "Poista", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    if (lblAsiakasId.Text == dgvAsiakas.CurrentRow.Cells[0].Value.ToString())
                    {
                        poistaAsiakas = "DELETE FROM `vn`.`asiakas` WHERE  `asiakas_id`=" + lblAsiakasId.Text + ";";
                        kyselytieto = tietokanta.SuoritaKysely(poistaAsiakas);

                    }

                }

                KyselynSuoritus(kyselytieto);
                asiakasDGV();
                Tyhjenna();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private string asiakasnumero;
        private string toimintaalueID;
        private void btnSeuraava_Click(object sender, EventArgs e)
        {
            Varaukset varausform = new Varaukset();
            asiakasnumero = lblAsiakasId.Text;
            varausform.asiakasID(asiakasnumero);
            varausform.mokkiID(mokkinumero);
            ActiveForm.Close();
            varausform.Show();

            //asiakasnumero = lblAsiakasId.Text;
            //ActiveForm.Close();
            //Palvelu palveluform = new Palvelu();
            //palveluform.mokkiID(mokkinumero);
            //palveluform.mokkiHinta(mokkihinta);
            //palveluform.asiakasID(asiakasnumero);
            //palveluform.toimintaID(toimintaalueID);
            //palveluform.Show();
        }

        private string mokkinumero;
        private string mokkihinta;

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
