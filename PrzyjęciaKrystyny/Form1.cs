using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrzyjęciaKrystyny
{
    public partial class Form1 : Form
    {
        double cena = 0;
        double cenaDekoracji = 0;
        double cenaJedzenia = 0;
        double cenaCiasta = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void decoration_CheckedChanged(object sender, EventArgs e)
        {
            dekoracja();
        }

        private void dekoracja()
        {
            if (decoration.Checked == true)
            {
                cenaDekoracji = (double)ileOsob.Value * 15 + 50;
            }
            else
            {
                cenaDekoracji = (double)ileOsob.Value * 7.50 + 30;
            }
            cena = cenaDekoracji + cenaJedzenia;
            price.Text = cena + "zł";
        }

        private void foodOption_CheckedChanged(object sender, EventArgs e)
        {
            jedzenie();
        }

        private void jedzenie()
        {
            if (foodOption.Checked == true)
                cenaJedzenia = (double)ileOsob.Value * 5;

            else
                cenaJedzenia = (double)ileOsob.Value * 20;

            cena = cenaDekoracji + cenaJedzenia;
            if (foodOption.Checked == true)
                cena = cena * .95;
            price.Text = cena + "zł";
        }

        private void ileOsob_ValueChanged(object sender, EventArgs e)
        {
            jedzenie();
            dekoracja();
        }

        private void ileOsobBday_ValueChanged(object sender, EventArgs e)
        {
            dekoracjaBday();
            ciasto();
        }

        private void ciasto()
        {
            if (ileOsobBday.Value < 5)
            {
                cake.MaxLength = 16;
                cenaCiasta = 40 + .25 * cake.TextLength;
            }
            else
            {
                cake.MaxLength = 40;
                cenaCiasta = 75 + .25 * cake.TextLength;
            }
            cena = cenaCiasta + cenaDekoracji;
            priceBday.Text = cena + "zł";
        }

        private void decorationBday_CheckedChanged(object sender, EventArgs e)
        {
            dekoracjaBday();
        }

        private void dekoracjaBday()
        {
            if (decorationBday.Checked == true)
            {
                cenaDekoracji = (double)ileOsobBday.Value * 15 + 50;
            }
            else
            {
                cenaDekoracji = (double)ileOsobBday.Value * 7.50 + 30;
            }
            cena = cenaDekoracji + cenaCiasta;
            priceBday.Text = cena + "zł";
        }

        private void cake_TextChanged(object sender, EventArgs e)
        {
            ciasto();
        }
    }
}
