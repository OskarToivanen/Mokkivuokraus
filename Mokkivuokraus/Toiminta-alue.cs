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
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;database=vn;username=root;Password=Ruutti;");
        MySqlCommand command;

        private void Aloitus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'villageNewbiesDataset.posti' table. You can move, or remove it, as needed.
            this.postiTableAdapter.Fill(this.villageNewbiesDataset.posti);
            toimintaAlueDGV();
            timerKellonAika.Start();
        }

        public Aloitus()
        {
            InitializeComponent();
            
        }

        public void toimintaAlueDGV()
        {
            string query = "SELECT * FROM toimintaalue ORDER BY toimintaalue_id";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgvToimintaAlue.DataSource = table;


        }

        private void timerKellonAika_Tick(object sender, EventArgs e)
        {
            tsslKello.Text = DateTime.Now.ToString();
        }

        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public void ExecuteMyQuery(string query)
        {
            try
            {
                OpenConnection();
                command = new MySqlCommand(query, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Kysely suoritettu");
                }
                else
                {
                    MessageBox.Show("Kyselyä ei suoritettu");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            finally
            {
                CloseConnection();
            }
        }

        private void dgvToimintaAlue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbToimintaAlueID.Text = dgvToimintaAlue.CurrentRow.Cells[0].Value.ToString();
            tbToimintaAlue.Text = dgvToimintaAlue.CurrentRow.Cells[1].Value.ToString();
            tbToimintaAlue.Focus();
        }

        private void cbPostinumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            
           string insertKysely = "insert into toimintaalue(nimi) values('" + tbToimintaAlue.Text + "')";
           string insertPosti = "insert into posti(postinro, toimipaikka)values(" + cbPostinumero.Text + ",'" + cbToimipaikka.Text + "')";

            ExecuteMyQuery(insertKysely);
            ExecuteMyQuery(insertPosti);
            toimintaAlueDGV();
        }

        private void btnMuokkaa_Click(object sender, EventArgs e)
        {
            string updateKysely = "UPDATE toimintaalue SET nimi='" + tbToimintaAlue.Text + "' WHERE toimintaalue_id =" + int.Parse(tbToimintaAlueID.Text);
            ExecuteMyQuery(updateKysely);
            toimintaAlueDGV();
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            string deleteKysely = "DELETE FROM toimintaalue WHERE toimintaalue_id =" + int.Parse(tbToimintaAlueID.Text);
            ExecuteMyQuery(deleteKysely);
            toimintaAlueDGV();
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
    }
}
