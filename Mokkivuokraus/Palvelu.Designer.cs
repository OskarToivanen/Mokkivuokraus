
namespace Mokkivuokraus
{
    partial class Palvelu
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
            this.dgvPalvelu = new System.Windows.Forms.DataGridView();
            this.tbPalveluID = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.avaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mokkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asiakasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.palvelutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toimintaalueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.varauksetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lisääToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tyhjennäTiedotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.tbToimintaalueID = new System.Windows.Forms.TextBox();
            this.tbNimi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbKuvaus = new System.Windows.Forms.TextBox();
            this.tbHinta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAlv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslKello = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerKellonAika = new System.Windows.Forms.Timer(this.components);
            this.btnPoista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalvelu)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPalvelu
            // 
            this.dgvPalvelu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalvelu.Location = new System.Drawing.Point(327, 45);
            this.dgvPalvelu.Name = "dgvPalvelu";
            this.dgvPalvelu.RowHeadersWidth = 51;
            this.dgvPalvelu.RowTemplate.Height = 24;
            this.dgvPalvelu.Size = new System.Drawing.Size(668, 445);
            this.dgvPalvelu.TabIndex = 0;
            this.dgvPalvelu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPalvelu_CellClick);
            // 
            // tbPalveluID
            // 
            this.tbPalveluID.Enabled = false;
            this.tbPalveluID.Location = new System.Drawing.Point(34, 126);
            this.tbPalveluID.Name = "tbPalveluID";
            this.tbPalveluID.Size = new System.Drawing.Size(71, 22);
            this.tbPalveluID.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avaaToolStripMenuItem,
            this.lisääToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1017, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // avaaToolStripMenuItem
            // 
            this.avaaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mokkiToolStripMenuItem,
            this.asiakasToolStripMenuItem,
            this.palvelutToolStripMenuItem,
            this.toimintaalueToolStripMenuItem,
            this.varauksetToolStripMenuItem});
            this.avaaToolStripMenuItem.Name = "avaaToolStripMenuItem";
            this.avaaToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.avaaToolStripMenuItem.Text = "Valikko";
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
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(34, 452);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(102, 38);
            this.btnLisaa.TabIndex = 4;
            this.btnLisaa.Text = "Lisää";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // tbToimintaalueID
            // 
            this.tbToimintaalueID.Location = new System.Drawing.Point(34, 201);
            this.tbToimintaalueID.Name = "tbToimintaalueID";
            this.tbToimintaalueID.Size = new System.Drawing.Size(71, 22);
            this.tbToimintaalueID.TabIndex = 5;
            // 
            // tbNimi
            // 
            this.tbNimi.Location = new System.Drawing.Point(34, 270);
            this.tbNimi.Name = "tbNimi";
            this.tbNimi.Size = new System.Drawing.Size(135, 22);
            this.tbNimi.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Palvelunumero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Palvelut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Toiminta-alue numero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nimi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kuvaus";
            // 
            // tbKuvaus
            // 
            this.tbKuvaus.Location = new System.Drawing.Point(34, 342);
            this.tbKuvaus.Multiline = true;
            this.tbKuvaus.Name = "tbKuvaus";
            this.tbKuvaus.Size = new System.Drawing.Size(135, 74);
            this.tbKuvaus.TabIndex = 12;
            // 
            // tbHinta
            // 
            this.tbHinta.Location = new System.Drawing.Point(202, 126);
            this.tbHinta.Name = "tbHinta";
            this.tbHinta.Size = new System.Drawing.Size(100, 22);
            this.tbHinta.TabIndex = 13;
            this.tbHinta.TextChanged += new System.EventHandler(this.tbHinta_TextChanged);
            this.tbHinta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHinta_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Hinta";
            // 
            // tbAlv
            // 
            this.tbAlv.Enabled = false;
            this.tbAlv.Location = new System.Drawing.Point(202, 201);
            this.tbAlv.Name = "tbAlv";
            this.tbAlv.Size = new System.Drawing.Size(100, 22);
            this.tbAlv.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(202, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Alv";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslKello});
            this.statusStrip1.Location = new System.Drawing.Point(0, 513);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1017, 26);
            this.statusStrip1.TabIndex = 17;
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
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(164, 452);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(102, 38);
            this.btnPoista.TabIndex = 19;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // Palvelu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 539);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbAlv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbHinta);
            this.Controls.Add(this.tbKuvaus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNimi);
            this.Controls.Add(this.tbToimintaalueID);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tbPalveluID);
            this.Controls.Add(this.dgvPalvelu);
            this.Name = "Palvelu";
            this.Text = "Palvelu";
            this.Load += new System.EventHandler(this.Palvelu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalvelu)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPalvelu;
        private System.Windows.Forms.TextBox tbPalveluID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem avaaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mokkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asiakasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem palvelutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toimintaalueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lisääToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tyhjennäTiedotToolStripMenuItem;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.TextBox tbToimintaalueID;
        private System.Windows.Forms.TextBox tbNimi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbKuvaus;
        private System.Windows.Forms.TextBox tbHinta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAlv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslKello;
        private System.Windows.Forms.Timer timerKellonAika;
        private System.Windows.Forms.ToolStripMenuItem varauksetToolStripMenuItem;
        private System.Windows.Forms.Button btnPoista;
    }
}