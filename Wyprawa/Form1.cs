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
        }


        private void moveUp_Click(object sender, EventArgs e)
        {
            move(player.Location.X, player.Location.Y - 10, 1);
        }

        private void moveDown_Click(object sender, EventArgs e)
        {

            move(player.Location.X, player.Location.Y + 10, 2);
        }

        private void moveLeft_Click(object sender, EventArgs e)
        {
            move(player.Location.X - 10, player.Location.Y, 3);
        }

        private void moveRight_Click(object sender, EventArgs e)
        {
            move(player.Location.X + 10, player.Location.Y, 4);

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

        public void move(int x, int y, int z)
        {
            int x1 = player.Location.X;
            int y1 = player.Location.Y;
            player.Location = new Point(x, y);
            if ((player.Location.X < 60 && player.Location.X > 270) && (player.Location.Y < 80 && player.Location.Y > 620))
            {
                tury++;
            }
            else
            {
                MessageBox.Show("Próbujesz wejść za daleko!");
                player.Location = new Point(x1, y1);
            }
        }
    }
}
