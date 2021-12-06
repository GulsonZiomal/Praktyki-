using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal przejechane = koniec.Value - Start.Value;
            if (przejechane > 0)
            {
                float wartosc = (float)((float)przejechane * 0.39);
                label3.Text = "Kwota do zwrotu" + wartosc + "zł";
            }
            else
            {
                label3.Text = "Nie cofa się liczników to nie legalne!";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal przejechane = koniec.Value - Start.Value;
            MessageBox.Show(przejechane+" kilometrów");
        }
    }
}
