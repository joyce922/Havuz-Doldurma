using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        double uzunluk, genişlik, derinlik, mus1, mus2, toplam, hacim, zaman;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uzunluk = double.Parse(textBox1.Text);
            derinlik = double.Parse(textBox2.Text);
            genişlik = double.Parse(textBox3.Text);
            
            if (uzunluk > 0 && derinlik > 0 && genişlik > 0)
            {
                hacim = uzunluk * derinlik * genişlik;
                textBox6.Text = hacim.ToString();
                errorProvider3.SetError(textBox1, "");
                errorProvider4.SetError(textBox2, "");
                errorProvider5.SetError(textBox3, "");
            }

            else if (uzunluk <=0)
            {
                errorProvider3.SetError(textBox1, "Değeri 0'dan büyük olarak tekrar giriniz.");
            }

            else if (derinlik <=0)
            {
                errorProvider4.SetError(textBox2, "Değeri 0'dan büyük olarak tekrar giriniz.");
            }

            else 
            {
                errorProvider5.SetError(textBox3, "Değeri 0'dan büyük olarak tekrar giriniz.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mus1 = double.Parse(textBox4.Text);
            mus2 = double.Parse(textBox5.Text);
           
            if (mus1 >= 0 && mus2 >= 0)
            {
                toplam = mus1 + mus2;
                textBox8.Text = toplam.ToString();
                zaman = hacim / toplam;
                textBox7.Text = zaman.ToString();

                errorProvider1.SetError(textBox4, "");
                errorProvider2.SetError(textBox5, "");
            
            }

            else if (mus1 <0)
            {
                errorProvider1.SetError(textBox4, "Değeri 0 veya 0'dan büyük olarak tekrar giriniz");
            }

            else
            {
                errorProvider2.SetError(textBox5, "Değerleri 0 veya 0'dan büyük olarak tekrar giriniz");
            }
        }
    }
}
