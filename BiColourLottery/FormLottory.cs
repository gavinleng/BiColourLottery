using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BiColourLottery.common;

namespace BiColourLottery
{
    public partial class FormLottory : Form
    {
        private static readonly object obj_lock = new object();

        private bool IsGoOn = true;

        private List<Task> taskList = new List<Task>();

        private string[] RedNums = 
        { 
            "01", "02", "03", "04", "05", "06", "07", "08", "09", "10",
            "11", "12", "13", "14", "15", "16", "17", "18", "19", "20",
            "21", "22", "23", "24", "25", "26", "27", "28", "29", "30",
            "31", "32", "33"
        };

        private string[] BlueNums =
        {
            "01", "02", "03", "04", "05", "06", "07", "08", "09", "10",
            "11", "12", "13", "14", "15", "16"
        };

        public FormLottory()
        {
            InitializeComponent();
            this.btnStart.Enabled = true;
            this.btnStop.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.taskList = new List<Task>();

            this.IsGoOn = true;

            this.btnStart.Text = "Running";
            this.btnStart.Enabled = false;
            this.btnStop.Enabled = true;
            this.labelRed1.Text = "00";
            this.labelRed2.Text = "00";
            this.labelRed3.Text = "00";
            this.labelRed4.Text = "00";
            this.labelRed5.Text = "00";
            this.labelRed6.Text = "00";
            this.labelBlue.Text = "00";

            Thread.Sleep(500);

            foreach (var control in this.groupBox1.Controls)
            {
                if (control is Label)
                {
                    Label label = (Label)control;

                    taskList.Add(Task.Run(() =>
                    {
                        if (label.Name.Contains("Blue")) // blue numbers
                        {
                            try
                            {
                                while (IsGoOn)
                                {
                                    int index = new RandomHelper().GetRandomNumberDelay(0, 16);
                                    string blueNumber = this.BlueNums[index];

                                    this.Invoke(new Action(() =>
                                    {
                                        label.Text = blueNumber;
                                    }));
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        else if (label.Name.Contains("Red")) // red numbers
                        {
                            try
                            {
                                while (IsGoOn)
                                {
                                    int index = new RandomHelper().GetRandomNumberDelay(0, 33);
                                    string redNumber = this.RedNums[index];

                                    lock(obj_lock)
                                    {
                                        List<string> userNumbers = this.GetUserNumbers();

                                        if (!userNumbers.Contains(redNumber))
                                        {
                                            this.Invoke(new Action(() =>
                                            {
                                                label.Text = redNumber;
                                            }));

                                        }

                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                    }));
                }
            }

            Task.Factory.ContinueWhenAll(taskList.ToArray(), t =>
            {
                this.Invoke(new Action(() =>
                {
                    this.btnStart.Enabled = true;
                    this.btnStop.Enabled = false;
                }));

                this.ShowResult();
            });

        }

        // get red numbers
        private List<string> GetUserNumbers()
        {
            List<string> userNumberList = new List<string>();

            foreach (var control in this.groupBox1.Controls)
            {
                if (control is Label)
                {
                    Label label = (Label)control;

                    if (label.Name.Contains("Red"))
                    {
                        userNumberList.Add(label.Text);
                    }
                }
            }

            if (userNumberList.Distinct().Count() < 6)
            {
                Console.WriteLine("*************************");

                foreach (var no in userNumberList)
                {
                    Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}--{no}");
                }
            }

            return userNumberList;
        }

        private void ShowResult()
        {
            MessageBox.Show(string.Format("The Result is Red {0} {1} {2} {3} {4} {5} and Blue {6}"
                , this.labelRed1.Text
                , this.labelRed2.Text
                , this.labelRed3.Text
                , this.labelRed4.Text
                , this.labelRed5.Text
                , this.labelRed6.Text
                , this.labelBlue.Text));
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.IsGoOn = false;

            //Task.Run(() =>
            //{
            //    Task.WaitAll(taskList.ToArray());
            //    ShowResult();
            //});
        }
    }
}
