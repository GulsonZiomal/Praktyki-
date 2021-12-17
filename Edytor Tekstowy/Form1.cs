using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Edytor_Tekstowy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Tekst> tekst = new List<Tekst>();

        string filePath = string.Empty;
        static int counter;
        int strony;
        public void button1_Click(object sender, EventArgs e)
        {
            open_file();
        }

        public void saveButton_Click(object sender, EventArgs e)
        {
            save_file();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            mode_change();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            coWPliku.Text = "";
            if(radioButton1.Checked == true)
                search();
            else
                replace();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            coWPliku.Text = "";
            new_tekst();
        }

        
        public bool open_file()
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
                    int Strona = 1;
                    string ln;
                    while ((ln = reader.ReadLine()) != null)
                    {
                        counter++;
                        if (counter < 1000)
                        {
                            coWPliku.Text += ln + "\n";
                        }
                        tekst.Add(new Tekst() { linia = ln });
                        if (counter % 1000 == 0)
                        {
                            Strona++;
                            comboBox1.Items.Add("Strona numer: " + Strona);
                        }
                    }
                    counter = 0;
                    return true;
                }
            }
            return false;
        }
        public bool save_file()
        {
            using (StreamWriter writer = File.CreateText(filePath))
            {
                for (int i = 0; i < tekst.Count; i++)
                {
                    writer.WriteLine(tekst[i].linia);
                }
                return true;
            }
            return false;
        }
        public bool mode_change()
        {
            if (radioButton2.Checked == true)
            {
                label3.Visible = true;
                textBox2.Visible = true;
                return true;
            }
            else
            {
                label3.Visible = false;
                textBox2.Visible = false;
                return true;
            }
        }

        public bool search()
        {
            int j = 0;
            int linijka;
            for (int i = 0; i < tekst.Count; i++)
            {
                if (tekst[i].linia.IndexOf(textBox1.Text, 0, tekst[i].linia.Length) != -1)
                {
                    if (i > 999)
                        j = i / 1000;
                    linijka = i - (j * 1000) + 1;
                    znaleziono.Text += "linijka: " + (linijka) + " strona nr: " + (j + 1) + "\n";
                }
            }
            return true;
        }
        public bool replace()
        {
            for (int i = 0; i < tekst.Count; i++)
            {
                var replacement = tekst[i].linia.Replace(textBox1.Text, textBox2.Text);
                tekst[i].linia = replacement;
                if (i < 1000)
                    coWPliku.Text += (replacement) + "\n";
            }
            return true;
        }
        public bool new_tekst()
        {
            strony = comboBox1.SelectedIndex*1000;
            //strony = 0;
            //odkomentowa tylko do testów i zakomentowa pierwszą linie tej funkcji
            for (int i = 1; i <= 1000; i++)
            {
                int index = strony + i;
                if (tekst.Count > index)
                {
                    coWPliku.Text += tekst[index].linia + "\n";
                }
            }
            return true;
        }
    }
}
