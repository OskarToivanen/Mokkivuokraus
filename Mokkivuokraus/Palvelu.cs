﻿using System;
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
            textBox1.Text = dgvPalvelu.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dgvPalvelu.CurrentRow.Cells[4].Value.ToString();
            textBox3.Text = dgvPalvelu.CurrentRow.Cells[5].Value.ToString();
        }
        
       
        private void button1_Click(object sender, EventArgs e)
        {
            
            Varaukset varausform = new Varaukset();
            varausform.Show();
        }
    }
}
