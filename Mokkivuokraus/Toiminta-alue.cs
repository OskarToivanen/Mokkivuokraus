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

        private void toimintaAlueDGV()
        {
            // Päivitetään toimintaAlue datagidview kutsumalla tätä funktiota
            string kysely = "SELECT toimintaalue_id as tunnus, nimi as alue FROM toimintaalue ORDER BY toimintaalue_id";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(kysely, connection);
            adapter.Fill(table);
            dgvToimintaAlue.DataSource = table;

        }
        private void postiDGV()
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
            tyhjennaTiedot();
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
            tyhjennaTiedot();
            
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
                tyhjennaTiedot();
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void mökkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mokki mokkiform = new Mokki();
            mokkiform.Show();
        }

        private void asiakasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Asiakas asiakasform = new Asiakas();
            asiakasform.Show();
        }

        private void palvelutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Palvelu palveluform = new Palvelu();
            palveluform.Show();
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

        private void tyhjennaTiedot()
        {
            tbToimintaAlueID.Text = "";
            tbToimintaAlue.Text = "";
            tbPostinumero.Text = "";
            tbToimipaikka.Text = "";
        }

        private void tyhjennäTiedotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tyhjennaTiedot();
        }

        private void varauksetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Varaukset varauksetform = new Varaukset();
            varauksetform.Show();
        }
      
        private void laskutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Laskutustiedot laskutform = new Laskutustiedot();
            laskutform.Show();
        }
    }
}
