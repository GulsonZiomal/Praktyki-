using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edytor_Tekstowy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string filePath = string.Empty;
        int counter = 0;
        string[] line = new string[1000];

        private void button1_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.InitialDirectory = "c:\\";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;

                var fileStream = ofd.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }
            }
            var name = filePath.Split('.');
            if (name[1] == "txt")
            {
                using (StreamReader file = new StreamReader(ofd.FileName))
                {
                    coWPliku.Text = "";
                    string ln;

                    while ((ln = file.ReadLine()) != null && counter < 1000)
                    {
                        line[counter] = ln;
                        coWPliku.Text += line[counter] + "\n";
                        counter++;
                    }
                    file.Close();
                    label1.Text += counter;
                }
            }
            else MessageBox.Show("Możesz dodać tylko plik txt");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = File.CreateText(filePath))
            {
                writer.WriteLine(coWPliku.Text);
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (label3.Visible == false)
            {
                label3.Visible = true;
                textBox2.Visible = true;
            }
            else
            {
                textBox2.Visible = false;
                label3.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == false && radioButton1.Checked == true)
            {
                znaleziono.Text = "Wyrażenia w linijce/kach: ";
                for (int i = 0; i < counter; i++)
                {
                    if (line[i].IndexOf(textBox1.Text, 0, line[i].Length) != -1)
                    {
                        int j = i + 1;
                        znaleziono.Text += " " + j;
                    }
                }
            }
            else
            {
                coWPliku.Text = "";
                for (int i = 0; i < counter; i++)
                {
                    var replacement = line[i].Replace(textBox1.Text, textBox2.Text);
                    line[i] = replacement;
                    coWPliku.Text += (replacement) + "\n";
                }
            }
        }
    }
}
