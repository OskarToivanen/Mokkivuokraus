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
    public partial class Aloitus : Form
    {
        
        SQL tietokanta = new SQL();
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;" +
            "database=vn;username=root;Password=Ruutti;");

        private void Aloitus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'villageNewbiesDataset.posti' table. You can move, or remove it, as needed.
            this.postiTableAdapter.Fill(this.villageNewbiesDataset.posti);
            toimintaAlueDGV();
            postiDGV();
            timerKellonAika.Start();
        }

        public Aloitus()
        {
            InitializeComponent();
            
        }

        public void toimintaAlueDGV()
        {
            // Päivitetään toimintaAlue datagidview kutsumalla tätä funktiota
            string kysely = "SELECT * FROM toimintaalue ORDER BY toimintaalue_id";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(kysely, connection);
            adapter.Fill(table);
            dgvToimintaAlue.DataSource = table;

        }
        public void postiDGV()
        {
            // Päivitetään postidatagridview kutsumalla tätä funktiota
            string kysely = "SELECT * FROM posti";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(kysely, connection);
            adapter.Fill(table);
            dgvPosti.DataSource = table;
        }

        private void timerKellonAika_Tick(object sender, EventArgs e)
        {
            tsslKello.Text = DateTime.Now.ToString();
        }

        private void dgvToimintaAlue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbToimintaAlueID.Text = dgvToimintaAlue.CurrentRow.Cells[0].Value.ToString();
            tbToimintaAlue.Text = dgvToimintaAlue.CurrentRow.Cells[1].Value.ToString();
            tbToimintaAlue.Focus();
        }

        
        private string kyselytieto = "";
        private void btnLisaa_Click(object sender, EventArgs e)
        {
            // Kysytään käyttäjältä varmistus, jos halutaan lisätä pelkästään postinumero ja toimipaikka
            // Riippuen käyttäjän valinnasta viedään tieto SQL-luokalle, joka palauttaa tiedon onnistuiko kysely
            string lisaatoimintaAlue = "";
            string lisaaposti = "";
            DialogResult result;
            if (tbToimintaAlueID.Text == "" && tbToimintaAlue.Text == "")
            {
                result = MessageBox.Show("Lisätäänkö pelkkä postinumero ja toimipaikka",
                         "Lisää", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    lisaaposti = "insert into posti(postinro, toimipaikka)values(" +
                    tbPostinumero.Text + ",'" + tbToimipaikka.Text + "')";
                    kyselytieto = tietokanta.SuoritaKysely(lisaaposti);
                }
            }
            else if (tbToimintaAlue.Text != "" && tbPostinumero.Text != "")
            {
                lisaatoimintaAlue = "insert into toimintaalue(nimi) values('" + tbToimintaAlue.Text + "')";
                lisaaposti = "insert into posti(postinro, toimipaikka)values(" +
                    tbPostinumero.Text + ",'" + tbToimipaikka.Text + "')";
                kyselytieto = tietokanta.SuoritaKysely(lisaaposti);
                kyselytieto = tietokanta.SuoritaKysely(lisaatoimintaAlue);

            }
            else
            {
                lisaatoimintaAlue = "insert into toimintaalue(nimi) values('" + tbToimintaAlue.Text + "')";
                kyselytieto = tietokanta.SuoritaKysely(lisaatoimintaAlue);
            }
                
            KyselynSuoritus(kyselytieto);           
            toimintaAlueDGV();
            postiDGV();
            Tyhjenna();
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

        private void btnMuokkaa_Click(object sender, EventArgs e)
        {
            string paivitatiedot = "";

            // Voidaan muokata tietoja, mutta postinumeroa ei voida muokata, koska se toimii pää-avaimena
            if (tbToimintaAlueID.Text == "")
                paivitatiedot = "UPDATE posti SET toimipaikka ='" + tbToimipaikka.Text +
                    "' WHERE postinro =" + int.Parse(tbPostinumero.Text);
            else
            {
                paivitatiedot = "UPDATE toimintaalue SET nimi='" + tbToimintaAlue.Text +
                "' WHERE toimintaalue_id =" + int.Parse(tbToimintaAlueID.Text);
            }    
           
            kyselytieto = tietokanta.SuoritaKysely(paivitatiedot);
            KyselynSuoritus(kyselytieto);
            toimintaAlueDGV();
            postiDGV();
            Tyhjenna();
            
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            string poistatoimintaAlue = "";
            string poistaposti = "";
            // kysytään käyttäjältä varmistus tietojen poistolle. Jos toiminta-alueID on tyhjä
            // postinro vastaa tbPostinumero poistetaan pelkkä postinumero ja toimipaikka

            try
            {
                DialogResult result = MessageBox.Show("Haluatko varmasti poistaa tiedot?", 
                    "Poista", MessageBoxButtons.YesNo);
               
                if (result == DialogResult.Yes)
                {
                    if (tbToimintaAlueID.Text == "" && tbPostinumero.Text == dgvPosti.CurrentRow.Cells[0].Value.ToString())
                    {
                        poistaposti = "DELETE FROM posti WHERE postinro =" + int.Parse(tbPostinumero.Text);
                        kyselytieto = tietokanta.SuoritaKysely(poistaposti);
                        
                    }
                    else if (tbToimintaAlueID.Text == dgvToimintaAlue.CurrentRow.Cells[0].Value.ToString() && tbPostinumero.Text == "")
                    {
                        poistatoimintaAlue = "DELETE FROM toimintaalue WHERE toimintaalue_id ="
                            + int.Parse(tbToimintaAlueID.Text);
                        kyselytieto = tietokanta.SuoritaKysely(poistatoimintaAlue);
                       
                    }

                    else
                    {
                        poistaposti = "DELETE FROM posti WHERE postinro =" + int.Parse(tbPostinumero.Text);
                        poistatoimintaAlue = "DELETE FROM toimintaalue WHERE toimintaalue_id ="
                            + int.Parse(tbToimintaAlueID.Text);
                        kyselytieto = tietokanta.SuoritaKysely(poistatoimintaAlue);
                        kyselytieto = tietokanta.SuoritaKysely(poistaposti);
                        
                    }
                }
               
                toimintaAlueDGV();
                postiDGV();
                Tyhjenna();
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void mökkiToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void dgvPosti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbPostinumero.Text = dgvPosti.CurrentRow.Cells[0].Value.ToString();
            tbToimipaikka.Text = dgvPosti.CurrentRow.Cells[1].Value.ToString();
        }

        private void tbPostinumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        public void Tyhjenna()
        {
            tbToimintaAlueID.Text = "";
            tbToimintaAlue.Text = "";
            tbPostinumero.Text = "";
            tbToimipaikka.Text = "";
        }

        private void tyhjennäTiedotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tyhjenna();
        }

        private void varauksetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Varaukset varauksetForm = new Varaukset();
            varauksetForm.Show();
        }
        private string toimintanimi;

        // Viedään mokkiformille tieto miltä alueelta mokit etsitään
        private void btnSeuraava_Click(object sender, EventArgs e)
        {
            if (tbToimintaAlueID.Text == "")
                MessageBox.Show("Alue ID virheellinen");
            else
            {
                toimintanimi = tbToimintaAlue.Text;
                Mokki mokkiForm = new Mokki();
                mokkiForm.toimintaNimi(toimintanimi);
                mokkiForm.Show();
            }
        }

        private void laskutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Laskut laskutform = new Laskut();
            laskutform.Show();
        }
    }
}
