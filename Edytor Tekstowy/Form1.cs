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
        int p = 0;
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
                counter = 0;
                while ((file.ReadLine()) != null)
                {
                    counter++;
                }
                j = counter / 1000 + 1;
                line = new string[1000, j];
                counter = 0;
                progressBar1.Maximum = (int)j-1;
                progressBar1.Minimum = 0;
                progressBar1.Step = 1;
                foreach (string ln in System.IO.File.ReadLines(filePath))
                {
                    if(p == 0)
                        coWPliku.Text += ln + "\n";
                    line[counter, p] = ln;
                    counter++;
                    
                    if (counter == 999)
                    {
                        counter = 0;
                        p++;
                        comboBox1.Items.Add("Strona numer: " + (p + 1));
                        progressBar1.PerformStep();
                    }
                }
                progressBar1.Value=0;
                file.Close();
                
            }
        }

        
            private void saveButton_Click(object sender, EventArgs e)
            {
            using (StreamWriter writer = File.CreateText(filePath))
            {
                progressBar1.Maximum = (int)j - 1;
                progressBar1.Minimum = 0;
                progressBar1.Step = 1;
                for (int w = 0; w < j; w++)
                {
                    progressBar1.PerformStep();
                    for (int i = 0; i < 1000; i++)
                    {
                        writer.WriteLine(line[i, w]);
                    }
                }
                progressBar1.Value = 0;
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
            progressBar1.Maximum = (int)j - 1;
            progressBar1.Minimum = 0;
            progressBar1.Step = 1;
            if (radioButton2.Checked == false && radioButton1.Checked == true)
                {
                    znaleziono.Text = "Wyrażenia w linijce/kach: ";
                    for (int k = 0; k < j; k++)
                    {
                    progressBar1.PerformStep();
                    znaleziono.Text += "\n";
                        for (int i = 0; i < 1000; i++)
                        {
                            if (line[i, k].IndexOf(textBox1.Text, 0, line[i, k].Length) != -1)
                            {
                                int x = i + 1;
                                znaleziono.Text += " linijka: " + x + " podstrona " + (k+1)+",";

                            }
                        }
                    }
                progressBar1.Value = 0;
            }
                else
                {
                    coWPliku.Text = "";
                    for (int k = 0; k < j;)
                    {
                    progressBar1.PerformStep();
                    for (int i = 0; i < counter; i++)
                        {
                            var replacement = line[i, k].Replace(textBox1.Text, textBox2.Text);
                            line[i, k] = replacement;
                            coWPliku.Text += (replacement) + "\n";
                        }
                    }
                progressBar1.Value = 0;
            }
            }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            coWPliku.Text = "";
            int s = comboBox1.SelectedIndex;
            progressBar1.Maximum = 999;
            progressBar1.Minimum = 0;
            progressBar1.Step = 1;
            for (int i = 0; i < 1000; i++)
            {
                coWPliku.Text += line[i, s]+"\n";
                progressBar1.PerformStep();
            }
            progressBar1.Value = 0;
        }
    }
}
