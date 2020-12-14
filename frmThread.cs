using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CokluUygulama
{
    public partial class frmThread : Form
    {
        public frmThread()
        {
            InitializeComponent();
        }
        void Dongu()
        {
            decimal i;
            for (i = 0; i < 500000000; i++)
            {

            }
            MessageBox.Show("İşlem Bitti");
            timer1.Stop();
        }
        Thread kanal;
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            kanal = new Thread(Dongu);
            kanal.Start();
            timer1.Start();
        }

        [Obsolete]
        private void btnDurdur_Click(object sender, EventArgs e)
        {
            kanal.Suspend();
            timer1.Stop();
        }

        [Obsolete]
        private void btnDevam_Click(object sender, EventArgs e)
        {
            kanal.Resume();
            timer1.Start();
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            kanal.Abort();
            timer1.Stop();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Int32.Parse(txtSayi1.Text);
            b = Int32.Parse(txtSayi2.Text);

            if (radioToplama.Checked)
            {
                labelSonuc.Text = (a + b).ToString();
                txtSayi1.Clear();
                txtSayi2.Clear();
            }
            if (radioCikarma.Checked)
            {
                labelSonuc.Text = (a - b).ToString();
                txtSayi1.Clear();
                txtSayi2.Clear();
            }
            if (radioCarpma.Checked)
            {
                labelSonuc.Text = (a * b).ToString();
                txtSayi1.Clear();
                txtSayi2.Clear();
            }
            if (radioBolme.Checked)
            {
                labelSonuc.Text = (a / b).ToString();
                txtSayi1.Clear();
                txtSayi2.Clear();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int saniye=0, dakika=0;

        private void frmThread_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            if (saniye == 60)
            {
                dakika++;
                saniye = 0;
            }
            labelDakika.Text = dakika.ToString();
            labelSaniye.Text = saniye.ToString();
            progressBar1.Value = dakika;
            progressBar2.Value = saniye;
        }
    }
}
