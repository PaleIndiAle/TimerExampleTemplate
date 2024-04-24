using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace TimerExample
{
    public partial class Form1 : Form
    {
        int counter = 0;
        Stopwatch myWatch = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if(countTimer.Enabled == false)
            {
                myWatch.Start();
                countTimer.Enabled = true; //countTimer.Start();
                startButton.Text = "Pause";
            }
            else if (countTimer.Enabled == true)
            {
                myWatch.Stop();
                timeOutput.Text = myWatch.Elapsed.ToString(@"ss\:ff");
                countTimer.Enabled = false;
                startButton.Text = "Start";
            }
        }

        private void countTimer_Tick(object sender, EventArgs e)
        {
            counter++;
            counterLabel.Text = $"{counter}";

            if (counter % 3 == 0)
            {
                if (colourLabel.BackColor == Color.White)
                {
                    colourLabel.BackColor = Color.DodgerBlue;
                }
                else if (colourLabel.BackColor == Color.DodgerBlue)
                {
                    colourLabel.BackColor = Color.White;
                }
            }
        }
    }
}
