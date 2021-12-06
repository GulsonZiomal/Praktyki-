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
                    return false;
                for(int i = 0; i< jobsICanDo.Length; i++)
                    if(jobsICanDo[i] == job)
                    {
                        currentJob = job;
                        this.shiftsToWork = numberOfShifts;
                        shiftsWorked = 0;
                        return true;
                    }
                return false;
            }
            public bool DidYouFinish()
            {
                if (String.IsNullOrEmpty(currentJob))
                {
                    return false;
                }
                shiftsWorked++;
                if (shiftsWorked > shiftsToWork)
                {
                    shiftsWorked = 0;
                    shiftsToWork = 0;
                    currentJob = "";
                    return true;
                }
                else
                    return false;
            }
        }

        public class Queen
        {
            public Queen(Worker[] workers)
            {
                this.workers = workers;
            }
            private Worker[] workers;
            private int shiftNumber = 0;

            public bool AssignWork(string job, int numberOfShifts)
            {
                for (int i = 0; i < workers.Length; i++)
                    if (workers[i].DoThisJob(job, numberOfShifts))
                        return true;
                return false;
            }

            public string WorkTheNextshift()
            {
                shiftNumber++;
                string report = "Raport zmiany numer " + shiftNumber + "\r\n";
                for(int i = 0; i<workers.Length; i++)
                {
                    if(workers[i].DidYouFinish())
                        report += "Robotnica numer " + (i+1) + " zakończyła swoje zadanie \r\n";
                    if (string.IsNullOrEmpty(workers[i].CurrentJob))
                        report += "Robotnica numer " + (i + 1) + " nie pracuje\r\n";
                    else
                        if (workers[i].ShiftsLeft > 0)
                            report += "Robotnica numer " + (i + 1) + " robi " + workers[i].CurrentJob + " jeszcze przez " + workers[i].ShiftsLeft + " zmiany\r\n";
                        else
                            report += "Robotnica numer " + (i + 1) + " zakończy " + workers[i].CurrentJob + " po tej zmianie\r\n";
                }
                return report;
            }
        }

        private Queen queen;

        private void assignJob_Click(Object sender, EventArgs e)
        {
            if (queen.AssignWork(workerBeeJob.Text, (int)shifts.Value) == false)
                MessageBox.Show("Nie ma dostępnych robotnic do wykonania zadania " + workerBeeJob.Text + "'", "Królowa pszczół mówi...");
            else
                MessageBox.Show("Zadanie " + workerBeeJob.Text + " będzie ukończone za " + shifts.Value + " zmiany", "Królowa pszczół mówi.");
        }

        private void nextShift_Click(Object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextshift();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nextShift_Click_1(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextshift();
        }
    }
}
