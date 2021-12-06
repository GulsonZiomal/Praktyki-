using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarNieChlujnyJanek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MenuMaker menu = new MenuMaker();
            label1.Text = menu.randomMenu();
            label2.Text = menu.randomMenu();
            label3.Text = menu.randomMenu();
            label4.Text = menu.randomMenu();
            label5.Text = menu.randomMenu();
            label6.Text = menu.randomMenu();
        }

        public class MenuMaker
        {
            Random Randomizer = new Random();
            string[] Meats = { "Wołowina", "Kurczak", "Salami", "Karkówka" };
            string[] Condiments = { "Musztarda", "Majonez", "Przyprawa", "Sos Francuski" };
            string[] Breads = { "Chleb Razowy", "Chleb Zbożowy", "Kajzerka", "Pumpernikiel" };
            public string randomMenu()
            {
                string randomMeat = Meats[Randomizer.Next(Meats.Length)];
                string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
                string randomBread = Breads[Randomizer.Next(Breads.Length)];
                return randomMeat + "," + randomCondiment + "," + randomBread;
            }
        }
    }
}
