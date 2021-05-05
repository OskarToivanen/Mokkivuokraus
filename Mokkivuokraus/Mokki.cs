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
    public partial class Mokki : Form
    {
        
        SQL tietokanta = new SQL();
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;" +
            "database=vn;username=root;Password=Ruutti;");
        private void Mokki_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'villageNewbiesDataset.toimintaalue' table. You can move, or remove it, as needed.
            this.mokkiTableAdapter.Fill(this.villageNewbiesDataset.mokki);
            mokkiDGV();
            
           
        }
        public Mokki()
        {
            InitializeComponent();
           
        }

        public void paivitaDGV()
        {
            mokkiDGV();
        }

        public void mokkiDGV()
        {
            string kysely = "SELECT * FROM mokki ORDER BY mokki_id";     
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(kysely, connection);
            adapter.Fill(table);
            dgvMokki.DataSource = table;
        }

        private void dvgMokki_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lMokkiID.Text = dgvMokki.CurrentRow.Cells[0].Value.ToString();
            lToimintaAlue.Text = dgvMokki.CurrentRow.Cells[1].Value.ToString();
            lPosti_Nro_Muuttuu.Text = dgvMokki.CurrentRow.Cells[2].Value.ToString();
            tbHinta.Text = dgvMokki.CurrentRow.Cells[8].Value.ToString();
        }

        private void dgvMokki_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private string kyselytieto = "";
        private void btnLisaa_Click(object sender, EventArgs e)
        {
            string lisaamokki = "";
            try
            {
                DialogResult result;
                if (tbToimialue.Text != "" && tbPostiNro.Text != "")
                {
                    result = MessageBox.Show("Lisätäänkö uusi mökki",
                             "Lisää mökki", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        lisaamokki = "INSERT INTO `vn`.`mokki` (`toimintaalue_id`, `postinro`, `mokkinimi`, `katuosoite`, `kuvaus`, `henkilomaara`, `varustelu`, `hinta`) VALUES('" + tbToimialue.Text + "', '" + tbPostiNro.Text + "', '" + tbMokkiName.Text + "', '" + tbOsoite.Text + "', '" + tbKuvaus.Text + "', '" + tbHenkiloMr.Text + "', '" + tbVarustelu.Text + "', '" + tbHinta.Text + "');SELECT LAST_INSERT_ID();";
                        kyselytieto = tietokanta.SuoritaKysely(lisaamokki);
                        KyselynSuoritus(kyselytieto);
                        mokkiDGV();
                        Tyhjenna();
                    }
                }
                else if (tbToimialue.Text == "" | tbPostiNro.Text == "")
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

        private void btnPaivita_Click(object sender, EventArgs e)
        {
            paivitaDGV();
        }

        private void btnMuokkaa_Click(object sender, EventArgs e)
        {

        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            string poistamokki = "";
            try
            {
                DialogResult result = MessageBox.Show("Haluatko varmasti poistaa tiedot?",
                    "Poista", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    if (lMokkiID.Text == dgvMokki.CurrentRow.Cells[0].Value.ToString())
                    {
                        poistamokki = "DELETE FROM `vn`.`mokki` WHERE  `mokki_id`="+ lMokkiID.Text +";";
                        kyselytieto = tietokanta.SuoritaKysely(poistamokki);

                    }
                  
                }

                KyselynSuoritus(kyselytieto);
                mokkiDGV();
                Tyhjenna();

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
            tbMokkiName.Text = "";
            tbPostiNro.Text = "";
            tbOsoite.Text = "";
            tbHenkiloMr.Text = "";
            tbHinta.Text = "";
            tbKuvaus.Text = "";
            tbVarustelu.Text = "";
            tbToimialue.Text = "";
        }
        

        // Tuodaan toiminta-alue formilta tieto mikä toiminta-alue kyseessä ja etsitään mökit sen perusteella
        

        private void btnSeuraava_Click(object sender, EventArgs e)
        {
            
            Asiakas asiakasForm = new Asiakas();
            asiakasForm.Show();
        }

        //Avaa menun komennot
        private void toimintaalueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aloitus aloitusForm = new Aloitus();
            aloitusForm.Show();
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

        private void varauksetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Varaukset varausForm = new Varaukset();
            varausForm.Show();
        }

        //Lisää menun komennot
        private void tyhjennäTiedotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tyhjenna();
        }

       
        
    }
}
