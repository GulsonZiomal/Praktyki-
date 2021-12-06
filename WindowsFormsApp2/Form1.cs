using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
                for (int i = 0; i < 255; i++)
                {
                System.Threading.Thread.Sleep(3);
                for (int j = 0; j < 255; j++)
                    {
                    System.Threading.Thread.Sleep(3);
                    for (int k = 0; k < 255; k++)
                        {
                            this.BackColor = Color.FromArgb(i, j, k);
                            System.Threading.Thread.Sleep(3);
                        }
                    }
                }
        }
    }
}
