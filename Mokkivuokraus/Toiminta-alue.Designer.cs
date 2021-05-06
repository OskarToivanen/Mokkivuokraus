
namespace Mokkivuokraus
{
    partial class Aloitus
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
            this.dgvToimintaAlue = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ValikkoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mokkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asiakasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.palvelutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.varauksetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laskutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lisääToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uusiVarausToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tyhjennäTiedotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbToimintaAlueID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbToimintaAlue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslKello = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerKellonAika = new System.Windows.Forms.Timer(this.components);
            this.postiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.villageNewbiesDataset = new Mokkivuokraus.VillageNewbiesDataset();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.postiTableAdapter = new Mokkivuokraus.VillageNewbiesDatasetTableAdapters.postiTableAdapter();
            this.dgvPosti = new System.Windows.Forms.DataGridView();
            this.tbPostinumero = new System.Windows.Forms.TextBox();
            this.tbToimipaikka = new System.Windows.Forms.TextBox();
            this.btnSeuraava = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToimintaAlue)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageNewbiesDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvToimintaAlue
            // 
            this.dgvToimintaAlue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvToimintaAlue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToimintaAlue.Location = new System.Drawing.Point(380, 31);
            this.dgvToimintaAlue.Name = "dgvToimintaAlue";
            this.dgvToimintaAlue.RowHeadersWidth = 51;
            this.dgvToimintaAlue.RowTemplate.Height = 24;
            this.dgvToimintaAlue.Size = new System.Drawing.Size(499, 238);
            this.dgvToimintaAlue.TabIndex = 0;
            this.dgvToimintaAlue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvToimintaAlue_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ValikkoToolStripMenuItem,
            this.lisääToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(888, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ValikkoToolStripMenuItem
            // 
            this.ValikkoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mokkiToolStripMenuItem,
            this.asiakasToolStripMenuItem,
            this.palvelutToolStripMenuItem,
            this.varauksetToolStripMenuItem,
            this.laskutToolStripMenuItem});
            this.ValikkoToolStripMenuItem.Name = "ValikkoToolStripMenuItem";
            this.ValikkoToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.ValikkoToolStripMenuItem.Text = "Valikko";
            // 
            // mokkiToolStripMenuItem
            // 
            this.mokkiToolStripMenuItem.Name = "mokkiToolStripMenuItem";
            this.mokkiToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.mokkiToolStripMenuItem.Text = "Mökki";
            this.mokkiToolStripMenuItem.Click += new System.EventHandler(this.mökkiToolStripMenuItem_Click);
            // 
            // asiakasToolStripMenuItem
            // 
            this.asiakasToolStripMenuItem.Name = "asiakasToolStripMenuItem";
            this.asiakasToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.asiakasToolStripMenuItem.Text = "Asiakas";
            this.asiakasToolStripMenuItem.Click += new System.EventHandler(this.asiakasToolStripMenuItem_Click);
            // 
            // palvelutToolStripMenuItem
            // 
            this.palvelutToolStripMenuItem.Name = "palvelutToolStripMenuItem";
            this.palvelutToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.palvelutToolStripMenuItem.Text = "Palvelut";
            this.palvelutToolStripMenuItem.Click += new System.EventHandler(this.palvelutToolStripMenuItem_Click);
            // 
            // varauksetToolStripMenuItem
            // 
            this.varauksetToolStripMenuItem.Name = "varauksetToolStripMenuItem";
            this.varauksetToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.varauksetToolStripMenuItem.Text = "Varaukset";
            this.varauksetToolStripMenuItem.Click += new System.EventHandler(this.varauksetToolStripMenuItem_Click);
            // 
            // laskutToolStripMenuItem
            // 
            this.laskutToolStripMenuItem.Name = "laskutToolStripMenuItem";
            this.laskutToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.laskutToolStripMenuItem.Text = "Laskut";
            this.laskutToolStripMenuItem.Click += new System.EventHandler(this.laskutToolStripMenuItem_Click);
            // 
            // lisääToolStripMenuItem
            // 
            this.lisääToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uusiVarausToolStripMenuItem,
            this.tyhjennäTiedotToolStripMenuItem});
            this.lisääToolStripMenuItem.Name = "lisääToolStripMenuItem";
            this.lisääToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.lisääToolStripMenuItem.Text = "Lisää";
            // 
            // uusiVarausToolStripMenuItem
            // 
            this.uusiVarausToolStripMenuItem.Name = "uusiVarausToolStripMenuItem";
            this.uusiVarausToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.uusiVarausToolStripMenuItem.Text = "Uusi varaus";
            this.uusiVarausToolStripMenuItem.Click += new System.EventHandler(this.uusiVarausToolStripMenuItem_Click);
            // 
            // tyhjennäTiedotToolStripMenuItem
            // 
            this.tyhjennäTiedotToolStripMenuItem.Name = "tyhjennäTiedotToolStripMenuItem";
            this.tyhjennäTiedotToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.tyhjennäTiedotToolStripMenuItem.Text = "Tyhjennä tiedot";
            this.tyhjennäTiedotToolStripMenuItem.Click += new System.EventHandler(this.tyhjennäTiedotToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Toiminta-alue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tunnus";
            // 
            // tbToimintaAlueID
            // 
            this.tbToimintaAlueID.Enabled = false;
            this.tbToimintaAlueID.Location = new System.Drawing.Point(16, 119);
            this.tbToimintaAlueID.Name = "tbToimintaAlueID";
            this.tbToimintaAlueID.Size = new System.Drawing.Size(117, 22);
            this.tbToimintaAlueID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Toiminta-alue";
            // 
            // tbToimintaAlue
            // 
            this.tbToimintaAlue.Location = new System.Drawing.Point(16, 192);
            this.tbToimintaAlue.Name = "tbToimintaAlue";
            this.tbToimintaAlue.Size = new System.Drawing.Size(117, 22);
            this.tbToimintaAlue.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Postinumero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Toimipaikka";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslKello});
            this.statusStrip1.Location = new System.Drawing.Point(0, 527);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(888, 26);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslKello
            // 
            this.tsslKello.Name = "tsslKello";
            this.tsslKello.Size = new System.Drawing.Size(41, 20);
            this.tsslKello.Text = "        ";
            // 
            // timerKellonAika
            // 
            this.timerKellonAika.Tick += new System.EventHandler(this.timerKellonAika_Tick);
            // 
            // postiBindingSource
            // 
            this.postiBindingSource.DataMember = "posti";
            this.postiBindingSource.DataSource = this.villageNewbiesDataset;
            // 
            // villageNewbiesDataset
            // 
            this.villageNewbiesDataset.DataSetName = "VillageNewbiesDataset";
            this.villageNewbiesDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(249, 118);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(82, 34);
            this.btnLisaa.TabIndex = 5;
            this.btnLisaa.Text = "Lisää";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Location = new System.Drawing.Point(249, 191);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(82, 37);
            this.btnMuokkaa.TabIndex = 6;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            this.btnMuokkaa.Click += new System.EventHandler(this.btnMuokkaa_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(249, 272);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(82, 35);
            this.btnPoista.TabIndex = 7;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // postiTableAdapter
            // 
            this.postiTableAdapter.ClearBeforeFill = true;
            // 
            // dgvPosti
            // 
            this.dgvPosti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPosti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosti.Location = new System.Drawing.Point(380, 272);
            this.dgvPosti.Name = "dgvPosti";
            this.dgvPosti.RowHeadersWidth = 51;
            this.dgvPosti.RowTemplate.Height = 24;
            this.dgvPosti.Size = new System.Drawing.Size(499, 252);
            this.dgvPosti.TabIndex = 12;
            this.dgvPosti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPosti_CellClick);
            // 
            // tbPostinumero
            // 
            this.tbPostinumero.Location = new System.Drawing.Point(16, 272);
            this.tbPostinumero.MaxLength = 5;
            this.tbPostinumero.Name = "tbPostinumero";
            this.tbPostinumero.Size = new System.Drawing.Size(117, 22);
            this.tbPostinumero.TabIndex = 3;
            this.tbPostinumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPostinumero_KeyPress);
            // 
            // tbToimipaikka
            // 
            this.tbToimipaikka.Location = new System.Drawing.Point(16, 356);
            this.tbToimipaikka.Name = "tbToimipaikka";
            this.tbToimipaikka.Size = new System.Drawing.Size(117, 22);
            this.tbToimipaikka.TabIndex = 4;
            // 
            // btnSeuraava
            // 
            this.btnSeuraava.Location = new System.Drawing.Point(16, 476);
            this.btnSeuraava.Name = "btnSeuraava";
            this.btnSeuraava.Size = new System.Drawing.Size(104, 33);
            this.btnSeuraava.TabIndex = 13;
            this.btnSeuraava.Text = "Seuraava";
            this.btnSeuraava.UseVisualStyleBackColor = true;
            this.btnSeuraava.Click += new System.EventHandler(this.btnSeuraava_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Aloitus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSeuraava);
            this.Controls.Add(this.tbToimipaikka);
            this.Controls.Add(this.tbPostinumero);
            this.Controls.Add(this.dgvPosti);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnMuokkaa);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbToimintaAlue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbToimintaAlueID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvToimintaAlue);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Aloitus";
            this.Text = "Toiminta-alue";
            this.Load += new System.EventHandler(this.Aloitus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvToimintaAlue)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageNewbiesDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvToimintaAlue;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ValikkoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mokkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asiakasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem palvelutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbToimintaAlueID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbToimintaAlue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslKello;
        private System.Windows.Forms.Timer timerKellonAika;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.Button btnPoista;
        private VillageNewbiesDataset villageNewbiesDataset;
        private System.Windows.Forms.BindingSource postiBindingSource;
        private VillageNewbiesDatasetTableAdapters.postiTableAdapter postiTableAdapter;
        private System.Windows.Forms.DataGridView dgvPosti;
        private System.Windows.Forms.TextBox tbPostinumero;
        private System.Windows.Forms.TextBox tbToimipaikka;
        private System.Windows.Forms.ToolStripMenuItem lisääToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tyhjennäTiedotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem varauksetToolStripMenuItem;
        private System.Windows.Forms.Button btnSeuraava;
        private System.Windows.Forms.ToolStripMenuItem laskutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uusiVarausToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

