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
    public partial class Benim : Form
    {
        public Benim()
        {
            InitializeComponent();
        }
        int sayac = 300;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Benim_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            panel2.Enabled = false;
            panel3.Enabled = false;
            panel4.Enabled = false;
            panel5.Enabled = false;
        }
        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            label11.Text = sayac.ToString();
            if (sayac == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("Süreniz Dolmuştur");
                panel1.Enabled = false;
                panel2.Enabled = false;
                panel3.Enabled = false;
                panel4.Enabled = false;
                panel5.Enabled = false;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            panel1.Enabled = true;
            panel2.Enabled = true;
            panel3.Enabled = true;
            panel4.Enabled = true;
            panel5.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            panel2.Enabled = false;
            panel3.Enabled = false;
            panel4.Enabled = false;
            panel5.Enabled = false;

            timer1.Enabled = false;

            int dogru = 0;
            int basari = 0;
            if (radioButton2.Checked)
            {
                dogru = dogru + 1;
            }
            if (radioButton7.Checked)
            {
                dogru = dogru + 1;
            }
            if (radioButton9.Checked)
            {
                dogru = dogru + 1;
            }
            if (radioButton16.Checked)
            {
                dogru = dogru + 1;
            }
            if (radioButton17.Checked)
            {
                dogru = dogru + 1;
            }
            basari = dogru * 20;
            textBox1.Text = basari.ToString();
            
        }
    }
}
