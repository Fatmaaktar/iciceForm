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
    public partial class alan_cevre : Form
    {
        public alan_cevre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                int uzunKenar, kisaKenar,alan,cevre;
                uzunKenar = Convert.ToInt32(textBox1.Text);
                kisaKenar = Convert.ToInt32(textBox2.Text);

                alan = uzunKenar * kisaKenar;
                cevre = 2 * (uzunKenar + kisaKenar);

                label11.Text = cevre.ToString();
                label13.Text = alan.ToString();
            }
            if (radioButton2.Checked == true)
            {
                int kenar1, kenar2, taban, yukseklik,alan,cevre;
                kenar1 = Convert.ToInt32(textBox4.Text);
                kenar2 = Convert.ToInt32(textBox3.Text);
                taban = Convert.ToInt32(textBox5.Text);
                yukseklik = Convert.ToInt32(textBox6.Text);

                cevre = kenar1 + kenar2 + taban;
                alan = (taban * yukseklik) / 2;

                label11.Text = cevre.ToString();
                label13.Text = alan.ToString();
            }
            if (radioButton3.Checked == true)
            {
                int yaricap, pisayisi,alan,cevre;
                yaricap = Convert.ToInt32(textBox8.Text);
                pisayisi = Convert.ToInt32(textBox7.Text);

                cevre = 2 * pisayisi * yaricap;
                alan = pisayisi *( yaricap * yaricap);

                label11.Text = cevre.ToString();
                label13.Text = alan.ToString();
            }
        }

        private void alan_cevre_Load(object sender, EventArgs e)
        {

        }
    }
}
