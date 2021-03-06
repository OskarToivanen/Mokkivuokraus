
namespace Mokkivuokraus
{
    partial class Mokki
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lToimintaAlue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lPosti_Nro_Muuttuu = new System.Windows.Forms.Label();
            this.lMokki = new System.Windows.Forms.Label();
            this.tbMokkiName = new System.Windows.Forms.TextBox();
            this.lOsoite = new System.Windows.Forms.Label();
            this.tbOsoite = new System.Windows.Forms.TextBox();
            this.lKuvaus = new System.Windows.Forms.Label();
            this.lHenkiloMaara = new System.Windows.Forms.Label();
            this.lVarustelu = new System.Windows.Forms.Label();
            this.btnSeuraava = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.lHinta = new System.Windows.Forms.Label();
            this.tbHinta = new System.Windows.Forms.TextBox();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.dgvMokki = new System.Windows.Forms.DataGridView();
            this.mokkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.villageNewbiesDataset = new Mokkivuokraus.VillageNewbiesDataset();
            this.tbPostiNro = new System.Windows.Forms.TextBox();
            this.lPostiNro = new System.Windows.Forms.Label();
            this.mokkiTableAdapter = new Mokkivuokraus.VillageNewbiesDatasetTableAdapters.mokkiTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbKuvaus = new System.Windows.Forms.TextBox();
            this.tbVarustelu = new System.Windows.Forms.TextBox();
            this.tbHenkiloMr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbToimialue = new System.Windows.Forms.TextBox();
            this.lMokkiID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.avaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toimintaalueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asiakasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.palvelutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.varauksetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lisääToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tyhjennäTiedotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPaivita = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageNewbiesDataset)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mökki ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Toimialue:";
            // 
            // lToimintaAlue
            // 
            this.lToimintaAlue.AutoSize = true;
            this.lToimintaAlue.Location = new System.Drawing.Point(128, 119);
            this.lToimintaAlue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lToimintaAlue.Name = "lToimintaAlue";
            this.lToimintaAlue.Size = new System.Drawing.Size(48, 17);
            this.lToimintaAlue.TabIndex = 3;
            this.lToimintaAlue.Text = "Tahko";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 145);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Postinumero:";
            // 
            // lPosti_Nro_Muuttuu
            // 
            this.lPosti_Nro_Muuttuu.AutoSize = true;
            this.lPosti_Nro_Muuttuu.Location = new System.Drawing.Point(148, 145);
            this.lPosti_Nro_Muuttuu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPosti_Nro_Muuttuu.Name = "lPosti_Nro_Muuttuu";
            this.lPosti_Nro_Muuttuu.Size = new System.Drawing.Size(48, 17);
            this.lPosti_Nro_Muuttuu.TabIndex = 5;
            this.lPosti_Nro_Muuttuu.Text = "70600";
            // 
            // lMokki
            // 
            this.lMokki.AutoSize = true;
            this.lMokki.Location = new System.Drawing.Point(33, 277);
            this.lMokki.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lMokki.Name = "lMokki";
            this.lMokki.Size = new System.Drawing.Size(44, 17);
            this.lMokki.TabIndex = 6;
            this.lMokki.Text = "Mökki";
            // 
            // tbMokkiName
            // 
            this.tbMokkiName.Location = new System.Drawing.Point(37, 297);
            this.tbMokkiName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMokkiName.Name = "tbMokkiName";
            this.tbMokkiName.Size = new System.Drawing.Size(221, 22);
            this.tbMokkiName.TabIndex = 7;
            // 
            // lOsoite
            // 
            this.lOsoite.AutoSize = true;
            this.lOsoite.Location = new System.Drawing.Point(33, 372);
            this.lOsoite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lOsoite.Name = "lOsoite";
            this.lOsoite.Size = new System.Drawing.Size(49, 17);
            this.lOsoite.TabIndex = 8;
            this.lOsoite.Text = "Osoite";
            // 
            // tbOsoite
            // 
            this.tbOsoite.Location = new System.Drawing.Point(37, 391);
            this.tbOsoite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbOsoite.Name = "tbOsoite";
            this.tbOsoite.Size = new System.Drawing.Size(221, 22);
            this.tbOsoite.TabIndex = 9;
            // 
            // lKuvaus
            // 
            this.lKuvaus.AutoSize = true;
            this.lKuvaus.Location = new System.Drawing.Point(33, 512);
            this.lKuvaus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lKuvaus.Name = "lKuvaus";
            this.lKuvaus.Size = new System.Drawing.Size(55, 17);
            this.lKuvaus.TabIndex = 10;
            this.lKuvaus.Text = "Kuvaus";
            // 
            // lHenkiloMaara
            // 
            this.lHenkiloMaara.AutoSize = true;
            this.lHenkiloMaara.Location = new System.Drawing.Point(33, 420);
            this.lHenkiloMaara.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lHenkiloMaara.Name = "lHenkiloMaara";
            this.lHenkiloMaara.Size = new System.Drawing.Size(99, 17);
            this.lHenkiloMaara.TabIndex = 12;
            this.lHenkiloMaara.Text = "Henkilö määrä";
            // 
            // lVarustelu
            // 
            this.lVarustelu.AutoSize = true;
            this.lVarustelu.Location = new System.Drawing.Point(33, 636);
            this.lVarustelu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lVarustelu.Name = "lVarustelu";
            this.lVarustelu.Size = new System.Drawing.Size(68, 17);
            this.lVarustelu.TabIndex = 14;
            this.lVarustelu.Text = "Varustelu";
            // 
            // btnSeuraava
            // 
            this.btnSeuraava.Location = new System.Drawing.Point(1289, 767);
            this.btnSeuraava.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSeuraava.Name = "btnSeuraava";
            this.btnSeuraava.Size = new System.Drawing.Size(117, 42);
            this.btnSeuraava.TabIndex = 16;
            this.btnSeuraava.Text = "Seuraava";
            this.btnSeuraava.UseVisualStyleBackColor = true;
            this.btnSeuraava.Click += new System.EventHandler(this.btnSeuraava_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(32, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 29);
            this.label13.TabIndex = 19;
            this.label13.Text = "Mökin lisäys";
            // 
            // lHinta
            // 
            this.lHinta.AutoSize = true;
            this.lHinta.Location = new System.Drawing.Point(33, 468);
            this.lHinta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lHinta.Name = "lHinta";
            this.lHinta.Size = new System.Drawing.Size(64, 17);
            this.lHinta.TabIndex = 20;
            this.lHinta.Text = "Hinta/vrk";
            // 
            // tbHinta
            // 
            this.tbHinta.Location = new System.Drawing.Point(37, 484);
            this.tbHinta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbHinta.Name = "tbHinta";
            this.tbHinta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbHinta.Size = new System.Drawing.Size(221, 22);
            this.tbHinta.TabIndex = 21;
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(284, 767);
            this.btnLisaa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(117, 42);
            this.btnLisaa.TabIndex = 22;
            this.btnLisaa.Text = "Lisää";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Enabled = false;
            this.btnMuokkaa.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnMuokkaa.Location = new System.Drawing.Point(409, 767);
            this.btnMuokkaa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(117, 42);
            this.btnMuokkaa.TabIndex = 23;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            this.btnMuokkaa.Click += new System.EventHandler(this.btnMuokkaa_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(535, 767);
            this.btnPoista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(117, 42);
            this.btnPoista.TabIndex = 24;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // dgvMokki
            // 
            this.dgvMokki.AllowUserToOrderColumns = true;
            this.dgvMokki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMokki.Location = new System.Drawing.Point(284, 53);
            this.dgvMokki.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMokki.Name = "dgvMokki";
            this.dgvMokki.RowHeadersWidth = 51;
            this.dgvMokki.Size = new System.Drawing.Size(1125, 706);
            this.dgvMokki.TabIndex = 25;
            this.dgvMokki.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgMokki_CellClick);
            this.dgvMokki.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMokki_CellContentClick);
            // 
            // mokkiBindingSource
            // 
            this.mokkiBindingSource.DataMember = "mokki";
            this.mokkiBindingSource.DataSource = this.villageNewbiesDataset;
            // 
            // villageNewbiesDataset
            // 
            this.villageNewbiesDataset.DataSetName = "VillageNewbiesDataset";
            this.villageNewbiesDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbPostiNro
            // 
            this.tbPostiNro.Location = new System.Drawing.Point(37, 343);
            this.tbPostiNro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPostiNro.Name = "tbPostiNro";
            this.tbPostiNro.Size = new System.Drawing.Size(221, 22);
            this.tbPostiNro.TabIndex = 26;
            // 
            // lPostiNro
            // 
            this.lPostiNro.AutoSize = true;
            this.lPostiNro.Location = new System.Drawing.Point(33, 325);
            this.lPostiNro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPostiNro.Name = "lPostiNro";
            this.lPostiNro.Size = new System.Drawing.Size(87, 17);
            this.lPostiNro.TabIndex = 27;
            this.lPostiNro.Text = "Postinumero";
            // 
            // mokkiTableAdapter
            // 
            this.mokkiTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbKuvaus
            // 
            this.tbKuvaus.Location = new System.Drawing.Point(37, 533);
            this.tbKuvaus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbKuvaus.Multiline = true;
            this.tbKuvaus.Name = "tbKuvaus";
            this.tbKuvaus.Size = new System.Drawing.Size(221, 99);
            this.tbKuvaus.TabIndex = 29;
            // 
            // tbVarustelu
            // 
            this.tbVarustelu.Location = new System.Drawing.Point(37, 657);
            this.tbVarustelu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbVarustelu.Multiline = true;
            this.tbVarustelu.Name = "tbVarustelu";
            this.tbVarustelu.Size = new System.Drawing.Size(221, 150);
            this.tbVarustelu.TabIndex = 30;
            // 
            // tbHenkiloMr
            // 
            this.tbHenkiloMr.Location = new System.Drawing.Point(37, 441);
            this.tbHenkiloMr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbHenkiloMr.Name = "tbHenkiloMr";
            this.tbHenkiloMr.Size = new System.Drawing.Size(221, 22);
            this.tbHenkiloMr.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Toimialue";
            // 
            // tbToimialue
            // 
            this.tbToimialue.Location = new System.Drawing.Point(37, 245);
            this.tbToimialue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbToimialue.Name = "tbToimialue";
            this.tbToimialue.Size = new System.Drawing.Size(221, 22);
            this.tbToimialue.TabIndex = 33;
            // 
            // lMokkiID
            // 
            this.lMokkiID.AutoSize = true;
            this.lMokkiID.Location = new System.Drawing.Point(132, 94);
            this.lMokkiID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lMokkiID.Name = "lMokkiID";
            this.lMokkiID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lMokkiID.Size = new System.Drawing.Size(20, 17);
            this.lMokkiID.TabIndex = 34;
            this.lMokkiID.Text = "0 ";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(33, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 46);
            this.label6.TabIndex = 36;
            this.label6.Text = "*ToimialueID täytyy vastata oikeaa postinumeroa";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avaaToolStripMenuItem,
            this.lisääToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1423, 28);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // avaaToolStripMenuItem
            // 
            this.avaaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toimintaalueToolStripMenuItem,
            this.asiakasToolStripMenuItem,
            this.palvelutToolStripMenuItem,
            this.varauksetToolStripMenuItem});
            this.avaaToolStripMenuItem.Name = "avaaToolStripMenuItem";
            this.avaaToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.avaaToolStripMenuItem.Text = "Avaa";
            // 
            // toimintaalueToolStripMenuItem
            // 
            this.toimintaalueToolStripMenuItem.Name = "toimintaalueToolStripMenuItem";
            this.toimintaalueToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.toimintaalueToolStripMenuItem.Text = "Toiminta-alue";
            this.toimintaalueToolStripMenuItem.Click += new System.EventHandler(this.toimintaalueToolStripMenuItem_Click);
            // 
            // asiakasToolStripMenuItem
            // 
            this.asiakasToolStripMenuItem.Name = "asiakasToolStripMenuItem";
            this.asiakasToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.asiakasToolStripMenuItem.Text = "Asiakas";
            this.asiakasToolStripMenuItem.Click += new System.EventHandler(this.asiakasToolStripMenuItem_Click);
            // 
            // palvelutToolStripMenuItem
            // 
            this.palvelutToolStripMenuItem.Name = "palvelutToolStripMenuItem";
            this.palvelutToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.palvelutToolStripMenuItem.Text = "Palvelut";
            this.palvelutToolStripMenuItem.Click += new System.EventHandler(this.palvelutToolStripMenuItem_Click);
            // 
            // varauksetToolStripMenuItem
            // 
            this.varauksetToolStripMenuItem.Name = "varauksetToolStripMenuItem";
            this.varauksetToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.varauksetToolStripMenuItem.Text = "Varaukset";
            this.varauksetToolStripMenuItem.Click += new System.EventHandler(this.varauksetToolStripMenuItem_Click);
            // 
            // lisääToolStripMenuItem
            // 
            this.lisääToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tyhjennäTiedotToolStripMenuItem});
            this.lisääToolStripMenuItem.Name = "lisääToolStripMenuItem";
            this.lisääToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.lisääToolStripMenuItem.Text = "Lisää";
            // 
            // tyhjennäTiedotToolStripMenuItem
            // 
            this.tyhjennäTiedotToolStripMenuItem.Name = "tyhjennäTiedotToolStripMenuItem";
            this.tyhjennäTiedotToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.tyhjennäTiedotToolStripMenuItem.Text = "Tyhjennä tiedot";
            this.tyhjennäTiedotToolStripMenuItem.Click += new System.EventHandler(this.tyhjennäTiedotToolStripMenuItem_Click);
            // 
            // btnPaivita
            // 
            this.btnPaivita.Location = new System.Drawing.Point(660, 767);
            this.btnPaivita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPaivita.Name = "btnPaivita";
            this.btnPaivita.Size = new System.Drawing.Size(117, 42);
            this.btnPaivita.TabIndex = 38;
            this.btnPaivita.Text = "Päivitä";
            this.btnPaivita.UseVisualStyleBackColor = true;
            this.btnPaivita.Click += new System.EventHandler(this.btnPaivita_Click);
            // 
            // Mokki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 823);
            this.Controls.Add(this.btnPaivita);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lMokkiID);
            this.Controls.Add(this.tbToimialue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbHenkiloMr);
            this.Controls.Add(this.tbVarustelu);
            this.Controls.Add(this.tbKuvaus);
            this.Controls.Add(this.lPostiNro);
            this.Controls.Add(this.tbPostiNro);
            this.Controls.Add(this.dgvMokki);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnMuokkaa);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.tbHinta);
            this.Controls.Add(this.lHinta);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnSeuraava);
            this.Controls.Add(this.lVarustelu);
            this.Controls.Add(this.lHenkiloMaara);
            this.Controls.Add(this.lKuvaus);
            this.Controls.Add(this.tbOsoite);
            this.Controls.Add(this.lOsoite);
            this.Controls.Add(this.tbMokkiName);
            this.Controls.Add(this.lMokki);
            this.Controls.Add(this.lPosti_Nro_Muuttuu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lToimintaAlue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Mokki";
            this.Text = "Mokki";
            this.Load += new System.EventHandler(this.Mokki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageNewbiesDataset)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lToimintaAlue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lPosti_Nro_Muuttuu;
        private System.Windows.Forms.Label lMokki;
        private System.Windows.Forms.TextBox tbMokkiName;
        private System.Windows.Forms.Label lOsoite;
        private System.Windows.Forms.TextBox tbOsoite;
        private System.Windows.Forms.Label lKuvaus;
        private System.Windows.Forms.Label lHenkiloMaara;
        private System.Windows.Forms.Label lVarustelu;
        private System.Windows.Forms.Button btnSeuraava;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lHinta;
        private System.Windows.Forms.TextBox tbHinta;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.DataGridView dgvMokki;
        private System.Windows.Forms.BindingSource mokkiBindingSource;
        private VillageNewbiesDataset villageNewbiesDataset;
        private System.Windows.Forms.TextBox tbPostiNro;
        private System.Windows.Forms.Label lPostiNro;
        private VillageNewbiesDatasetTableAdapters.mokkiTableAdapter mokkiTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbKuvaus;
        private System.Windows.Forms.TextBox tbVarustelu;
        private System.Windows.Forms.TextBox tbHenkiloMr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbToimialue;
        private System.Windows.Forms.Label lMokkiID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem avaaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lisääToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toimintaalueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asiakasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem palvelutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem varauksetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tyhjennäTiedotToolStripMenuItem;
        private System.Windows.Forms.Button btnPaivita;
    }
}