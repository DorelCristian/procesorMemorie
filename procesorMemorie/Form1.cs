using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace procesorMemorie
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void metroProgressBar2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float vcpu = pCPU.NextValue();
            float vram = pRAM.NextValue();
            metroProgressBar1.Value = (int) vcpu;
            metroProgressBar2.Value = (int) vram;
            lblcpu.Text = string.Format("{0:0.00}%", vcpu);
            lblram.Text = string.Format("{0:0.00}%", vram);
            chart1.Series["CPU"].Points.AddY(vcpu);
            chart1.Series["RAM"].Points.AddY(vram);
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
