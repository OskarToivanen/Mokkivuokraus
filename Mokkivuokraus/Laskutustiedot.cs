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
    public partial class Laskutustiedot : Form
    {
        SQL tietokanta = new SQL();
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;" +
            "database=vn;username=root;Password=Ruutti;");

        public Laskutustiedot()
        {
            InitializeComponent();
        }

        private void Laskut_Load(object sender, EventArgs e)
        {
            vahvistetutLaskutDGV();
            laskutDGV();
            timer1KellonAika.Start();
        }

        private void laskutDGV()
        {

            string kysely = "SELECT * FROM varauksenhinta";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(kysely, connection);
            adapter.Fill(table);
            dgvLaskut.DataSource = table;
            
        }

        private void vahvistetutLaskutDGV()
        {
            string kysely = "SELECT lasku_id as laskunumero," +
                "varaus_id as varausnumero, summa, alv FROM lasku order by laskunumero";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(kysely, connection);
            adapter.Fill(table);
            dgvVahvistetutLaskut.DataSource = table;
        }

        private void timer1KellonAika_Tick(object sender, EventArgs e)
        {
            tsslKello.Text = DateTime.Now.ToString();
        }

        string kyselytieto;
        private void btnLisaa_Click(object sender, EventArgs e)
        {

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

        private void dgvLaskut_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbVarausID.Text = dgvLaskut.CurrentRow.Cells[0].Value.ToString();
            tbNimi.Text = dgvLaskut.CurrentRow.Cells[4].Value.ToString();
            string mokkihinta = dgvLaskut.CurrentRow.Cells[9].Value.ToString();
            string palveluhinta = dgvLaskut.CurrentRow.Cells[12].Value.ToString();
            if (palveluhinta == "")
                palveluhinta = "0";
            float summamokki = float.Parse(mokkihinta);
            int summapalvelu = int.Parse(palveluhinta);
            double summa = summamokki + summapalvelu;
            tbSumma.Text = summa.ToString("0.00");
            tbSposti.Text = dgvLaskut.CurrentRow.Cells[6].Value.ToString();
        }

        private void tbSumma_TextChanged(object sender, EventArgs e)
        {
            double alvpros = (double.Parse(tbSumma.Text) * 24) / 100;
            tbAlv.Text = alvpros.ToString("0.00");
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Haluatko varmasti poistaa tiedot?",
                   "Poista", MessageBoxButtons.YesNo);
            string poistalasku = "";
            if (result == DialogResult.Yes)
            {
                if (tbPoistaID.Text != "")
                    poistalasku = "DELETE FROM lasku WHERE lasku_id ="
                                + int.Parse(tbPoistaID.Text);

            }
            tbPoistaID.Text = "";
            kyselytieto = tietokanta.SuoritaKysely(poistalasku);
            KyselynSuoritus(kyselytieto);
            vahvistetutLaskutDGV();
        }

        private void dgvVahvistetutLaskut_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbPoistaID.Text = dgvVahvistetutLaskut.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnVahvista_Click(object sender, EventArgs e)
        {
            
            string summa = tbSumma.Text;
            string alv = tbAlv.Text;
            summa = summa.Replace(",",".");
            alv = alv.Replace(",", ".");
            

            string lisaalasku = "";

            DialogResult result = MessageBox.Show("Lasku lähetetään osoitteeseen " +
                tbSposti.Text, "Vahvistetaan lasku", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                lisaalasku = "insert into lasku(varaus_id, summa, alv) " +
                "values(" + int.Parse(tbVarausID.Text) + "," + summa
                + "," + alv + ")";

                kyselytieto = tietokanta.SuoritaKysely(lisaalasku);
                KyselynSuoritus(kyselytieto);
                laskutDGV();
                vahvistetutLaskutDGV();
            }
            tabControl1.SelectedIndex = 1;
        }
    }
}
