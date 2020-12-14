using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CokluUygulama
{
    public partial class frmFaktoriyel : Form
    {
        public frmFaktoriyel()
        {
            InitializeComponent();
        }
        void Hesapla()
        {
            int sayi = Int32.Parse(txtSayi.Text);

            int faktorıyel = 1;

            for (int i = 1; i < sayi; i++)
            {
                faktorıyel += faktorıyel * i;
            }

            label3.Text = faktorıyel.ToString();
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void txtSayi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Hesapla();
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
