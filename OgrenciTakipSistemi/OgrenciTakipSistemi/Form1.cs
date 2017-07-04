using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciTakipSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YonetimForm yon = new YonetimForm();
            yon.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OgretmenForm ogt = new OgretmenForm();
            ogt.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OgrenciForm ogr = new OgrenciForm();
            ogr.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }

        private void yönetimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            groupBox1.Visible = true;
        }

        private void öğretmenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
        }
    }
}
