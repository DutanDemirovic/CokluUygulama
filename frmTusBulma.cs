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
    public partial class frmTusBulma : Form
    {
        public frmTusBulma()
        {
            InitializeComponent();
        }

        private void frmTusBulma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                label1.Text = "Enter";
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                label1.Text = "Escape";
            }
            else if (e.KeyChar == (char)Keys.Space)
            {
                label1.Text = "Space";
            }            
            else
            {                
                label1.Text = e.KeyChar.ToString();
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

        private void frmTusBulma_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up || e.KeyCode == Keys.Right || e.KeyCode == Keys.Left)
            {
                label1.Text = e.KeyCode.ToString();
            }
        }

        private void frmTusBulma_Load(object sender, EventArgs e)
        {

        }
    }
}
