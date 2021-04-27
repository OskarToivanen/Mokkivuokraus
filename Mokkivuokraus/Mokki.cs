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
        int toimintaalueID = 1;

        private void Mokki_Load(object sender, EventArgs e)
        {
            this.mokkiTableAdapter.Fill(this.villageNewbiesDataset.mokki);
            mokkiDGV();
        }
        public Mokki()
        {
            InitializeComponent();
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
        }

        private string kyselytieto = "";
        private void btnLisaa_Click(object sender, EventArgs e)
        {
            string lisaamokki = "";
            DialogResult result;

            lisaamokki = "insert into mokki(toimintaalue_id, postinro, mokkinimi, katuosoite, kuvaus, henkilomaara, varustelu) values (" + toimintaalueID + ",'" + tbPostiNro.Text + "','" + tbMokkiName.Text + "','"
                + tbOsoite.Text + "','" + tbKuvaus.Text + "','" + tbHenkiloMr.Text + "','" + tbVarustelu.Text + "')";

            kyselytieto = tietokanta.SuoritaKysely(lisaamokki);

            KyselynSuoritus(kyselytieto);
            mokkiDGV();
            Tyhjenna();
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
        }

        private void btnMuokkaa_Click(object sender, EventArgs e)
        {

        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            
        }
    }
}
