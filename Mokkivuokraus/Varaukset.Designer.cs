
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
            this.tabLaskut = new System.Windows.Forms.TabPage();
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
            this.label7 = new System.Windows.Forms.Label();
            this.dgvLaskut = new System.Windows.Forms.DataGridView();
            this.tbLaskuID = new System.Windows.Forms.TextBox();
            this.tbLaskuVarausID = new System.Windows.Forms.TextBox();
            this.tbSumma = new System.Windows.Forms.TextBox();
            this.tbALV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.villageNewbiesDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabVaraukset.SuspendLayout();
            this.tabLaskut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaskut)).BeginInit();
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
            this.tabControl1.Controls.Add(this.tabVaraukset);
            this.tabControl1.Controls.Add(this.tabLaskut);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1010, 459);
            this.tabControl1.TabIndex = 0;
            // 
            // tabVaraukset
            // 
            this.tabVaraukset.BackColor = System.Drawing.SystemColors.Control;
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
            this.tabVaraukset.Size = new System.Drawing.Size(1002, 430);
            this.tabVaraukset.TabIndex = 0;
            this.tabVaraukset.Text = "Varaukset";
            // 
            // tabLaskut
            // 
            this.tabLaskut.BackColor = System.Drawing.SystemColors.Control;
            this.tabLaskut.Controls.Add(this.label11);
            this.tabLaskut.Controls.Add(this.label10);
            this.tabLaskut.Controls.Add(this.label9);
            this.tabLaskut.Controls.Add(this.label8);
            this.tabLaskut.Controls.Add(this.tbALV);
            this.tabLaskut.Controls.Add(this.tbSumma);
            this.tabLaskut.Controls.Add(this.tbLaskuVarausID);
            this.tabLaskut.Controls.Add(this.tbLaskuID);
            this.tabLaskut.Controls.Add(this.dgvLaskut);
            this.tabLaskut.Controls.Add(this.label7);
            this.tabLaskut.Location = new System.Drawing.Point(4, 25);
            this.tabLaskut.Name = "tabLaskut";
            this.tabLaskut.Padding = new System.Windows.Forms.Padding(3);
            this.tabLaskut.Size = new System.Drawing.Size(1002, 430);
            this.tabLaskut.TabIndex = 1;
            this.tabLaskut.Text = "Laskut";
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
            this.tbVarausID.Enabled = false;
            this.tbVarausID.Location = new System.Drawing.Point(14, 83);
            this.tbVarausID.Name = "tbVarausID";
            this.tbVarausID.Size = new System.Drawing.Size(114, 22);
            this.tbVarausID.TabIndex = 25;
            // 
            // btnVaraa
            // 
            this.btnVaraa.Location = new System.Drawing.Point(183, 77);
            this.btnVaraa.Name = "btnVaraa";
            this.btnVaraa.Size = new System.Drawing.Size(105, 40);
            this.btnVaraa.TabIndex = 24;
            this.btnVaraa.Text = "Varaa";
            this.btnVaraa.UseVisualStyleBackColor = true;
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
            this.dgvVaraus.Location = new System.Drawing.Point(319, 47);
            this.dgvVaraus.Name = "dgvVaraus";
            this.dgvVaraus.RowHeadersWidth = 51;
            this.dgvVaraus.RowTemplate.Height = 24;
            this.dgvVaraus.Size = new System.Drawing.Size(672, 375);
            this.dgvVaraus.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Laskut";
            // 
            // dgvLaskut
            // 
            this.dgvLaskut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaskut.Location = new System.Drawing.Point(280, 15);
            this.dgvLaskut.Name = "dgvLaskut";
            this.dgvLaskut.RowHeadersWidth = 51;
            this.dgvLaskut.RowTemplate.Height = 24;
            this.dgvLaskut.Size = new System.Drawing.Size(705, 386);
            this.dgvLaskut.TabIndex = 1;
            this.dgvLaskut.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLaskut_CellContentClick);
            // 
            // tbLaskuID
            // 
            this.tbLaskuID.Enabled = false;
            this.tbLaskuID.Location = new System.Drawing.Point(24, 105);
            this.tbLaskuID.Name = "tbLaskuID";
            this.tbLaskuID.Size = new System.Drawing.Size(100, 22);
            this.tbLaskuID.TabIndex = 2;
            // 
            // tbLaskuVarausID
            // 
            this.tbLaskuVarausID.Location = new System.Drawing.Point(24, 194);
            this.tbLaskuVarausID.Name = "tbLaskuVarausID";
            this.tbLaskuVarausID.Size = new System.Drawing.Size(100, 22);
            this.tbLaskuVarausID.TabIndex = 3;
            // 
            // tbSumma
            // 
            this.tbSumma.Location = new System.Drawing.Point(24, 277);
            this.tbSumma.Name = "tbSumma";
            this.tbSumma.Size = new System.Drawing.Size(100, 22);
            this.tbSumma.TabIndex = 4;
            // 
            // tbALV
            // 
            this.tbALV.Location = new System.Drawing.Point(24, 354);
            this.tbALV.Name = "tbALV";
            this.tbALV.Size = new System.Drawing.Size(100, 22);
            this.tbALV.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Lasku ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Varaus ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Summa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 319);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "ALV";
            // 
            // Varaukset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 459);
            this.Controls.Add(this.tabControl1);
            this.Name = "Varaukset";
            this.Text = "Varaukset";
            this.Load += new System.EventHandler(this.Varaukset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.villageNewbiesDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabVaraukset.ResumeLayout(false);
            this.tabVaraukset.PerformLayout();
            this.tabLaskut.ResumeLayout(false);
            this.tabLaskut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaskut)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TabPage tabLaskut;
        private System.Windows.Forms.DataGridView dgvLaskut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbALV;
        private System.Windows.Forms.TextBox tbSumma;
        private System.Windows.Forms.TextBox tbLaskuVarausID;
        private System.Windows.Forms.TextBox tbLaskuID;
    }
}