namespace BANKA
{
    partial class havale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(havale));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datetarih = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.mskdalicihesapno = new System.Windows.Forms.MaskedTextBox();
            this.mskdhesapno = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtalicibakiye = new System.Windows.Forms.TextBox();
            this.txtbankahesabi = new System.Windows.Forms.TextBox();
            this.txtyuzde = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mskdbakiye = new System.Windows.Forms.TextBox();
            this.mskdgonderilenmiktar = new System.Windows.Forms.TextBox();
            this.cmbmusteritip = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "HAVALE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(49, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hesap No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(76, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bakiye:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(450, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alıcı Hesap No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(393, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 35);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gönderilecek Miktar:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.cmbmusteritip);
            this.panel1.Controls.Add(this.mskdgonderilenmiktar);
            this.panel1.Controls.Add(this.mskdbakiye);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.datetarih);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.mskdalicihesapno);
            this.panel1.Controls.Add(this.mskdhesapno);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(41, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 322);
            this.panel1.TabIndex = 5;
            // 
            // datetarih
            // 
            this.datetarih.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.datetarih.Location = new System.Drawing.Point(532, 232);
            this.datetarih.Name = "datetarih";
            this.datetarih.Size = new System.Drawing.Size(305, 43);
            this.datetarih.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(421, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 35);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tarih:";
            // 
            // mskdalicihesapno
            // 
            this.mskdalicihesapno.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskdalicihesapno.Location = new System.Drawing.Point(639, 55);
            this.mskdalicihesapno.Mask = "000000";
            this.mskdalicihesapno.Name = "mskdalicihesapno";
            this.mskdalicihesapno.Size = new System.Drawing.Size(169, 43);
            this.mskdalicihesapno.TabIndex = 7;
            this.mskdalicihesapno.ValidatingType = typeof(int);
            this.mskdalicihesapno.TextChanged += new System.EventHandler(this.mskdalicihesapno_TextChanged);
            // 
            // mskdhesapno
            // 
            this.mskdhesapno.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskdhesapno.Location = new System.Drawing.Point(186, 56);
            this.mskdhesapno.Mask = "000000";
            this.mskdhesapno.Name = "mskdhesapno";
            this.mskdhesapno.Size = new System.Drawing.Size(156, 43);
            this.mskdhesapno.TabIndex = 5;
            this.mskdhesapno.ValidatingType = typeof(int);
            this.mskdhesapno.TextChanged += new System.EventHandler(this.mskdhesapno_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(364, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 112);
            this.button1.TabIndex = 6;
            this.button1.Text = "İŞLEM GERÇEKLEŞTİR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(852, 541);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 69);
            this.button2.TabIndex = 7;
            this.button2.Text = "GERİ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtalicibakiye
            // 
            this.txtalicibakiye.Location = new System.Drawing.Point(291, 55);
            this.txtalicibakiye.Name = "txtalicibakiye";
            this.txtalicibakiye.Size = new System.Drawing.Size(100, 22);
            this.txtalicibakiye.TabIndex = 8;
            this.txtalicibakiye.Visible = false;
            // 
            // txtbankahesabi
            // 
            this.txtbankahesabi.Location = new System.Drawing.Point(440, 54);
            this.txtbankahesabi.Name = "txtbankahesabi";
            this.txtbankahesabi.Size = new System.Drawing.Size(100, 22);
            this.txtbankahesabi.TabIndex = 9;
            this.txtbankahesabi.Visible = false;
            // 
            // txtyuzde
            // 
            this.txtyuzde.Location = new System.Drawing.Point(582, 56);
            this.txtyuzde.Name = "txtyuzde";
            this.txtyuzde.Size = new System.Drawing.Size(100, 22);
            this.txtyuzde.TabIndex = 10;
            this.txtyuzde.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(29, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 35);
            this.label7.TabIndex = 12;
            this.label7.Text = "Müşteri Tipi";
            // 
            // mskdbakiye
            // 
            this.mskdbakiye.Enabled = false;
            this.mskdbakiye.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskdbakiye.Location = new System.Drawing.Point(186, 148);
            this.mskdbakiye.Name = "mskdbakiye";
            this.mskdbakiye.Size = new System.Drawing.Size(156, 43);
            this.mskdbakiye.TabIndex = 15;
            // 
            // mskdgonderilenmiktar
            // 
            this.mskdgonderilenmiktar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskdgonderilenmiktar.Location = new System.Drawing.Point(639, 151);
            this.mskdgonderilenmiktar.Name = "mskdgonderilenmiktar";
            this.mskdgonderilenmiktar.Size = new System.Drawing.Size(169, 43);
            this.mskdgonderilenmiktar.TabIndex = 16;
            // 
            // cmbmusteritip
            // 
            this.cmbmusteritip.Enabled = false;
            this.cmbmusteritip.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbmusteritip.FormattingEnabled = true;
            this.cmbmusteritip.Location = new System.Drawing.Point(186, 240);
            this.cmbmusteritip.Name = "cmbmusteritip";
            this.cmbmusteritip.Size = new System.Drawing.Size(156, 43);
            this.cmbmusteritip.TabIndex = 17;
            // 
            // havale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(981, 622);
            this.Controls.Add(this.txtyuzde);
            this.Controls.Add(this.txtbankahesabi);
            this.Controls.Add(this.txtalicibakiye);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "havale";
            this.Text = "havale";
            this.Load += new System.EventHandler(this.havale_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox mskdhesapno;
        private System.Windows.Forms.DateTimePicker datetarih;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskdalicihesapno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtalicibakiye;
        private System.Windows.Forms.TextBox txtbankahesabi;
        private System.Windows.Forms.TextBox txtyuzde;
        private System.Windows.Forms.TextBox mskdgonderilenmiktar;
        private System.Windows.Forms.TextBox mskdbakiye;
        private System.Windows.Forms.ComboBox cmbmusteritip;
    }
}