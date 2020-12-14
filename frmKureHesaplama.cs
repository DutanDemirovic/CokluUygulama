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
    public partial class frmKureHesaplama : Form
    {
        public frmKureHesaplama()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        void Hesapla()
        {
            int r,hacim, alan;            
            
            r = int.Parse(txtYariCap.Text);
            alan = Convert.ToInt32(4 * Math.PI * Math.Pow(r, 2));
            hacim = Convert.ToInt32((4 * Math.PI * Math.Pow(r, 3)) / 3);

            lblAlanSonuc.Text = alan.ToString();
            lblHacimSonuc.Text = hacim.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void txtYariCap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Hesapla();
            }
        }
    }
}
