
namespace Mokkivuokraus
{
    partial class Laskutustiedot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.avaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mokkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asiakasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.palvelutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toimintaalueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslKello = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1KellonAika = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbSposti = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSumma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVahvista = new System.Windows.Forms.Button();
            this.tbAlv = new System.Windows.Forms.TextBox();
            this.tbNimi = new System.Windows.Forms.TextBox();
            this.tbVarausID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLaskut = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPoistaID = new System.Windows.Forms.TextBox();
            this.btnPoista = new System.Windows.Forms.Button();
            this.dgvVahvistetutLaskut = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaskut)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVahvistetutLaskut)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avaaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(955, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // avaaToolStripMenuItem
            // 
            this.avaaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mokkiToolStripMenuItem,
            this.asiakasToolStripMenuItem,
            this.palvelutToolStripMenuItem,
            this.toimintaalueToolStripMenuItem});
            this.avaaToolStripMenuItem.Name = "avaaToolStripMenuItem";
            this.avaaToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.avaaToolStripMenuItem.Text = "Avaa";
            // 
            // mokkiToolStripMenuItem
            // 
            this.mokkiToolStripMenuItem.Name = "mokkiToolStripMenuItem";
            this.mokkiToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.mokkiToolStripMenuItem.Text = "Mökki";
            // 
            // asiakasToolStripMenuItem
            // 
            this.asiakasToolStripMenuItem.Name = "asiakasToolStripMenuItem";
            this.asiakasToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.asiakasToolStripMenuItem.Text = "Asiakas";
            // 
            // palvelutToolStripMenuItem
            // 
            this.palvelutToolStripMenuItem.Name = "palvelutToolStripMenuItem";
            this.palvelutToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.palvelutToolStripMenuItem.Text = "Palvelut";
            // 
            // toimintaalueToolStripMenuItem
            // 
            this.toimintaalueToolStripMenuItem.Name = "toimintaalueToolStripMenuItem";
            this.toimintaalueToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.toimintaalueToolStripMenuItem.Text = "Toiminta-alue";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslKello});
            this.statusStrip1.Location = new System.Drawing.Point(0, 593);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(955, 26);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslKello
            // 
            this.tsslKello.Name = "tsslKello";
            this.tsslKello.Size = new System.Drawing.Size(41, 20);
            this.tsslKello.Text = "        ";
            // 
            // timer1KellonAika
            // 
            this.timer1KellonAika.Tick += new System.EventHandler(this.timer1KellonAika_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(955, 565);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.tbSposti);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tbSumma);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnVahvista);
            this.tabPage1.Controls.Add(this.tbAlv);
            this.tabPage1.Controls.Add(this.tbNimi);
            this.tabPage1.Controls.Add(this.tbVarausID);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgvLaskut);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(947, 536);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Laskutus";
            // 
            // tbSposti
            // 
            this.tbSposti.Enabled = false;
            this.tbSposti.Location = new System.Drawing.Point(23, 231);
            this.tbSposti.Name = "tbSposti";
            this.tbSposti.Size = new System.Drawing.Size(140, 22);
            this.tbSposti.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "Sähköpostiosoite";
            // 
            // tbSumma
            // 
            this.tbSumma.Enabled = false;
            this.tbSumma.Location = new System.Drawing.Point(26, 304);
            this.tbSumma.Name = "tbSumma";
            this.tbSumma.Size = new System.Drawing.Size(100, 22);
            this.tbSumma.TabIndex = 40;
            this.tbSumma.TextChanged += new System.EventHandler(this.tbSumma_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Summa";
            // 
            // btnVahvista
            // 
            this.btnVahvista.Location = new System.Drawing.Point(23, 466);
            this.btnVahvista.Name = "btnVahvista";
            this.btnVahvista.Size = new System.Drawing.Size(97, 31);
            this.btnVahvista.TabIndex = 38;
            this.btnVahvista.Text = "Vahvista";
            this.btnVahvista.UseVisualStyleBackColor = true;
            this.btnVahvista.Click += new System.EventHandler(this.btnVahvista_Click);
            // 
            // tbAlv
            // 
            this.tbAlv.Enabled = false;
            this.tbAlv.Location = new System.Drawing.Point(26, 373);
            this.tbAlv.Name = "tbAlv";
            this.tbAlv.Size = new System.Drawing.Size(100, 22);
            this.tbAlv.TabIndex = 37;
            // 
            // tbNimi
            // 
            this.tbNimi.Enabled = false;
            this.tbNimi.Location = new System.Drawing.Point(23, 153);
            this.tbNimi.Name = "tbNimi";
            this.tbNimi.Size = new System.Drawing.Size(140, 22);
            this.tbNimi.TabIndex = 36;
            // 
            // tbVarausID
            // 
            this.tbVarausID.Enabled = false;
            this.tbVarausID.Location = new System.Drawing.Point(23, 84);
            this.tbVarausID.Name = "tbVarausID";
            this.tbVarausID.Size = new System.Drawing.Size(100, 22);
            this.tbVarausID.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Alv";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Nimi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Varausnumero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "Laskutustiedot";
            // 
            // dgvLaskut
            // 
            this.dgvLaskut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLaskut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaskut.Location = new System.Drawing.Point(191, 8);
            this.dgvLaskut.Name = "dgvLaskut";
            this.dgvLaskut.RowHeadersWidth = 51;
            this.dgvLaskut.RowTemplate.Height = 24;
            this.dgvLaskut.Size = new System.Drawing.Size(737, 489);
            this.dgvLaskut.TabIndex = 30;
            this.dgvLaskut.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLaskut_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tbPoistaID);
            this.tabPage2.Controls.Add(this.btnPoista);
            this.tabPage2.Controls.Add(this.dgvVahvistetutLaskut);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(947, 536);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vahvistetut laskut";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Laskunumero";
            // 
            // tbPoistaID
            // 
            this.tbPoistaID.Enabled = false;
            this.tbPoistaID.Location = new System.Drawing.Point(23, 72);
            this.tbPoistaID.Name = "tbPoistaID";
            this.tbPoistaID.Size = new System.Drawing.Size(77, 22);
            this.tbPoistaID.TabIndex = 2;
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(6, 156);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(136, 55);
            this.btnPoista.TabIndex = 1;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // dgvVahvistetutLaskut
            // 
            this.dgvVahvistetutLaskut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVahvistetutLaskut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVahvistetutLaskut.Location = new System.Drawing.Point(151, 3);
            this.dgvVahvistetutLaskut.Name = "dgvVahvistetutLaskut";
            this.dgvVahvistetutLaskut.RowHeadersWidth = 51;
            this.dgvVahvistetutLaskut.RowTemplate.Height = 24;
            this.dgvVahvistetutLaskut.Size = new System.Drawing.Size(793, 528);
            this.dgvVahvistetutLaskut.TabIndex = 0;
            this.dgvVahvistetutLaskut.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVahvistetutLaskut_CellClick);
            // 
            // Laskutustiedot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 619);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Laskutustiedot";
            this.Text = "Laskutustiedot";
            this.Load += new System.EventHandler(this.Laskut_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaskut)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVahvistetutLaskut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem avaaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mokkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asiakasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem palvelutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toimintaalueToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslKello;
        private System.Windows.Forms.Timer timer1KellonAika;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbSposti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSumma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVahvista;
        private System.Windows.Forms.TextBox tbAlv;
        private System.Windows.Forms.TextBox tbNimi;
        private System.Windows.Forms.TextBox tbVarausID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLaskut;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvVahvistetutLaskut;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.TextBox tbPoistaID;
        private System.Windows.Forms.Label label7;
    }
}