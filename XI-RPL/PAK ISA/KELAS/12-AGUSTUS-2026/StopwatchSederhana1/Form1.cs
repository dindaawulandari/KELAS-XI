using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopwatchSederhana1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int detik = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            detik++;

            int jam = detik / 3600;
            int menit = detik / 60;
            int detikSisa = detik % 60;

            lblWaktu.Text = $"{jam:00}:{menit:00}:{detikSisa:00}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            detik = 0;
            lblWaktu.Text = "00 : 00";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void lblWaktu_Click(object sender, EventArgs e)
        {

        }
    }
}
