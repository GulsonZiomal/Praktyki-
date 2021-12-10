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
            if (player.Location.Y < 60){
                MessageBox.Show("Nie możesz tak daleko wyjść!");
            }
            else {
                player.Location = new Point(player.Location.X, player.Location.Y - 10);
                tury++;
            }
        }

        private void moveDown_Click(object sender, EventArgs e)
        {
            if (player.Location.Y > 270)
            {
                MessageBox.Show("Nie możesz tak daleko wyjść!");
            }
            else
            {
                player.Location = new Point(player.Location.X, player.Location.Y + 10);
                tury++;
            }
        }

        private void moveLeft_Click(object sender, EventArgs e)
        {
            if (player.Location.X < 80)
            {
                MessageBox.Show("Nie możesz tak daleko wyjść!");
            }
            else
            {
                player.Location = new Point(player.Location.X - 10, player.Location.Y);
                tury++;
            }
        }

        private void moveRight_Click(object sender, EventArgs e)
        {
            if (player.Location.X > 620)
            {
                MessageBox.Show("Nie możesz tak daleko wyjść!");
            }
            else
            {
                player.Location = new Point(player.Location.X + 10, player.Location.Y);
                tury++;
            }
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
    }
}
