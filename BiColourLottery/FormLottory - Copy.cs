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

            Thread.Sleep(1000);

            foreach (var control in this.groupBox1.Controls)
            {
                if (control is Label)
                {
                    Label label = (Label)control;

                    Task.Run(() =>
                    {
                        if (label.Name.Contains("Blue")) // blue numbers
                        {
                            try
                            {
                                while (true)
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
                                throw;
                            }
                        }
                        else if (label.Name.Contains("Red")) // red numbers
                        {
                            try
                            {
                                while (true)
                                {
                                    int index = new RandomHelper().GetRandomNumberDelay(0, 33);
                                    string redNumber = this.RedNums[index];

                                    this.Invoke(new Action(() =>
                                    {
                                        label.Text = redNumber;
                                    }));
                                }
                            }
                            catch (Exception ex)
                            {
                                throw;
                            }
                        }
                    });
                }
            }
        }
    }
}
