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
    public partial class tasKagıtMakas : Form
    {
        public tasKagıtMakas()
        {
            InitializeComponent();
        }

        int PuanBilgisayar = 0, PuanOyuncu = 0;
        int sayac=0;
        private void tasKagıtMakas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] dizi = { "tas", "kagıt", "makas"};
            Random random = new Random();
            int sayi = random.Next(0, 3);
            string Bilgisayar = dizi[sayi];
            label2.Text = Bilgisayar;
            if (PuanOyuncu==3 || PuanBilgisayar==3)
            {
                sayac++;
                if (PuanOyuncu > PuanBilgisayar)
                {
                    label5.Text = sayac + ", Bu turda kazanan oyuncu";
                }
                else if (PuanBilgisayar > PuanOyuncu)
                {
                    label5.Text = sayac + ". Bu turda kazanan bilgisayar";
                }
               else if (PuanBilgisayar == PuanOyuncu)
                {
                    label5.Text = sayac + ". Turda berabere kaldı";
                }

                PuanBilgisayar = 0;
                PuanOyuncu = 0;
            }
            if ((radioButton1.Checked==true)&&(Bilgisayar=="tas"))
            {
                PuanBilgisayar++;
                PuanOyuncu++;
                label4.Text = "Bilgisayar" + PuanBilgisayar + "+oyuncu" + PuanOyuncu;
            }
            else if ((radioButton1.Checked == true) && (Bilgisayar == "kagıt"))
            {
                PuanBilgisayar++;
                label4.Text = "Bilgisayar" + PuanBilgisayar + "+oyuncu" + PuanOyuncu;
            }
            else if ((radioButton1.Checked == true) && (Bilgisayar == "makas"))
            {
                PuanOyuncu++;
                label4.Text = "Bilgisayar" + PuanBilgisayar + "+oyuncu" + PuanOyuncu;
            }
            else if ((radioButton1.Checked == true) && (Bilgisayar == "tas"))
            {
                PuanOyuncu++;
                label4.Text = "Bilgisayar" + PuanBilgisayar + "+oyuncu" + PuanOyuncu;
            }
            else if ((radioButton2.Checked == true) && (Bilgisayar == "kagıt"))
            {
                PuanOyuncu++;
                PuanBilgisayar++;
                label4.Text = "Bilgisayar" + PuanBilgisayar + "+oyuncu" + PuanOyuncu;
            }
            else if ((radioButton2.Checked == true) && (Bilgisayar == "makas"))
            {
                PuanBilgisayar++;
                label4.Text = "Bilgisayar" + PuanBilgisayar + "+oyuncu" + PuanOyuncu;
            }
            else if ((radioButton1.Checked == true) && (Bilgisayar == "tas"))
            {
                PuanBilgisayar++;
                label4.Text = "Bilgisayar" + PuanBilgisayar + "+oyuncu" + PuanOyuncu;
            }
            else if ((radioButton3.Checked == true) && (Bilgisayar == "kagıt"))
            {
                PuanBilgisayar++;
                label4.Text = "Bilgisayar" + PuanBilgisayar + "+oyuncu" + PuanOyuncu;
            }
             else if ((radioButton3.Checked == true) && (Bilgisayar == "kagıt"))
            {
                PuanOyuncu++;
                label4.Text = "Bilgisayar" + PuanBilgisayar + "+oyuncu" + PuanOyuncu;
            }
            else if ((radioButton3.Checked == true) && (Bilgisayar == "makas"))
            {
                PuanOyuncu++;
                PuanBilgisayar++;
                label4.Text = "Bilgisayar" + PuanBilgisayar + "+oyuncu" + PuanOyuncu;
            }
        }
    }
}
