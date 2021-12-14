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
        static int j;
        string[,] line;

        public void button1_Click(object sender, EventArgs e)
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
            using (StreamReader file = new StreamReader(ofd.FileName))
            {
                coWPliku.Text = "";
                string ln;
                counter = 0;
                while ((file.ReadLine()) != null)
                {
                    counter++;
                }
                j = counter / 1000 + 1;
                Console.WriteLine(counter / 1000 + 1);
                Console.WriteLine(counter);
                Console.WriteLine(j);
                line = new string[1000, j];
                j = 0;
                counter = 0;
                
                while ((ln = file.ReadLine()) != null)
                {
                    line[counter, j] = ln;
                    if (j == 0)
                    {
                        coWPliku.Text += ln + "\n";
                    }
                    counter++;
                    if (counter == 1000)
                    {
                        counter = 0;
                        j++;
                        comboBox1.Items.Add("Strona numer: " + (j + 1));
                        Console.WriteLine(j);
                    }
                    Console.WriteLine(counter);               
                }
                file.Close();
            }
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
                    for (int k = 0; k < j; k++)
                    {
                        for (int i = 0; i < counter; i++)
                        {
                            if (line[i, k].IndexOf(textBox1.Text, 0, line[i, j].Length) != -1)
                            {
                                int x = i + 1;
                                znaleziono.Text += " " + x + " podstrona " + k;
                            }
                        }
                    }
                }
                else
                {
                    coWPliku.Text = "";
                    for (int k = 0; k < j;)
                    {
                        for (int i = 0; i < counter; i++)
                        {
                            var replacement = line[i, k].Replace(textBox1.Text, textBox2.Text);
                            line[i, k] = replacement;
                            coWPliku.Text += (replacement) + "\n";
                        }
                    }
                }
            }
    }
}
