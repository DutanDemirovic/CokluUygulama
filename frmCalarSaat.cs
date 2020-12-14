using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CokluUygulama
{
    public partial class frmCalarSaat : Form
    {
        public frmCalarSaat()
        {
            InitializeComponent();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void frmCalarSaat_Load(object sender, EventArgs e)
        {
            timer1.Start();
            btnIptal.Enabled = false;
        }

        private void btnKur_Click(object sender, EventArgs e)
        {   
            Alarm();
            maskedTextBox1.Enabled = false;
            btnKur.Enabled = false;
            btnIptal.Enabled = true;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            btnKur.Enabled = true;
            btnIptal.Enabled = false;            
            maskedTextBox1.Enabled = true;
            ses.Stop();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        SoundPlayer ses = new SoundPlayer();
        void Alarm()
        {            
            if (maskedTextBox1.Text == label2.Text)
            {
                SoundPlayer ses = new SoundPlayer();
                ses.SoundLocation = "Contra.wav";
                ses.Play();
                MessageBox.Show("Alarm");
            }          
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Alarm();
        }
    }
}
