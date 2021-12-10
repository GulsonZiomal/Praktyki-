using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wyprawa
{
    internal static class Program
    {
        public static int rundy = 1;
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            switch (rundy)
            {
                case 1:
                    new Level1();

                    rundy++;
                    break;
                case 2:

                    rundy++;
                    break;
                case 3:

                    rundy++;
                    break;
                case 4:

                    rundy++;
                    break;
                default:
                    break;
            }
        }
    }
}
