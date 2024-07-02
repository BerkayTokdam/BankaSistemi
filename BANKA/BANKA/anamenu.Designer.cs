namespace BANKA
{
    partial class anamenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anamenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraÇekmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraYatırmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.havaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.müşteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dbbankaDataSet2 = new BANKA.dbbankaDataSet2();
            this.dbbankaDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbbankaDataSet = new BANKA.dbbankaDataSet();
            this.dbbankaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbbankaDataSet3 = new BANKA.dbbankaDataSet3();
            this.tblmusteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblmusteriTableAdapter = new BANKA.dbbankaDataSet3TableAdapters.tblmusteriTableAdapter();
            this.musteriNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hesapNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bakiyeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriTipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbbankaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbbankaDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbbankaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbbankaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbbankaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmusteriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem,
            this.müşteriİşlemleriToolStripMenuItem,
            this.raporToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(948, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paraÇekmeToolStripMenuItem,
            this.paraYatırmaToolStripMenuItem,
            this.havaleToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // paraÇekmeToolStripMenuItem
            // 
            this.paraÇekmeToolStripMenuItem.Name = "paraÇekmeToolStripMenuItem";
            this.paraÇekmeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.paraÇekmeToolStripMenuItem.Text = "Para Çekme";
            this.paraÇekmeToolStripMenuItem.Click += new System.EventHandler(this.paraÇekmeToolStripMenuItem_Click);
            // 
            // paraYatırmaToolStripMenuItem
            // 
            this.paraYatırmaToolStripMenuItem.Name = "paraYatırmaToolStripMenuItem";
            this.paraYatırmaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.paraYatırmaToolStripMenuItem.Text = "Para Yatırma";
            this.paraYatırmaToolStripMenuItem.Click += new System.EventHandler(this.paraYatırmaToolStripMenuItem_Click);
            // 
            // havaleToolStripMenuItem
            // 
            this.havaleToolStripMenuItem.Name = "havaleToolStripMenuItem";
            this.havaleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.havaleToolStripMenuItem.Text = "Havale";
            this.havaleToolStripMenuItem.Click += new System.EventHandler(this.havaleToolStripMenuItem_Click);
            // 
            // müşteriİşlemleriToolStripMenuItem
            // 
            this.müşteriİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriEkleToolStripMenuItem,
            this.müşteriSilToolStripMenuItem});
            this.müşteriİşlemleriToolStripMenuItem.Name = "müşteriİşlemleriToolStripMenuItem";
            this.müşteriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.müşteriİşlemleriToolStripMenuItem.Text = "Müşteri İşlemleri";
            // 
            // müşteriSilToolStripMenuItem
            // 
            this.müşteriSilToolStripMenuItem.Name = "müşteriSilToolStripMenuItem";
            this.müşteriSilToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.müşteriSilToolStripMenuItem.Text = "Müşteri Sil";
            this.müşteriSilToolStripMenuItem.Click += new System.EventHandler(this.müşteriSilToolStripMenuItem_Click);
            // 
            // raporToolStripMenuItem
            // 
            this.raporToolStripMenuItem.Name = "raporToolStripMenuItem";
            this.raporToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.raporToolStripMenuItem.Text = "Rapor";
            this.raporToolStripMenuItem.Click += new System.EventHandler(this.raporToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(948, 377);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kayıtlı Olan Müşterilerimiz";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(852, 534);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 71);
            this.button1.TabIndex = 3;
            this.button1.Text = "GERİ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 534);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(854, 71);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // müşteriEkleToolStripMenuItem
            // 
            this.müşteriEkleToolStripMenuItem.Name = "müşteriEkleToolStripMenuItem";
            this.müşteriEkleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.müşteriEkleToolStripMenuItem.Text = "Müşteri Ekle";
            this.müşteriEkleToolStripMenuItem.Click += new System.EventHandler(this.müşteriEkleToolStripMenuItem_Click_1);
            // 
            // dbbankaDataSet2
            // 
            this.dbbankaDataSet2.DataSetName = "dbbankaDataSet2";
            this.dbbankaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbbankaDataSet2BindingSource
            // 
            this.dbbankaDataSet2BindingSource.DataSource = this.dbbankaDataSet2;
            this.dbbankaDataSet2BindingSource.Position = 0;
            // 
            // dbbankaDataSet
            // 
            this.dbbankaDataSet.DataSetName = "dbbankaDataSet";
            this.dbbankaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbbankaDataSetBindingSource
            // 
            this.dbbankaDataSetBindingSource.DataSource = this.dbbankaDataSet;
            this.dbbankaDataSetBindingSource.Position = 0;
            // 
            // dbbankaDataSet3
            // 
            this.dbbankaDataSet3.DataSetName = "dbbankaDataSet3";
            this.dbbankaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblmusteriBindingSource
            // 
            this.tblmusteriBindingSource.DataMember = "tblmusteri";
            this.tblmusteriBindingSource.DataSource = this.dbbankaDataSet3;
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
            // anamenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(948, 605);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "anamenu";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.anamenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbbankaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbbankaDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbbankaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbbankaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbbankaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmusteriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraÇekmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraYatırmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem havaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriİşlemleriToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem müşteriSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriEkleToolStripMenuItem;
        private dbbankaDataSet2 dbbankaDataSet2;
        private System.Windows.Forms.BindingSource dbbankaDataSet2BindingSource;
        private dbbankaDataSet dbbankaDataSet;
        private System.Windows.Forms.BindingSource dbbankaDataSetBindingSource;
        private dbbankaDataSet3 dbbankaDataSet3;
        private System.Windows.Forms.BindingSource tblmusteriBindingSource;
        private dbbankaDataSet3TableAdapters.tblmusteriTableAdapter tblmusteriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hesapNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bakiyeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriTipDataGridViewTextBoxColumn;
    }
}