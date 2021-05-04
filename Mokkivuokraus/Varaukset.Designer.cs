
namespace Mokkivuokraus
{
    partial class Varaukset
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
            this.villageNewbiesDataset = new Mokkivuokraus.VillageNewbiesDataset();
            this.asiakasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asiakasTableAdapter = new Mokkivuokraus.VillageNewbiesDatasetTableAdapters.asiakasTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabVaraukset = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbVarausID = new System.Windows.Forms.TextBox();
            this.btnVaraa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMokkiID = new System.Windows.Forms.TextBox();
            this.tbAsiakasID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpVarattuLoppupvm = new System.Windows.Forms.DateTimePicker();
            this.dtpVarattuAlkupvm = new System.Windows.Forms.DateTimePicker();
            this.dgvVaraus = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLisaaPalvelu = new System.Windows.Forms.Button();
            this.tbLukumaara = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbPalveluID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbVarausPalveluVarausID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvVarauksenPalvelut = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.avaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mokkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asiakasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.palvelutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toimintaalueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lisääToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tyhjennäTiedotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslKello = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1Kellonaika = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.villageNewbiesDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabVaraukset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraus)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarauksenPalvelut)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // villageNewbiesDataset
            // 
            this.villageNewbiesDataset.DataSetName = "VillageNewbiesDataset";
            this.villageNewbiesDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asiakasBindingSource
            // 
            this.asiakasBindingSource.DataMember = "asiakas";
            this.asiakasBindingSource.DataSource = this.villageNewbiesDataset;
            // 
            // asiakasTableAdapter
            // 
            this.asiakasTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabVaraukset);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1012, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // tabVaraukset
            // 
            this.tabVaraukset.BackColor = System.Drawing.SystemColors.Control;
            this.tabVaraukset.Controls.Add(this.button1);
            this.tabVaraukset.Controls.Add(this.label6);
            this.tabVaraukset.Controls.Add(this.tbVarausID);
            this.tabVaraukset.Controls.Add(this.btnVaraa);
            this.tabVaraukset.Controls.Add(this.label5);
            this.tabVaraukset.Controls.Add(this.label4);
            this.tabVaraukset.Controls.Add(this.label3);
            this.tabVaraukset.Controls.Add(this.tbMokkiID);
            this.tabVaraukset.Controls.Add(this.tbAsiakasID);
            this.tabVaraukset.Controls.Add(this.label2);
            this.tabVaraukset.Controls.Add(this.label1);
            this.tabVaraukset.Controls.Add(this.dtpVarattuLoppupvm);
            this.tabVaraukset.Controls.Add(this.dtpVarattuAlkupvm);
            this.tabVaraukset.Controls.Add(this.dgvVaraus);
            this.tabVaraukset.Location = new System.Drawing.Point(4, 25);
            this.tabVaraukset.Name = "tabVaraukset";
            this.tabVaraukset.Padding = new System.Windows.Forms.Padding(3);
            this.tabVaraukset.Size = new System.Drawing.Size(1004, 420);
            this.tabVaraukset.TabIndex = 0;
            this.tabVaraukset.Text = "Varaukset";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 54);
            this.button1.TabIndex = 34;
            this.button1.Text = "Lisää varauspalvelu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Varaus ID";
            // 
            // tbVarausID
            // 
            this.tbVarausID.Location = new System.Drawing.Point(14, 83);
            this.tbVarausID.Name = "tbVarausID";
            this.tbVarausID.Size = new System.Drawing.Size(114, 22);
            this.tbVarausID.TabIndex = 25;
            // 
            // btnVaraa
            // 
            this.btnVaraa.Location = new System.Drawing.Point(231, 118);
            this.btnVaraa.Name = "btnVaraa";
            this.btnVaraa.Size = new System.Drawing.Size(105, 40);
            this.btnVaraa.TabIndex = 24;
            this.btnVaraa.Text = "Varaa";
            this.btnVaraa.UseVisualStyleBackColor = true;
            this.btnVaraa.Click += new System.EventHandler(this.btnVaraa_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 29);
            this.label5.TabIndex = 23;
            this.label5.Text = "Varaukset";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Mökki ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Asiakas ID";
            // 
            // tbMokkiID
            // 
            this.tbMokkiID.Location = new System.Drawing.Point(14, 219);
            this.tbMokkiID.Name = "tbMokkiID";
            this.tbMokkiID.Size = new System.Drawing.Size(114, 22);
            this.tbMokkiID.TabIndex = 20;
            // 
            // tbAsiakasID
            // 
            this.tbAsiakasID.Location = new System.Drawing.Point(14, 149);
            this.tbAsiakasID.Name = "tbAsiakasID";
            this.tbAsiakasID.Size = new System.Drawing.Size(114, 22);
            this.tbAsiakasID.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Päättymispäivä";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Alkamispäivä";
            // 
            // dtpVarattuLoppupvm
            // 
            this.dtpVarattuLoppupvm.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVarattuLoppupvm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpVarattuLoppupvm.Location = new System.Drawing.Point(17, 375);
            this.dtpVarattuLoppupvm.Name = "dtpVarattuLoppupvm";
            this.dtpVarattuLoppupvm.Size = new System.Drawing.Size(114, 22);
            this.dtpVarattuLoppupvm.TabIndex = 16;
            // 
            // dtpVarattuAlkupvm
            // 
            this.dtpVarattuAlkupvm.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVarattuAlkupvm.Location = new System.Drawing.Point(17, 296);
            this.dtpVarattuAlkupvm.Name = "dtpVarattuAlkupvm";
            this.dtpVarattuAlkupvm.Size = new System.Drawing.Size(114, 22);
            this.dtpVarattuAlkupvm.TabIndex = 15;
            // 
            // dgvVaraus
            // 
            this.dgvVaraus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVaraus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVaraus.Location = new System.Drawing.Point(401, 6);
            this.dgvVaraus.Name = "dgvVaraus";
            this.dgvVaraus.RowHeadersWidth = 51;
            this.dgvVaraus.RowTemplate.Height = 24;
            this.dgvVaraus.Size = new System.Drawing.Size(600, 406);
            this.dgvVaraus.TabIndex = 14;
            this.dgvVaraus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVaraus_CellClick);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.btnLisaaPalvelu);
            this.tabPage1.Controls.Add(this.tbLukumaara);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.tbPalveluID);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.tbVarausPalveluVarausID);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.dgvVarauksenPalvelut);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1004, 420);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Varauksen palvelut";
            // 
            // btnLisaaPalvelu
            // 
            this.btnLisaaPalvelu.Location = new System.Drawing.Point(285, 100);
            this.btnLisaaPalvelu.Name = "btnLisaaPalvelu";
            this.btnLisaaPalvelu.Size = new System.Drawing.Size(111, 37);
            this.btnLisaaPalvelu.TabIndex = 8;
            this.btnLisaaPalvelu.Text = "Lisää";
            this.btnLisaaPalvelu.UseVisualStyleBackColor = true;
            this.btnLisaaPalvelu.Click += new System.EventHandler(this.btnLisaaPalvelu_Click);
            // 
            // tbLukumaara
            // 
            this.tbLukumaara.Location = new System.Drawing.Point(46, 306);
            this.tbLukumaara.Name = "tbLukumaara";
            this.tbLukumaara.Size = new System.Drawing.Size(100, 22);
            this.tbLukumaara.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(43, 262);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 17);
            this.label15.TabIndex = 6;
            this.label15.Text = "Lukumäärä";
            // 
            // tbPalveluID
            // 
            this.tbPalveluID.Location = new System.Drawing.Point(46, 210);
            this.tbPalveluID.Name = "tbPalveluID";
            this.tbPalveluID.Size = new System.Drawing.Size(100, 22);
            this.tbPalveluID.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(43, 166);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 17);
            this.label14.TabIndex = 4;
            this.label14.Text = "Palvelu ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(215, 29);
            this.label13.TabIndex = 3;
            this.label13.Text = "Varauksen palvelut";
            // 
            // tbVarausPalveluVarausID
            // 
            this.tbVarausPalveluVarausID.Location = new System.Drawing.Point(46, 115);
            this.tbVarausPalveluVarausID.Name = "tbVarausPalveluVarausID";
            this.tbVarausPalveluVarausID.Size = new System.Drawing.Size(100, 22);
            this.tbVarausPalveluVarausID.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Varaus ID";
            // 
            // dgvVarauksenPalvelut
            // 
            this.dgvVarauksenPalvelut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVarauksenPalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVarauksenPalvelut.Location = new System.Drawing.Point(464, 6);
            this.dgvVarauksenPalvelut.Name = "dgvVarauksenPalvelut";
            this.dgvVarauksenPalvelut.RowHeadersWidth = 51;
            this.dgvVarauksenPalvelut.RowTemplate.Height = 24;
            this.dgvVarauksenPalvelut.Size = new System.Drawing.Size(532, 408);
            this.dgvVarauksenPalvelut.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avaaToolStripMenuItem,
            this.lisääToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1012, 28);
            this.menuStrip1.TabIndex = 2;
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
            this.mokkiToolStripMenuItem.Click += new System.EventHandler(this.mokkiToolStripMenuItem_Click);
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
            // toimintaalueToolStripMenuItem
            // 
            this.toimintaalueToolStripMenuItem.Name = "toimintaalueToolStripMenuItem";
            this.toimintaalueToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.toimintaalueToolStripMenuItem.Text = "Toiminta-alue";
            this.toimintaalueToolStripMenuItem.Click += new System.EventHandler(this.toimintaalueToolStripMenuItem_Click);
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
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslKello});
            this.statusStrip1.Location = new System.Drawing.Point(0, 485);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1012, 26);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslKello
            // 
            this.tsslKello.Name = "tsslKello";
            this.tsslKello.Size = new System.Drawing.Size(41, 20);
            this.tsslKello.Text = "        ";
            // 
            // timer1Kellonaika
            // 
            this.timer1Kellonaika.Tick += new System.EventHandler(this.timer1Kellonaika_Tick);
            // 
            // Varaukset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 511);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Varaukset";
            this.Text = "Varaukset";
            this.Load += new System.EventHandler(this.Varaukset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.villageNewbiesDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabVaraukset.ResumeLayout(false);
            this.tabVaraukset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraus)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarauksenPalvelut)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private VillageNewbiesDataset villageNewbiesDataset;
        private System.Windows.Forms.BindingSource asiakasBindingSource;
        private VillageNewbiesDatasetTableAdapters.asiakasTableAdapter asiakasTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabVaraukset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbVarausID;
        private System.Windows.Forms.Button btnVaraa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMokkiID;
        private System.Windows.Forms.TextBox tbAsiakasID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpVarattuLoppupvm;
        private System.Windows.Forms.DateTimePicker dtpVarattuAlkupvm;
        private System.Windows.Forms.DataGridView dgvVaraus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem avaaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mokkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asiakasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem palvelutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lisääToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tyhjennäTiedotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toimintaalueToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslKello;
        private System.Windows.Forms.Timer timer1Kellonaika;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbLukumaara;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbPalveluID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbVarausPalveluVarausID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvVarauksenPalvelut;
        private System.Windows.Forms.Button btnLisaaPalvelu;
        private System.Windows.Forms.Button button1;
    }
}