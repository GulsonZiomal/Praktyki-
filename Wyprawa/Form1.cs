using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wyprawa
{
    public partial class Form1 : Form
    {
        public int tury = 0;
        public int rundy = 1;
        public Form1()
        {
            InitializeComponent();
            bat.Location = new Point(200, 140);
            bat.Visible = true;
        }


        private void moveUp_Click(object sender, EventArgs e)
        {
            move(player.Location.X, player.Location.Y - 10);
        }

        private void moveDown_Click(object sender, EventArgs e)
        {

            move(player.Location.X, player.Location.Y + 10);
        }

        private void moveLeft_Click(object sender, EventArgs e)
        {
            move(player.Location.X - 10, player.Location.Y);
        }

        private void moveRight_Click(object sender, EventArgs e)
        {
            move(player.Location.X + 10, player.Location.Y);

        }

        private void attackRight_Click(object sender, EventArgs e)
        {

        }

        private void attackLeft_Click(object sender, EventArgs e)
        {

        }

        private void attackUp_Click(object sender, EventArgs e)
        {

        }

        private void attackDown_Click(object sender, EventArgs e)
        {

        }

        public void move(int x, int y)
        {
            int x1 = player.Location.X;
            int y1 = player.Location.Y;
            player.Location = new Point(x, y);
            if ((player.Location.X > 80 && player.Location.X < 620) && (player.Location.Y > 80 && player.Location.Y < 280))
            {
                enemyMove();
            }
            else
            {
                MessageBox.Show("Próbujesz wejść za daleko!");
                player.Location = new Point(x1, y1);
            }
        }

        private void enemyMove()
        {
            int x2 = bat.Location.X, y2 = bat.Location.Y;
            Random randomizer = new Random();
            int kierunek = randomizer.Next(4);
            do
            {
                if (kierunek == 1)
                {
                    if (bat.Location.X < 620)
                    {
                        x2 = bat.Location.X + 10;
                        y2 = bat.Location.Y;
                        bat.Location = new Point(x2, y2);
                    }
                    else kierunek++;
                }
                if (kierunek == 2)
                {
                    if (bat.Location.Y < 280)
                    {
                        x2 = bat.Location.X;
                        y2 = bat.Location.Y + 10;
                        bat.Location = new Point(x2, y2);
                    }
                    else kierunek++;
                }
                if (kierunek == 3)
                {
                    if (bat.Location.X > 80)
                    {
                        x2 = bat.Location.X - 10;
                        y2 = bat.Location.Y;
                        bat.Location = new Point(x2, y2);
                    }
                    else kierunek++;
                }
                if (kierunek == 4)
                {
                    if (bat.Location.Y > 80)
                    {
                        x2 = bat.Location.X;
                        y2 = bat.Location.Y - 10;
                        bat.Location = new Point(x2, y2);
                    }
                    else kierunek = 1;
                }
            } while (bat.Location.X != x2 || bat.Location.Y != y2);
        }
    }
}
