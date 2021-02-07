using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirKelimeBirIslem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        KelimeRandom klm1 = new KelimeRandom();
        KelimeElleGir klm2 = new KelimeElleGir();
        IslemRandom isl1 = new IslemRandom();
        IslemEllecs isl2 = new IslemEllecs();
        private void btnKelimeRandom_Click(object sender, EventArgs e)
        {
            klm1.Show();
        }

        private void btnKelimeEllegir_Click(object sender, EventArgs e)
        {
            klm2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSayiRandom_Click(object sender, EventArgs e)
        {
            isl1.Show();
        }

        private void btnSayiEllegir_Click(object sender, EventArgs e)
        {
            isl2.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
