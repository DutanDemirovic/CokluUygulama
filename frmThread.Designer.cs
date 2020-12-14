namespace CokluUygulama
{
    partial class frmThread
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
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.btnDevam = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbLSayi1 = new System.Windows.Forms.Label();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.lbLSayi2 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSonuc = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDakika = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelSaniye = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioToplama = new System.Windows.Forms.RadioButton();
            this.radioCikarma = new System.Windows.Forms.RadioButton();
            this.radioCarpma = new System.Windows.Forms.RadioButton();
            this.radioBolme = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBaslat
            // 
            this.btnBaslat.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaslat.Location = new System.Drawing.Point(202, 29);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(109, 56);
            this.btnBaslat.TabIndex = 0;
            this.btnBaslat.Text = "Thread Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnDurdur
            // 
            this.btnDurdur.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDurdur.Location = new System.Drawing.Point(317, 29);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(109, 56);
            this.btnDurdur.TabIndex = 1;
            this.btnDurdur.Text = "Thread Durdur";
            this.btnDurdur.UseVisualStyleBackColor = true;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // btnDevam
            // 
            this.btnDevam.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDevam.Location = new System.Drawing.Point(202, 91);
            this.btnDevam.Name = "btnDevam";
            this.btnDevam.Size = new System.Drawing.Size(109, 56);
            this.btnDevam.TabIndex = 2;
            this.btnDevam.Text = "Thread Devam Et";
            this.btnDevam.UseVisualStyleBackColor = true;
            this.btnDevam.Click += new System.EventHandler(this.btnDevam_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(317, 95);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(109, 56);
            this.btnGeri.TabIndex = 4;
            this.btnGeri.Text = "Geri Dön";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(258, 157);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(109, 56);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBolme);
            this.groupBox1.Controls.Add(this.radioCarpma);
            this.groupBox1.Controls.Add(this.radioCikarma);
            this.groupBox1.Controls.Add(this.radioToplama);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.progressBar2);
            this.groupBox1.Controls.Add(this.labelSaniye);
            this.groupBox1.Controls.Add(this.labelDakika);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.labelSonuc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnHesapla);
            this.groupBox1.Controls.Add(this.txtSayi2);
            this.groupBox1.Controls.Add(this.lbLSayi2);
            this.groupBox1.Controls.Add(this.txtSayi1);
            this.groupBox1.Controls.Add(this.lbLSayi1);
            this.groupBox1.Controls.Add(this.btnCikis);
            this.groupBox1.Controls.Add(this.btnBaslat);
            this.groupBox1.Controls.Add(this.btnGeri);
            this.groupBox1.Controls.Add(this.btnDurdur);
            this.groupBox1.Controls.Add(this.btnDevam);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 354);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thread Uygulaması";
            // 
            // lbLSayi1
            // 
            this.lbLSayi1.AutoSize = true;
            this.lbLSayi1.Location = new System.Drawing.Point(19, 37);
            this.lbLSayi1.Name = "lbLSayi1";
            this.lbLSayi1.Size = new System.Drawing.Size(69, 18);
            this.lbLSayi1.TabIndex = 6;
            this.lbLSayi1.Text = "Sayı 1 :";
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(96, 29);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(100, 26);
            this.txtSayi1.TabIndex = 7;
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(96, 67);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(100, 26);
            this.txtSayi2.TabIndex = 9;
            // 
            // lbLSayi2
            // 
            this.lbLSayi2.AutoSize = true;
            this.lbLSayi2.Location = new System.Drawing.Point(19, 75);
            this.lbLSayi2.Name = "lbLSayi2";
            this.lbLSayi2.Size = new System.Drawing.Size(71, 18);
            this.lbLSayi2.TabIndex = 8;
            this.lbLSayi2.Text = "Sayı 2 :";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(22, 229);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 27);
            this.btnHesapla.TabIndex = 10;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sonuç :";
            // 
            // labelSonuc
            // 
            this.labelSonuc.AutoSize = true;
            this.labelSonuc.Location = new System.Drawing.Point(216, 238);
            this.labelSonuc.Name = "labelSonuc";
            this.labelSonuc.Size = new System.Drawing.Size(19, 18);
            this.labelSonuc.TabIndex = 12;
            this.labelSonuc.Text = "0";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(142, 280);
            this.progressBar1.Maximum = 60;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(169, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Geçen Süre :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelDakika
            // 
            this.labelDakika.AutoSize = true;
            this.labelDakika.Location = new System.Drawing.Point(390, 285);
            this.labelDakika.Name = "labelDakika";
            this.labelDakika.Size = new System.Drawing.Size(19, 18);
            this.labelDakika.TabIndex = 15;
            this.labelDakika.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelSaniye
            // 
            this.labelSaniye.AutoSize = true;
            this.labelSaniye.Location = new System.Drawing.Point(390, 314);
            this.labelSaniye.Name = "labelSaniye";
            this.labelSaniye.Size = new System.Drawing.Size(19, 18);
            this.labelSaniye.TabIndex = 16;
            this.labelSaniye.Text = "0";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(142, 309);
            this.progressBar2.Maximum = 60;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(169, 23);
            this.progressBar2.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "dakika :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "saniye :";
            // 
            // radioToplama
            // 
            this.radioToplama.AutoSize = true;
            this.radioToplama.Location = new System.Drawing.Point(22, 112);
            this.radioToplama.Name = "radioToplama";
            this.radioToplama.Size = new System.Drawing.Size(103, 22);
            this.radioToplama.TabIndex = 20;
            this.radioToplama.TabStop = true;
            this.radioToplama.Text = "Toplama";
            this.radioToplama.UseVisualStyleBackColor = true;
            // 
            // radioCikarma
            // 
            this.radioCikarma.AutoSize = true;
            this.radioCikarma.Location = new System.Drawing.Point(22, 140);
            this.radioCikarma.Name = "radioCikarma";
            this.radioCikarma.Size = new System.Drawing.Size(99, 22);
            this.radioCikarma.TabIndex = 21;
            this.radioCikarma.TabStop = true;
            this.radioCikarma.Text = "Çıkarma";
            this.radioCikarma.UseVisualStyleBackColor = true;
            // 
            // radioCarpma
            // 
            this.radioCarpma.AutoSize = true;
            this.radioCarpma.Location = new System.Drawing.Point(22, 168);
            this.radioCarpma.Name = "radioCarpma";
            this.radioCarpma.Size = new System.Drawing.Size(94, 22);
            this.radioCarpma.TabIndex = 22;
            this.radioCarpma.TabStop = true;
            this.radioCarpma.Text = "Çarpma";
            this.radioCarpma.UseVisualStyleBackColor = true;
            // 
            // radioBolme
            // 
            this.radioBolme.AutoSize = true;
            this.radioBolme.Location = new System.Drawing.Point(22, 196);
            this.radioBolme.Name = "radioBolme";
            this.radioBolme.Size = new System.Drawing.Size(79, 22);
            this.radioBolme.TabIndex = 23;
            this.radioBolme.TabStop = true;
            this.radioBolme.Text = "Bölme";
            this.radioBolme.UseVisualStyleBackColor = true;
            // 
            // frmThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 374);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmThread";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThread";
            this.Load += new System.EventHandler(this.frmThread_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Button btnDevam;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelSonuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.Label lbLSayi2;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.Label lbLSayi1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelDakika;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelSaniye;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.RadioButton radioBolme;
        private System.Windows.Forms.RadioButton radioCarpma;
        private System.Windows.Forms.RadioButton radioCikarma;
        private System.Windows.Forms.RadioButton radioToplama;
    }
}