
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
            this.lMokkiID = new System.Windows.Forms.Label();
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
            this.mokkiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toimintaalueidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkinimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.katuosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuvausDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.henkilomaaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varusteluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbKuvaus = new System.Windows.Forms.TextBox();
            this.tbVarustelu = new System.Windows.Forms.TextBox();
            this.tbHenkiloMr = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageNewbiesDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mökki ID:";
            // 
            // lMokkiID
            // 
            this.lMokkiID.AutoSize = true;
            this.lMokkiID.Location = new System.Drawing.Point(93, 43);
            this.lMokkiID.Name = "lMokkiID";
            this.lMokkiID.Size = new System.Drawing.Size(13, 13);
            this.lMokkiID.TabIndex = 1;
            this.lMokkiID.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Toimialue:";
            // 
            // lToimintaAlue
            // 
            this.lToimintaAlue.AutoSize = true;
            this.lToimintaAlue.Location = new System.Drawing.Point(96, 64);
            this.lToimintaAlue.Name = "lToimintaAlue";
            this.lToimintaAlue.Size = new System.Drawing.Size(38, 13);
            this.lToimintaAlue.TabIndex = 3;
            this.lToimintaAlue.Text = "Tahko";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Postinumero:";
            // 
            // lPosti_Nro_Muuttuu
            // 
            this.lPosti_Nro_Muuttuu.AutoSize = true;
            this.lPosti_Nro_Muuttuu.Location = new System.Drawing.Point(111, 85);
            this.lPosti_Nro_Muuttuu.Name = "lPosti_Nro_Muuttuu";
            this.lPosti_Nro_Muuttuu.Size = new System.Drawing.Size(37, 13);
            this.lPosti_Nro_Muuttuu.TabIndex = 5;
            this.lPosti_Nro_Muuttuu.Text = "70600";
            // 
            // lMokki
            // 
            this.lMokki.AutoSize = true;
            this.lMokki.Location = new System.Drawing.Point(25, 104);
            this.lMokki.Name = "lMokki";
            this.lMokki.Size = new System.Drawing.Size(36, 13);
            this.lMokki.TabIndex = 6;
            this.lMokki.Text = "Mökki";
            // 
            // tbMokkiName
            // 
            this.tbMokkiName.Location = new System.Drawing.Point(28, 120);
            this.tbMokkiName.Name = "tbMokkiName";
            this.tbMokkiName.Size = new System.Drawing.Size(167, 20);
            this.tbMokkiName.TabIndex = 7;
            // 
            // lOsoite
            // 
            this.lOsoite.AutoSize = true;
            this.lOsoite.Location = new System.Drawing.Point(25, 181);
            this.lOsoite.Name = "lOsoite";
            this.lOsoite.Size = new System.Drawing.Size(37, 13);
            this.lOsoite.TabIndex = 8;
            this.lOsoite.Text = "Osoite";
            // 
            // tbOsoite
            // 
            this.tbOsoite.Location = new System.Drawing.Point(28, 197);
            this.tbOsoite.Name = "tbOsoite";
            this.tbOsoite.Size = new System.Drawing.Size(167, 20);
            this.tbOsoite.TabIndex = 9;
            // 
            // lKuvaus
            // 
            this.lKuvaus.AutoSize = true;
            this.lKuvaus.Location = new System.Drawing.Point(25, 295);
            this.lKuvaus.Name = "lKuvaus";
            this.lKuvaus.Size = new System.Drawing.Size(43, 13);
            this.lKuvaus.TabIndex = 10;
            this.lKuvaus.Text = "Kuvaus";
            // 
            // lHenkiloMaara
            // 
            this.lHenkiloMaara.AutoSize = true;
            this.lHenkiloMaara.Location = new System.Drawing.Point(25, 220);
            this.lHenkiloMaara.Name = "lHenkiloMaara";
            this.lHenkiloMaara.Size = new System.Drawing.Size(75, 13);
            this.lHenkiloMaara.TabIndex = 12;
            this.lHenkiloMaara.Text = "Henkilö määrä";
            // 
            // lVarustelu
            // 
            this.lVarustelu.AutoSize = true;
            this.lVarustelu.Location = new System.Drawing.Point(25, 410);
            this.lVarustelu.Name = "lVarustelu";
            this.lVarustelu.Size = new System.Drawing.Size(51, 13);
            this.lVarustelu.TabIndex = 14;
            this.lVarustelu.Text = "Varustelu";
            // 
            // btnSeuraava
            // 
            this.btnSeuraava.Location = new System.Drawing.Point(963, 556);
            this.btnSeuraava.Name = "btnSeuraava";
            this.btnSeuraava.Size = new System.Drawing.Size(88, 34);
            this.btnSeuraava.TabIndex = 16;
            this.btnSeuraava.Text = "Seuraava";
            this.btnSeuraava.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(24, 9);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 24);
            this.label13.TabIndex = 19;
            this.label13.Text = "Mökin lisäys";
            // 
            // lHinta
            // 
            this.lHinta.AutoSize = true;
            this.lHinta.Location = new System.Drawing.Point(25, 259);
            this.lHinta.Name = "lHinta";
            this.lHinta.Size = new System.Drawing.Size(52, 13);
            this.lHinta.TabIndex = 20;
            this.lHinta.Text = "Hinta/vrk";
            // 
            // tbHinta
            // 
            this.tbHinta.Location = new System.Drawing.Point(28, 272);
            this.tbHinta.Name = "tbHinta";
            this.tbHinta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbHinta.Size = new System.Drawing.Size(167, 20);
            this.tbHinta.TabIndex = 21;
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(213, 556);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(88, 34);
            this.btnLisaa.TabIndex = 22;
            this.btnLisaa.Text = "Lisää";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Location = new System.Drawing.Point(307, 556);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(88, 34);
            this.btnMuokkaa.TabIndex = 23;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            this.btnMuokkaa.Click += new System.EventHandler(this.btnMuokkaa_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(401, 556);
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
            this.dgvMokki.Size = new System.Drawing.Size(844, 507);
            this.dgvMokki.TabIndex = 25;
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
            this.tbPostiNro.Location = new System.Drawing.Point(28, 158);
            this.tbPostiNro.Name = "tbPostiNro";
            this.tbPostiNro.Size = new System.Drawing.Size(167, 20);
            this.tbPostiNro.TabIndex = 26;
            // 
            // lPostiNro
            // 
            this.lPostiNro.AutoSize = true;
            this.lPostiNro.Location = new System.Drawing.Point(25, 143);
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
            // tbKuvaus
            // 
            this.tbKuvaus.Location = new System.Drawing.Point(28, 312);
            this.tbKuvaus.Multiline = true;
            this.tbKuvaus.Name = "tbKuvaus";
            this.tbKuvaus.Size = new System.Drawing.Size(167, 81);
            this.tbKuvaus.TabIndex = 29;
            // 
            // tbVarustelu
            // 
            this.tbVarustelu.Location = new System.Drawing.Point(28, 427);
            this.tbVarustelu.Multiline = true;
            this.tbVarustelu.Name = "tbVarustelu";
            this.tbVarustelu.Size = new System.Drawing.Size(167, 123);
            this.tbVarustelu.TabIndex = 30;
            // 
            // tbHenkiloMr
            // 
            this.tbHenkiloMr.Location = new System.Drawing.Point(28, 237);
            this.tbHenkiloMr.Name = "tbHenkiloMr";
            this.tbHenkiloMr.Size = new System.Drawing.Size(167, 20);
            this.tbHenkiloMr.TabIndex = 31;
            // 
            // Mokki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 601);
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
            this.Controls.Add(this.lMokkiID);
            this.Controls.Add(this.label1);
            this.Name = "Mokki";
            this.Text = "Mokki";
            this.Load += new System.EventHandler(this.Mokki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageNewbiesDataset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lMokkiID;
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
    }
}