﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void changeText_Click(object sender, EventArgs e)
        {
            if(enableCheckbox.Checked == true)
            {
                if(labelToChange.Text == "z prawej")
                {
                    labelToChange.Text = "z lewej";
                    labelToChange.TextAlign = ContentAlignment.MiddleLeft;
                }
                else
                {
                    labelToChange.Text = "z prawej";
                    labelToChange.TextAlign = ContentAlignment.MiddleRight;
                }
            }
            else
            {
                labelToChange.Text = "Możliwość zmiany tekstu jest wyłączona!!!";
                labelToChange.TextAlign = ContentAlignment.MiddleCenter;
            }
        }
    }
}
