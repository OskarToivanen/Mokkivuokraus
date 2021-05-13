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
            timerKellonAika.Start();
        }

        public void palveluDGV()
        {
            string kysely = "SELECT * FROM palvelu ORDER BY palvelu_id";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(kysely, connection);
            adapter.Fill(table);
            dgvPalvelu.DataSource = table;

        }

        private void dgvPalvelu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbPalveluID.Text = dgvPalvelu.CurrentRow.Cells[0].Value.ToString();
            tbToimintaalueID.Text = dgvPalvelu.CurrentRow.Cells[1].Value.ToString();
            tbNimi.Text = dgvPalvelu.CurrentRow.Cells[2].Value.ToString();
            tbKuvaus.Text = dgvPalvelu.CurrentRow.Cells[3].Value.ToString();
            tbHinta.Text = dgvPalvelu.CurrentRow.Cells[4].Value.ToString();
            tbAlv.Text = dgvPalvelu.CurrentRow.Cells[5].Value.ToString();
        }


        private void timerKellonAika_Tick(object sender, EventArgs e)
        {
            tsslKello.Text = DateTime.Now.ToString();
        }

        private void varauksetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Varaukset varausform = new Varaukset();
            varausform.Show();
        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            string lisaapalvelu = "";
            string hinta = tbHinta.Text;
            string alv = tbAlv.Text;
            hinta = hinta.Replace(",", ".");
            alv = alv.Replace(",", ".");

            lisaapalvelu = "insert into palvelu(toimintaalue_id, nimi, kuvaus, hinta, alv)" +
            "VALUES(" + int.Parse(tbToimintaalueID.Text) + ",'" + tbNimi.Text + "','" + tbKuvaus.Text + "'," +
            hinta + "," + alv + ")";

            kyselytieto = tietokanta.SuoritaKysely(lisaapalvelu);
            kyselynSuoritus(kyselytieto);
            palveluDGV();
            tyhjennaTiedot();

        }

        string kyselytieto;

        private void kyselynSuoritus(string tieto)
        {
            // tuodaan SQL-luokasta tieto onko kysely onnistunut vai ei
            if (tieto == "Kysely suoritettu")     
                MessageBox.Show(tieto);
            else if (tieto == "Kyselyä ei suoritettu")
                MessageBox.Show(tieto);
            else
                MessageBox.Show(tieto);
        }

        private void tbHinta_TextChanged(object sender, EventArgs e)
        {
            
            if (tbHinta.Text != "")
            {
                double alvpros = (double.Parse(tbHinta.Text) * 24) / 100;
                tbAlv.Text = alvpros.ToString("0.00");
            }
            
        }

        private void btnMuokkaa_Click(object sender, EventArgs e)
        {
            string paivitatiedot = "";

            paivitatiedot = "UPDATE palvelu SET nimi, kuvaus ='" + tbNimi.Text + "','" + tbKuvaus.Text +
                "' WHERE palvelu_id =" + int.Parse(tbPalveluID.Text);
            kyselytieto = tietokanta.SuoritaKysely(paivitatiedot);
            kyselynSuoritus(kyselytieto);
            palveluDGV();
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            string poistapalvelu = "";
           
            try
            {
                DialogResult result = MessageBox.Show("Haluatko varmasti poistaa tiedot?",
                    "Poista", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    poistapalvelu = "DELETE FROM palvelu WHERE palvelu_id =" + int.Parse(tbPalveluID.Text);
                    kyselytieto = tietokanta.SuoritaKysely(poistapalvelu);
                    kyselynSuoritus(kyselytieto);
                }

                palveluDGV();
                tyhjennaTiedot();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void tyhjennaTiedot()
        {
            tbPalveluID.Text = "";
            tbToimintaalueID.Text = "";
            tbNimi.Text = "";
            tbKuvaus.Text = "";
            tbHinta.Text = "";
            tbAlv.Text = "";
        }

        private void tyhjennäTiedotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tyhjennaTiedot();
        }

        private void tbHinta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }
    }
}
