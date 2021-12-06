using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Wyścigi_Konne
{
    public partial class Form1 : Form
    {
        Random randomizer = new Random();
        int janekMoney = 50, bartekMoney = 45, arekMoney = 55;
        int wygrany = 0;
        int wybranejanek, wybranebartek, wybranearek;
        int postawionejanek, postawionebartek, postawionearek;
        public Form1()
        {
            InitializeComponent();
        }

        private void START_Click(object sender, EventArgs e)
        {
            gameStart();
        }

        private void gameStart()
        {
            int X1;
            int X2;
            int X3;
            int X4;
            startButton.Enabled = false;
            while ((dog1.Location.X < 360 && dog2.Location.X < 360) && (dog3.Location.X < 360 && dog4.Location.X < 360))
            {
                X1 = dog1.Location.X + randomizer.Next(1, 10);
                X2 = dog2.Location.X + randomizer.Next(1, 10);
                X3 = dog3.Location.X + randomizer.Next(1, 10);
                X4 = dog4.Location.X + randomizer.Next(1, 10);
                dog1.Location = new Point(X1, dog1.Location.Y);
                dog2.Location = new Point(X2, dog2.Location.Y);
                dog3.Location = new Point(X3, dog3.Location.Y);
                dog4.Location = new Point(X4, dog4.Location.Y);
                if (dog1.Location.X >= 350)
                {
                    wygrany = 1;
                }
                else
                {
                    if (dog2.Location.X >= 350)
                    {
                        wygrany = 2;
                    }
                    else
                    {
                        if (dog3.Location.X >= 350)
                        {
                            wygrany = 3;
                        }
                        else
                        {
                            if (dog4.Location.X >= 350)
                            {
                                wygrany = 4;
                            }
                        }
                    }
                }
                Thread.Sleep(100);
            }
            MessageBox.Show("Wygrał pies nr: " + wygrany);
            dog1.Location = new Point(21, 22);
            dog2.Location = new Point(21, 51);
            dog3.Location = new Point(21, 97);
            dog4.Location = new Point(21, 142);

            if (wybranejanek == wygrany)
            {
                janekMoney = janekMoney + (postawionejanek * 2);
                    janekRadio.Text = "Janek: " + janekMoney + "zł";
            }
            if (wybranebartek == wygrany)
            {
                bartekMoney = bartekMoney + (postawionebartek * 2);
                bartekRadio.Text = "Bartek: " + bartekMoney + "zł";
            }
            if (wybranearek == wygrany)
            {
                arekMoney = arekMoney + (postawionearek * 2);
                arekRadio.Text = "Arek: " + arekMoney + "zł";
            }
            janekBet.Text = "Janek stawia: 0zł";
            bartekBet.Text = "Batrek stawia: 0zł";
            arekBet.Text = "Arek stawia: 0zł";
            postawionejanek = 0;
            postawionebartek = 0;
            postawionearek = 0;
            if (janekMoney == 0)
            {
                janekRadio.Text = "Bankrut";
                janekRadio.Enabled = false;
            }
            if (bartekMoney == 0)
            {
                bartekRadio.Text = "Bankrut";
                bartekRadio.Enabled = false;
            }
            if (arekMoney == 0)
            {
                arekRadio.Text = "Bankrut";
                arekRadio.Enabled = false;
            }
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            int wybrane = int.Parse(nrCharta.Text);
            if (janekRadio.Checked == true)
            {
                wybranejanek = wybrane;
                if ((int)stawka.Value > janekMoney)
                {
                    MessageBox.Show("Janek nie ma tyle pieniędzy!");
                }
                else
                {
                    postawionejanek += (int)stawka.Value;
                    janekMoney = janekMoney - (int)stawka.Value;
                    janekRadio.Text = "Janek: " + janekMoney + "zł";
                    janekBet.Text = "Janek stawia: " + postawionejanek + "zł";
                }
            }
            if (bartekRadio.Checked == true)
            {
                wybranebartek = wybrane;
                if ((int)stawka.Value > bartekMoney)
                {
                    MessageBox.Show("bartek nie ma tyle pieniędzy!");
                }
                else
                {
                    postawionebartek += int.Parse(stawka.Text);
                    bartekMoney = bartekMoney - int.Parse(stawka.Text);
                    bartekRadio.Text = "Bartek: " + bartekMoney + "zł";
                    bartekBet.Text = "Bartek stawia: " + postawionebartek + "zł";
                }
            }
            if (arekRadio.Checked == true)
            {
                wybranearek = wybrane;
                if ((int)stawka.Value > arekMoney)
                {
                    MessageBox.Show("Arek nie ma tyle pieniędzy!");
                }
                else
                {
                    postawionearek += int.Parse(stawka.Text);
                    arekMoney = arekMoney - int.Parse(stawka.Text);
                    arekRadio.Text = "Arek: " + arekMoney + "zł";
                    arekBet.Text = "Arek stawia: " + postawionearek + "zl";
                }
            }
        }
    }
}