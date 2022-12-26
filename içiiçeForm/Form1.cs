using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace içiiçeForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kronometre krm = new kronometre();
            krm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            random tahmin = new random();
            tahmin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labirent lbr = new labirent();
            lbr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Benim at = new Benim();
            at.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tasKagıtMakas tkm = new tasKagıtMakas();
            tkm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            alan_cevre yt = new alan_cevre();
            yt.Show();
        }
    }
}
