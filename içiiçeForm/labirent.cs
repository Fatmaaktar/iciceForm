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
    public partial class labirent : Form
    {
        public labirent()
        {
            InitializeComponent();
        }

        private void label18_MouseEnter(object sender, EventArgs e)
        {
            label1.Enabled = false;
            label2.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            label6.Enabled = false;
            label7.Enabled = false;
            label8.Enabled = false;
            label9.Enabled = false;
            label10.Enabled =false;
            label11.Enabled =false;
            label12.Enabled =false;
            label13.Enabled = false;
            label14.Enabled = false;
            label15.Enabled = false;
            label16.Enabled = false;
            label17.Enabled = false;
            label18.Enabled = false;
            label19.Enabled = false;

            MessageBox.Show("Duvara Çarptınız!");

        }


        private void label19_Click(object sender, EventArgs e)
        {
            if (label19.Enabled== true)
            {
                MessageBox.Show("Tebrikler kazandınız.");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void labirent_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Enabled = true;
            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            label11.Enabled = true;
            label12.Enabled = true;
            label13.Enabled = true;
            label14.Enabled = true;
            label15.Enabled = true;
            label16.Enabled = true;
            label17.Enabled = true;
            label18.Enabled = true;
            label19.Enabled = true;

        }
    }
}
