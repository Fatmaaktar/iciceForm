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
    public partial class random : Form
    {
        public random()
        {
            InitializeComponent();
        }
        int tahmin = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Random sayi = new Random();
            tahmin = sayi.Next(1, 21);
            timer1.Enabled = true;
        }

        int rastgele = 0;
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           //rastgele = Convert.ToInt32(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rastgele = Convert.ToInt32(textBox1.Text);
            if (tahmin == rastgele)
            {
                label4.Text = ("Sayı doğru tahmin edildi");
                timer1.Enabled = false;
            }
            else if (tahmin > rastgele)
            {
                label4.Text = ("Sayı daha büyük");
            }
            else if (tahmin < rastgele)
            {
                label4.Text=("Sayı daha küçüktür");
            }
        }
        int sure = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sure++;
            label2.Text = Convert.ToString(sure);
            if (sure <= 10)
            {
                label6.Text = "100";
            }
            else if(sure>10 && sure <= 20)
            {
                label6.Text = "90";
            }
            else if (sure > 20 && sure <= 30)
            {
                label6.Text = "80";
            }
            else if (sure > 30 && sure <= 40)
            {
                label6.Text = "70";
            }
            else if (sure > 40 && sure <= 50)
            {
                label6.Text = "60";
            }
            else if (sure > 50 && sure <= 60)
            {
                label6.Text = "50";
            }
            else if (sure > 60 && sure <= 70)
            {
                label6.Text = "40";
            }
            else if (sure > 70 && sure <= 80)
            {
                label6.Text = "30";
            }
            else if (sure > 80 && sure <= 90)
            {
                label6.Text = "20";
            }
            else if (sure > 90 && sure <= 100)
            {
                label6.Text = "10";
            }
            else if (sure > 100)
            {
                label6.Text = "0";
            }
        }

        private void random_Load(object sender, EventArgs e)
        {

        }
    }
}
