namespace BANKA
{
    partial class rapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rapor));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblgider = new System.Windows.Forms.Label();
            this.lblgelir = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.datagridyatir = new System.Windows.Forms.DataGridView();
            this.datagridcek = new System.Windows.Forms.DataGridView();
            this.datagridhavale = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.mskdhesapno = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridyatir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridcek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridhavale)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "RAPOR";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(865, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 560);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.lblgider);
            this.panel3.Controls.Add(this.lblgelir);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(68, 114);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(422, 244);
            this.panel3.TabIndex = 1;
            // 
            // lblgider
            // 
            this.lblgider.AutoSize = true;
            this.lblgider.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgider.Location = new System.Drawing.Point(256, 145);
            this.lblgider.Name = "lblgider";
            this.lblgider.Size = new System.Drawing.Size(22, 24);
            this.lblgider.TabIndex = 3;
            this.lblgider.Text = "0";
            // 
            // lblgelir
            // 
            this.lblgelir.AutoSize = true;
            this.lblgelir.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgelir.Location = new System.Drawing.Point(256, 60);
            this.lblgelir.Name = "lblgelir";
            this.lblgelir.Size = new System.Drawing.Size(22, 24);
            this.lblgelir.TabIndex = 2;
            this.lblgelir.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(86, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Toplam Gider:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(86, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Toplam Gelir:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(199, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Banka Gelir Gider";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.date2);
            this.panel2.Controls.Add(this.date1);
            this.panel2.Controls.Add(this.datagridyatir);
            this.panel2.Controls.Add(this.datagridcek);
            this.panel2.Controls.Add(this.datagridhavale);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.mskdhesapno);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(32, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 659);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // datagridyatir
            // 
            this.datagridyatir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridyatir.Location = new System.Drawing.Point(0, 455);
            this.datagridyatir.Name = "datagridyatir";
            this.datagridyatir.RowHeadersWidth = 51;
            this.datagridyatir.RowTemplate.Height = 24;
            this.datagridyatir.Size = new System.Drawing.Size(803, 150);
            this.datagridyatir.TabIndex = 6;
            // 
            // datagridcek
            // 
            this.datagridcek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridcek.Location = new System.Drawing.Point(0, 282);
            this.datagridcek.Name = "datagridcek";
            this.datagridcek.RowHeadersWidth = 51;
            this.datagridcek.RowTemplate.Height = 24;
            this.datagridcek.Size = new System.Drawing.Size(800, 150);
            this.datagridcek.TabIndex = 5;
            // 
            // datagridhavale
            // 
            this.datagridhavale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridhavale.Location = new System.Drawing.Point(0, 114);
            this.datagridhavale.Name = "datagridhavale";
            this.datagridhavale.RowHeadersWidth = 51;
            this.datagridhavale.RowTemplate.Height = 24;
            this.datagridhavale.Size = new System.Drawing.Size(800, 150);
            this.datagridhavale.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(612, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Göster";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mskdhesapno
            // 
            this.mskdhesapno.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskdhesapno.Location = new System.Drawing.Point(141, 41);
            this.mskdhesapno.Name = "mskdhesapno";
            this.mskdhesapno.Size = new System.Drawing.Size(152, 30);
            this.mskdhesapno.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(23, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Hesap No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(364, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Müşteri Hareket";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(1272, 705);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 59);
            this.button1.TabIndex = 3;
            this.button1.Text = "GERİ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // date1
            // 
            this.date1.Location = new System.Drawing.Point(393, 28);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(200, 22);
            this.date1.TabIndex = 7;
            // 
            // date2
            // 
            this.date2.Location = new System.Drawing.Point(393, 72);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(200, 22);
            this.date2.TabIndex = 8;
            // 
            // rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1425, 785);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "rapor";
            this.Text = "rapor";
            this.Load += new System.EventHandler(this.rapor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridyatir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridcek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridhavale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblgider;
        private System.Windows.Forms.Label lblgelir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView datagridcek;
        private System.Windows.Forms.DataGridView datagridhavale;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox mskdhesapno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView datagridyatir;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.DateTimePicker date1;
    }
}