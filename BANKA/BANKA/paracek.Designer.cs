namespace BANKA
{
    partial class paracek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paracek));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mskdhesapno = new System.Windows.Forms.MaskedTextBox();
            this.datetarih = new System.Windows.Forms.DateTimePicker();
            this.mskdcekilenmiktar = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.mskdbakiye = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbbankaDataSet5 = new BANKA.dbbankaDataSet5();
            this.tblmusteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblmusteriTableAdapter = new BANKA.dbbankaDataSet5TableAdapters.tblmusteriTableAdapter();
            this.musteriNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hesapNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bakiyeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriTipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbbankaDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmusteriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(313, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Para Çekme";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(771, 568);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "GERİ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(144, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hesap No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(172, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 40);
            this.label6.TabIndex = 6;
            this.label6.Text = "BAKİYE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(179, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 40);
            this.label7.TabIndex = 7;
            this.label7.Text = "TARİH:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label8.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(20, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(264, 40);
            this.label8.TabIndex = 8;
            this.label8.Text = "ÇEKİLECEK MİKTAR:";
            // 
            // mskdhesapno
            // 
            this.mskdhesapno.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskdhesapno.Location = new System.Drawing.Point(335, 109);
            this.mskdhesapno.Mask = "000000";
            this.mskdhesapno.Name = "mskdhesapno";
            this.mskdhesapno.Size = new System.Drawing.Size(283, 43);
            this.mskdhesapno.TabIndex = 9;
            this.mskdhesapno.ValidatingType = typeof(int);
            this.mskdhesapno.TextChanged += new System.EventHandler(this.mskdhesapno_TextChanged);
            // 
            // datetarih
            // 
            this.datetarih.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.datetarih.Location = new System.Drawing.Point(335, 315);
            this.datetarih.Name = "datetarih";
            this.datetarih.Size = new System.Drawing.Size(338, 43);
            this.datetarih.TabIndex = 14;
            // 
            // mskdcekilenmiktar
            // 
            this.mskdcekilenmiktar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskdcekilenmiktar.Location = new System.Drawing.Point(335, 242);
            this.mskdcekilenmiktar.Mask = "000000";
            this.mskdcekilenmiktar.Name = "mskdcekilenmiktar";
            this.mskdcekilenmiktar.Size = new System.Drawing.Size(283, 43);
            this.mskdcekilenmiktar.TabIndex = 15;
            this.mskdcekilenmiktar.ValidatingType = typeof(int);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(653, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 104);
            this.button2.TabIndex = 16;
            this.button2.Text = "İŞLEM GERÇEKLEŞTİR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mskdbakiye
            // 
            this.mskdbakiye.Enabled = false;
            this.mskdbakiye.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskdbakiye.Location = new System.Drawing.Point(335, 171);
            this.mskdbakiye.Name = "mskdbakiye";
            this.mskdbakiye.Size = new System.Drawing.Size(283, 43);
            this.mskdbakiye.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriNoDataGridViewTextBoxColumn,
            this.hesapNoDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.bakiyeDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn,
            this.musteriTipDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblmusteriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(77, 409);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(596, 183);
            this.dataGridView1.TabIndex = 18;
            // 
            // dbbankaDataSet5
            // 
            this.dbbankaDataSet5.DataSetName = "dbbankaDataSet5";
            this.dbbankaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblmusteriBindingSource
            // 
            this.tblmusteriBindingSource.DataMember = "tblmusteri";
            this.tblmusteriBindingSource.DataSource = this.dbbankaDataSet5;
            // 
            // tblmusteriTableAdapter
            // 
            this.tblmusteriTableAdapter.ClearBeforeFill = true;
            // 
            // musteriNoDataGridViewTextBoxColumn
            // 
            this.musteriNoDataGridViewTextBoxColumn.DataPropertyName = "MusteriNo";
            this.musteriNoDataGridViewTextBoxColumn.HeaderText = "MusteriNo";
            this.musteriNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriNoDataGridViewTextBoxColumn.Name = "musteriNoDataGridViewTextBoxColumn";
            this.musteriNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.musteriNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // hesapNoDataGridViewTextBoxColumn
            // 
            this.hesapNoDataGridViewTextBoxColumn.DataPropertyName = "HesapNo";
            this.hesapNoDataGridViewTextBoxColumn.HeaderText = "HesapNo";
            this.hesapNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hesapNoDataGridViewTextBoxColumn.Name = "hesapNoDataGridViewTextBoxColumn";
            this.hesapNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // bakiyeDataGridViewTextBoxColumn
            // 
            this.bakiyeDataGridViewTextBoxColumn.DataPropertyName = "Bakiye";
            this.bakiyeDataGridViewTextBoxColumn.HeaderText = "Bakiye";
            this.bakiyeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bakiyeDataGridViewTextBoxColumn.Name = "bakiyeDataGridViewTextBoxColumn";
            this.bakiyeDataGridViewTextBoxColumn.Width = 125;
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "Sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "Sifre";
            this.sifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            this.sifreDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriTipDataGridViewTextBoxColumn
            // 
            this.musteriTipDataGridViewTextBoxColumn.DataPropertyName = "MusteriTip";
            this.musteriTipDataGridViewTextBoxColumn.HeaderText = "MusteriTip";
            this.musteriTipDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriTipDataGridViewTextBoxColumn.Name = "musteriTipDataGridViewTextBoxColumn";
            this.musteriTipDataGridViewTextBoxColumn.Width = 125;
            // 
            // paracek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(880, 636);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mskdbakiye);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.mskdcekilenmiktar);
            this.Controls.Add(this.datetarih);
            this.Controls.Add(this.mskdhesapno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "paracek";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.paracek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbbankaDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmusteriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskdhesapno;
        private System.Windows.Forms.DateTimePicker datetarih;
        private System.Windows.Forms.MaskedTextBox mskdcekilenmiktar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox mskdbakiye;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dbbankaDataSet5 dbbankaDataSet5;
        private System.Windows.Forms.BindingSource tblmusteriBindingSource;
        private dbbankaDataSet5TableAdapters.tblmusteriTableAdapter tblmusteriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hesapNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bakiyeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriTipDataGridViewTextBoxColumn;
    }
}