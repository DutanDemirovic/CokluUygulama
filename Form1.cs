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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmFaktoriyel form1 = new frmFaktoriyel();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmKureHesaplama form2 = new frmKureHesaplama();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCalarSaat form3 = new frmCalarSaat();
            form3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmTusBulma form4 = new frmTusBulma();
            form4.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThread_Click(object sender, EventArgs e)
        {
            frmThread form5 = new frmThread();
            form5.Show();
        }
    }
}
