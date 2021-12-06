using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        public class Worker
        {
            public Worker(string[] jobsICanDo)
            {
                this.jobsICanDo = jobsICanDo;
            }
            public int ShiftsLeft
            {
                get
                {
                    return shiftsToWork - shiftsWorked;
                }
            }
            private string currentJob = "";
            public string CurrentJob
            {
                get
                {
                    return currentJob;
                }
            }
            private string[] jobsICanDo;
            private int shiftsToWork;
            private int shiftsWorked;

            public bool DoThisJob(string job, int numberOfShifts)
            {
                if (!String.IsNullOrEmpty(currentJob))
                {
                    return false;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
