
namespace Mokkivuokraus
{
    partial class Asiakas
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
            this.tbEtunimi = new System.Windows.Forms.TextBox();
            this.tbSukunimi = new System.Windows.Forms.TextBox();
            this.tbLahiosoite = new System.Windows.Forms.TextBox();
            this.tbSahkoposti = new System.Windows.Forms.TextBox();
            this.tbPuhelinnumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPostinumero = new System.Windows.Forms.TextBox();
            this.lblAsiakasId = new System.Windows.Forms.Label();
            this.dgvAsiakas = new System.Windows.Forms.DataGridView();
            this.asiakasidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etunimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sukunimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lahiosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puhelinnroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsiakasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.villageNewbiesDataset = new Mokkivuokraus.VillageNewbiesDataset();
            this.asiakasTableAdapter = new Mokkivuokraus.VillageNewbiesDatasetTableAdapters.asiakasTableAdapter();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnPaivita = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnSeuraava = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsiakasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageNewbiesDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEtunimi
            // 
            this.tbEtunimi.Location = new System.Drawing.Point(212, 294);
            this.tbEtunimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEtunimi.Multiline = true;
            this.tbEtunimi.Name = "tbEtunimi";
            this.tbEtunimi.Size = new System.Drawing.Size(163, 32);
            this.tbEtunimi.TabIndex = 0;
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.Location = new System.Drawing.Point(212, 343);
            this.tbSukunimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSukunimi.Multiline = true;
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(163, 34);
            this.tbSukunimi.TabIndex = 1;
            // 
            // tbLahiosoite
            // 
            this.tbLahiosoite.Location = new System.Drawing.Point(212, 389);
            this.tbLahiosoite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLahiosoite.Multiline = true;
            this.tbLahiosoite.Name = "tbLahiosoite";
            this.tbLahiosoite.Size = new System.Drawing.Size(163, 32);
            this.tbLahiosoite.TabIndex = 2;
            // 
            // tbSahkoposti
            // 
            this.tbSahkoposti.Location = new System.Drawing.Point(212, 432);
            this.tbSahkoposti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSahkoposti.Multiline = true;
            this.tbSahkoposti.Name = "tbSahkoposti";
            this.tbSahkoposti.Size = new System.Drawing.Size(163, 32);
            this.tbSahkoposti.TabIndex = 3;
            // 
            // tbPuhelinnumero
            // 
            this.tbPuhelinnumero.Location = new System.Drawing.Point(212, 476);
            this.tbPuhelinnumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPuhelinnumero.Multiline = true;
            this.tbPuhelinnumero.Name = "tbPuhelinnumero";
            this.tbPuhelinnumero.Size = new System.Drawing.Size(163, 34);
            this.tbPuhelinnumero.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Etunimi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sukunimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lähiosoite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sähköposti";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Puhelinnumero";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(113, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 31);
            this.label7.TabIndex = 11;
            this.label7.Text = "Asiakas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Postinumero";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Asiakas ID";
            // 
            // tbPostinumero
            // 
            this.tbPostinumero.Location = new System.Drawing.Point(212, 223);
            this.tbPostinumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPostinumero.Multiline = true;
            this.tbPostinumero.Name = "tbPostinumero";
            this.tbPostinumero.Size = new System.Drawing.Size(163, 37);
            this.tbPostinumero.TabIndex = 15;
            // 
            // lblAsiakasId
            // 
            this.lblAsiakasId.Location = new System.Drawing.Point(212, 183);
            this.lblAsiakasId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsiakasId.Name = "lblAsiakasId";
            this.lblAsiakasId.Size = new System.Drawing.Size(164, 28);
            this.lblAsiakasId.TabIndex = 16;
            this.lblAsiakasId.Text = "0";
            // 
            // dgvAsiakas
            // 
            this.dgvAsiakas.AllowUserToOrderColumns = true;
            this.dgvAsiakas.AutoGenerateColumns = false;
            this.dgvAsiakas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsiakas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asiakasidDataGridViewTextBoxColumn,
            this.postinroDataGridViewTextBoxColumn,
            this.etunimiDataGridViewTextBoxColumn,
            this.sukunimiDataGridViewTextBoxColumn,
            this.lahiosoiteDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.puhelinnroDataGridViewTextBoxColumn});
            this.dgvAsiakas.DataSource = this.AsiakasBindingSource;
            this.dgvAsiakas.Location = new System.Drawing.Point(397, 98);
            this.dgvAsiakas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAsiakas.Name = "dgvAsiakas";
            this.dgvAsiakas.RowHeadersWidth = 51;
            this.dgvAsiakas.Size = new System.Drawing.Size(999, 497);
            this.dgvAsiakas.TabIndex = 17;
            this.dgvAsiakas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgAsiakas_CellClick);
            // 
            // asiakasidDataGridViewTextBoxColumn
            // 
            this.asiakasidDataGridViewTextBoxColumn.DataPropertyName = "asiakas_id";
            this.asiakasidDataGridViewTextBoxColumn.HeaderText = "asiakas_id";
            this.asiakasidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.asiakasidDataGridViewTextBoxColumn.Name = "asiakasidDataGridViewTextBoxColumn";
            this.asiakasidDataGridViewTextBoxColumn.Width = 125;
            // 
            // postinroDataGridViewTextBoxColumn
            // 
            this.postinroDataGridViewTextBoxColumn.DataPropertyName = "postinro";
            this.postinroDataGridViewTextBoxColumn.HeaderText = "postinro";
            this.postinroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.postinroDataGridViewTextBoxColumn.Name = "postinroDataGridViewTextBoxColumn";
            this.postinroDataGridViewTextBoxColumn.Width = 125;
            // 
            // etunimiDataGridViewTextBoxColumn
            // 
            this.etunimiDataGridViewTextBoxColumn.DataPropertyName = "etunimi";
            this.etunimiDataGridViewTextBoxColumn.HeaderText = "etunimi";
            this.etunimiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.etunimiDataGridViewTextBoxColumn.Name = "etunimiDataGridViewTextBoxColumn";
            this.etunimiDataGridViewTextBoxColumn.Width = 125;
            // 
            // sukunimiDataGridViewTextBoxColumn
            // 
            this.sukunimiDataGridViewTextBoxColumn.DataPropertyName = "sukunimi";
            this.sukunimiDataGridViewTextBoxColumn.HeaderText = "sukunimi";
            this.sukunimiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sukunimiDataGridViewTextBoxColumn.Name = "sukunimiDataGridViewTextBoxColumn";
            this.sukunimiDataGridViewTextBoxColumn.Width = 125;
            // 
            // lahiosoiteDataGridViewTextBoxColumn
            // 
            this.lahiosoiteDataGridViewTextBoxColumn.DataPropertyName = "lahiosoite";
            this.lahiosoiteDataGridViewTextBoxColumn.HeaderText = "lahiosoite";
            this.lahiosoiteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lahiosoiteDataGridViewTextBoxColumn.Name = "lahiosoiteDataGridViewTextBoxColumn";
            this.lahiosoiteDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // puhelinnroDataGridViewTextBoxColumn
            // 
            this.puhelinnroDataGridViewTextBoxColumn.DataPropertyName = "puhelinnro";
            this.puhelinnroDataGridViewTextBoxColumn.HeaderText = "puhelinnro";
            this.puhelinnroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.puhelinnroDataGridViewTextBoxColumn.Name = "puhelinnroDataGridViewTextBoxColumn";
            this.puhelinnroDataGridViewTextBoxColumn.Width = 125;
            // 
            // AsiakasBindingSource
            // 
            this.AsiakasBindingSource.DataMember = "asiakas";
            this.AsiakasBindingSource.DataSource = this.villageNewbiesDataset;
            // 
            // villageNewbiesDataset
            // 
            this.villageNewbiesDataset.DataSetName = "VillageNewbiesDataset";
            this.villageNewbiesDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asiakasTableAdapter
            // 
            this.asiakasTableAdapter.ClearBeforeFill = true;
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(67, 692);
            this.btnLisaa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(100, 28);
            this.btnLisaa.TabIndex = 18;
            this.btnLisaa.Text = "Lisää";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // btnPaivita
            // 
            this.btnPaivita.Location = new System.Drawing.Point(233, 692);
            this.btnPaivita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPaivita.Name = "btnPaivita";
            this.btnPaivita.Size = new System.Drawing.Size(100, 28);
            this.btnPaivita.TabIndex = 20;
            this.btnPaivita.Text = "Päivitä";
            this.btnPaivita.UseVisualStyleBackColor = true;
            this.btnPaivita.Click += new System.EventHandler(this.btnPaivita_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(397, 692);
            this.btnPoista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(100, 28);
            this.btnPoista.TabIndex = 21;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // btnSeuraava
            // 
            this.btnSeuraava.Location = new System.Drawing.Point(1273, 681);
            this.btnSeuraava.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSeuraava.Name = "btnSeuraava";
            this.btnSeuraava.Size = new System.Drawing.Size(100, 28);
            this.btnSeuraava.TabIndex = 22;
            this.btnSeuraava.Text = "Seuraava";
            this.btnSeuraava.UseVisualStyleBackColor = true;
            this.btnSeuraava.Click += new System.EventHandler(this.btnSeuraava_Click);
            // 
            // Asiakas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 735);
            this.Controls.Add(this.btnSeuraava);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnPaivita);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.dgvAsiakas);
            this.Controls.Add(this.lblAsiakasId);
            this.Controls.Add(this.tbPostinumero);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPuhelinnumero);
            this.Controls.Add(this.tbSahkoposti);
            this.Controls.Add(this.tbLahiosoite);
            this.Controls.Add(this.tbSukunimi);
            this.Controls.Add(this.tbEtunimi);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Asiakas";
            this.Text = "Asiakas";
            this.Load += new System.EventHandler(this.Asiakas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsiakasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageNewbiesDataset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEtunimi;
        private System.Windows.Forms.TextBox tbSukunimi;
        private System.Windows.Forms.TextBox tbLahiosoite;
        private System.Windows.Forms.TextBox tbSahkoposti;
        private System.Windows.Forms.TextBox tbPuhelinnumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPostinumero;
        private System.Windows.Forms.Label lblAsiakasId;
        private System.Windows.Forms.DataGridView dgvAsiakas;
        private System.Windows.Forms.BindingSource AsiakasBindingSource;
        private VillageNewbiesDataset villageNewbiesDataset;
        private VillageNewbiesDatasetTableAdapters.asiakasTableAdapter asiakasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiakasidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postinroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etunimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sukunimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lahiosoiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puhelinnroDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Button btnPaivita;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnSeuraava;
    }
}