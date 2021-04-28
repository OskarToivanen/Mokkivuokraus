
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
            this.mokkiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toimintaalueidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkinimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.katuosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuvausDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.henkilomaaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varusteluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label1.Location = new System.Drawing.Point(25, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mökki ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Toimialue:";
            // 
            // lToimintaAlue
            // 
            this.lToimintaAlue.AutoSize = true;
            this.lToimintaAlue.Location = new System.Drawing.Point(96, 97);
            this.lToimintaAlue.Name = "lToimintaAlue";
            this.lToimintaAlue.Size = new System.Drawing.Size(38, 13);
            this.lToimintaAlue.TabIndex = 3;
            this.lToimintaAlue.Text = "Tahko";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Postinumero:";
            // 
            // lPosti_Nro_Muuttuu
            // 
            this.lPosti_Nro_Muuttuu.AutoSize = true;
            this.lPosti_Nro_Muuttuu.Location = new System.Drawing.Point(111, 118);
            this.lPosti_Nro_Muuttuu.Name = "lPosti_Nro_Muuttuu";
            this.lPosti_Nro_Muuttuu.Size = new System.Drawing.Size(37, 13);
            this.lPosti_Nro_Muuttuu.TabIndex = 5;
            this.lPosti_Nro_Muuttuu.Text = "70600";
            // 
            // lMokki
            // 
            this.lMokki.AutoSize = true;
            this.lMokki.Location = new System.Drawing.Point(25, 225);
            this.lMokki.Name = "lMokki";
            this.lMokki.Size = new System.Drawing.Size(36, 13);
            this.lMokki.TabIndex = 6;
            this.lMokki.Text = "Mökki";
            // 
            // tbMokkiName
            // 
            this.tbMokkiName.Location = new System.Drawing.Point(28, 241);
            this.tbMokkiName.Name = "tbMokkiName";
            this.tbMokkiName.Size = new System.Drawing.Size(167, 20);
            this.tbMokkiName.TabIndex = 7;
            // 
            // lOsoite
            // 
            this.lOsoite.AutoSize = true;
            this.lOsoite.Location = new System.Drawing.Point(25, 302);
            this.lOsoite.Name = "lOsoite";
            this.lOsoite.Size = new System.Drawing.Size(37, 13);
            this.lOsoite.TabIndex = 8;
            this.lOsoite.Text = "Osoite";
            // 
            // tbOsoite
            // 
            this.tbOsoite.Location = new System.Drawing.Point(28, 318);
            this.tbOsoite.Name = "tbOsoite";
            this.tbOsoite.Size = new System.Drawing.Size(167, 20);
            this.tbOsoite.TabIndex = 9;
            // 
            // lKuvaus
            // 
            this.lKuvaus.AutoSize = true;
            this.lKuvaus.Location = new System.Drawing.Point(25, 416);
            this.lKuvaus.Name = "lKuvaus";
            this.lKuvaus.Size = new System.Drawing.Size(43, 13);
            this.lKuvaus.TabIndex = 10;
            this.lKuvaus.Text = "Kuvaus";
            // 
            // lHenkiloMaara
            // 
            this.lHenkiloMaara.AutoSize = true;
            this.lHenkiloMaara.Location = new System.Drawing.Point(25, 341);
            this.lHenkiloMaara.Name = "lHenkiloMaara";
            this.lHenkiloMaara.Size = new System.Drawing.Size(75, 13);
            this.lHenkiloMaara.TabIndex = 12;
            this.lHenkiloMaara.Text = "Henkilö määrä";
            // 
            // lVarustelu
            // 
            this.lVarustelu.AutoSize = true;
            this.lVarustelu.Location = new System.Drawing.Point(25, 517);
            this.lVarustelu.Name = "lVarustelu";
            this.lVarustelu.Size = new System.Drawing.Size(51, 13);
            this.lVarustelu.TabIndex = 14;
            this.lVarustelu.Text = "Varustelu";
            // 
            // btnSeuraava
            // 
            this.btnSeuraava.Location = new System.Drawing.Point(967, 623);
            this.btnSeuraava.Name = "btnSeuraava";
            this.btnSeuraava.Size = new System.Drawing.Size(88, 34);
            this.btnSeuraava.TabIndex = 16;
            this.btnSeuraava.Text = "Seuraava";
            this.btnSeuraava.UseVisualStyleBackColor = true;
            this.btnSeuraava.Click += new System.EventHandler(this.btnSeuraava_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(24, 42);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 24);
            this.label13.TabIndex = 19;
            this.label13.Text = "Mökin lisäys";
            // 
            // lHinta
            // 
            this.lHinta.AutoSize = true;
            this.lHinta.Location = new System.Drawing.Point(25, 380);
            this.lHinta.Name = "lHinta";
            this.lHinta.Size = new System.Drawing.Size(52, 13);
            this.lHinta.TabIndex = 20;
            this.lHinta.Text = "Hinta/vrk";
            // 
            // tbHinta
            // 
            this.tbHinta.Location = new System.Drawing.Point(28, 393);
            this.tbHinta.Name = "tbHinta";
            this.tbHinta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbHinta.Size = new System.Drawing.Size(167, 20);
            this.tbHinta.TabIndex = 21;
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(213, 623);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(88, 34);
            this.btnLisaa.TabIndex = 22;
            this.btnLisaa.Text = "Lisää";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Enabled = false;
            this.btnMuokkaa.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnMuokkaa.Location = new System.Drawing.Point(307, 623);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(88, 34);
            this.btnMuokkaa.TabIndex = 23;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            this.btnMuokkaa.Click += new System.EventHandler(this.btnMuokkaa_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(401, 623);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(88, 34);
            this.btnPoista.TabIndex = 24;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // dgvMokki
            // 
            this.dgvMokki.AllowUserToOrderColumns = true;
            this.dgvMokki.AutoGenerateColumns = false;
            this.dgvMokki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMokki.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mokkiidDataGridViewTextBoxColumn,
            this.toimintaalueidDataGridViewTextBoxColumn,
            this.postinroDataGridViewTextBoxColumn,
            this.mokkinimiDataGridViewTextBoxColumn,
            this.katuosoiteDataGridViewTextBoxColumn,
            this.kuvausDataGridViewTextBoxColumn,
            this.henkilomaaraDataGridViewTextBoxColumn,
            this.varusteluDataGridViewTextBoxColumn});
            this.dgvMokki.DataSource = this.mokkiBindingSource;
            this.dgvMokki.Location = new System.Drawing.Point(213, 43);
            this.dgvMokki.Name = "dgvMokki";
            this.dgvMokki.Size = new System.Drawing.Size(844, 574);
            this.dgvMokki.TabIndex = 25;
            this.dgvMokki.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgMokki_CellClick);
            this.dgvMokki.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMokki_CellContentClick);
            // 
            // mokkiidDataGridViewTextBoxColumn
            // 
            this.mokkiidDataGridViewTextBoxColumn.DataPropertyName = "mokki_id";
            this.mokkiidDataGridViewTextBoxColumn.HeaderText = "mokki_id";
            this.mokkiidDataGridViewTextBoxColumn.Name = "mokkiidDataGridViewTextBoxColumn";
            // 
            // toimintaalueidDataGridViewTextBoxColumn
            // 
            this.toimintaalueidDataGridViewTextBoxColumn.DataPropertyName = "toimintaalue_id";
            this.toimintaalueidDataGridViewTextBoxColumn.HeaderText = "toimintaalue_id";
            this.toimintaalueidDataGridViewTextBoxColumn.Name = "toimintaalueidDataGridViewTextBoxColumn";
            // 
            // postinroDataGridViewTextBoxColumn
            // 
            this.postinroDataGridViewTextBoxColumn.DataPropertyName = "postinro";
            this.postinroDataGridViewTextBoxColumn.HeaderText = "postinro";
            this.postinroDataGridViewTextBoxColumn.Name = "postinroDataGridViewTextBoxColumn";
            // 
            // mokkinimiDataGridViewTextBoxColumn
            // 
            this.mokkinimiDataGridViewTextBoxColumn.DataPropertyName = "mokkinimi";
            this.mokkinimiDataGridViewTextBoxColumn.HeaderText = "mokkinimi";
            this.mokkinimiDataGridViewTextBoxColumn.Name = "mokkinimiDataGridViewTextBoxColumn";
            // 
            // katuosoiteDataGridViewTextBoxColumn
            // 
            this.katuosoiteDataGridViewTextBoxColumn.DataPropertyName = "katuosoite";
            this.katuosoiteDataGridViewTextBoxColumn.HeaderText = "katuosoite";
            this.katuosoiteDataGridViewTextBoxColumn.Name = "katuosoiteDataGridViewTextBoxColumn";
            // 
            // kuvausDataGridViewTextBoxColumn
            // 
            this.kuvausDataGridViewTextBoxColumn.DataPropertyName = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn.HeaderText = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn.Name = "kuvausDataGridViewTextBoxColumn";
            // 
            // henkilomaaraDataGridViewTextBoxColumn
            // 
            this.henkilomaaraDataGridViewTextBoxColumn.DataPropertyName = "henkilomaara";
            this.henkilomaaraDataGridViewTextBoxColumn.HeaderText = "henkilomaara";
            this.henkilomaaraDataGridViewTextBoxColumn.Name = "henkilomaaraDataGridViewTextBoxColumn";
            // 
            // varusteluDataGridViewTextBoxColumn
            // 
            this.varusteluDataGridViewTextBoxColumn.DataPropertyName = "varustelu";
            this.varusteluDataGridViewTextBoxColumn.HeaderText = "varustelu";
            this.varusteluDataGridViewTextBoxColumn.Name = "varusteluDataGridViewTextBoxColumn";
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
            this.tbPostiNro.Location = new System.Drawing.Point(28, 279);
            this.tbPostiNro.Name = "tbPostiNro";
            this.tbPostiNro.Size = new System.Drawing.Size(167, 20);
            this.tbPostiNro.TabIndex = 26;
            // 
            // lPostiNro
            // 
            this.lPostiNro.AutoSize = true;
            this.lPostiNro.Location = new System.Drawing.Point(25, 264);
            this.lPostiNro.Name = "lPostiNro";
            this.lPostiNro.Size = new System.Drawing.Size(65, 13);
            this.lPostiNro.TabIndex = 27;
            this.lPostiNro.Text = "Postinumero";
            // 
            // mokkiTableAdapter
            // 
            this.mokkiTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbKuvaus
            // 
            this.tbKuvaus.Location = new System.Drawing.Point(28, 433);
            this.tbKuvaus.Multiline = true;
            this.tbKuvaus.Name = "tbKuvaus";
            this.tbKuvaus.Size = new System.Drawing.Size(167, 81);
            this.tbKuvaus.TabIndex = 29;
            // 
            // tbVarustelu
            // 
            this.tbVarustelu.Location = new System.Drawing.Point(28, 534);
            this.tbVarustelu.Multiline = true;
            this.tbVarustelu.Name = "tbVarustelu";
            this.tbVarustelu.Size = new System.Drawing.Size(167, 123);
            this.tbVarustelu.TabIndex = 30;
            // 
            // tbHenkiloMr
            // 
            this.tbHenkiloMr.Location = new System.Drawing.Point(28, 358);
            this.tbHenkiloMr.Name = "tbHenkiloMr";
            this.tbHenkiloMr.Size = new System.Drawing.Size(167, 20);
            this.tbHenkiloMr.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Toimialue";
            // 
            // tbToimialue
            // 
            this.tbToimialue.Location = new System.Drawing.Point(28, 199);
            this.tbToimialue.Name = "tbToimialue";
            this.tbToimialue.Size = new System.Drawing.Size(167, 20);
            this.tbToimialue.TabIndex = 33;
            // 
            // lMokkiID
            // 
            this.lMokkiID.AutoSize = true;
            this.lMokkiID.Location = new System.Drawing.Point(99, 76);
            this.lMokkiID.Name = "lMokkiID";
            this.lMokkiID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lMokkiID.Size = new System.Drawing.Size(13, 13);
            this.lMokkiID.TabIndex = 34;
            this.lMokkiID.Text = "0";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(25, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 37);
            this.label6.TabIndex = 36;
            this.label6.Text = "*ToimialueID täytyy vastata oikeaa postinumeroa";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avaaToolStripMenuItem,
            this.lisääToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 24);
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
            this.avaaToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.avaaToolStripMenuItem.Text = "Avaa";
            // 
            // toimintaalueToolStripMenuItem
            // 
            this.toimintaalueToolStripMenuItem.Name = "toimintaalueToolStripMenuItem";
            this.toimintaalueToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.toimintaalueToolStripMenuItem.Text = "Toiminta-alue";
            this.toimintaalueToolStripMenuItem.Click += new System.EventHandler(this.toimintaalueToolStripMenuItem_Click);
            // 
            // asiakasToolStripMenuItem
            // 
            this.asiakasToolStripMenuItem.Name = "asiakasToolStripMenuItem";
            this.asiakasToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.asiakasToolStripMenuItem.Text = "Asiakas";
            this.asiakasToolStripMenuItem.Click += new System.EventHandler(this.asiakasToolStripMenuItem_Click);
            // 
            // palvelutToolStripMenuItem
            // 
            this.palvelutToolStripMenuItem.Name = "palvelutToolStripMenuItem";
            this.palvelutToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.palvelutToolStripMenuItem.Text = "Palvelut";
            this.palvelutToolStripMenuItem.Click += new System.EventHandler(this.palvelutToolStripMenuItem_Click);
            // 
            // varauksetToolStripMenuItem
            // 
            this.varauksetToolStripMenuItem.Name = "varauksetToolStripMenuItem";
            this.varauksetToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.varauksetToolStripMenuItem.Text = "Varaukset";
            this.varauksetToolStripMenuItem.Click += new System.EventHandler(this.varauksetToolStripMenuItem_Click);
            // 
            // lisääToolStripMenuItem
            // 
            this.lisääToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tyhjennäTiedotToolStripMenuItem});
            this.lisääToolStripMenuItem.Name = "lisääToolStripMenuItem";
            this.lisääToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.lisääToolStripMenuItem.Text = "Lisää";
            // 
            // tyhjennäTiedotToolStripMenuItem
            // 
            this.tyhjennäTiedotToolStripMenuItem.Name = "tyhjennäTiedotToolStripMenuItem";
            this.tyhjennäTiedotToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.tyhjennäTiedotToolStripMenuItem.Text = "Tyhjennä tiedot";
            this.tyhjennäTiedotToolStripMenuItem.Click += new System.EventHandler(this.tyhjennäTiedotToolStripMenuItem_Click);
            // 
            // btnPaivita
            // 
            this.btnPaivita.Location = new System.Drawing.Point(495, 623);
            this.btnPaivita.Name = "btnPaivita";
            this.btnPaivita.Size = new System.Drawing.Size(88, 34);
            this.btnPaivita.TabIndex = 38;
            this.btnPaivita.Text = "Päivitä";
            this.btnPaivita.UseVisualStyleBackColor = true;
            this.btnPaivita.Click += new System.EventHandler(this.btnPaivita_Click);
            // 
            // Mokki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 669);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toimintaalueidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postinroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkinimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn katuosoiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuvausDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn henkilomaaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varusteluDataGridViewTextBoxColumn;
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