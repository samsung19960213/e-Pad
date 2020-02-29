using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace epad
{
    public partial class Form3 : Form
    {
        private int Second;
        private bool TimerExpired;


        public Form3()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //Second = Second + 1;
            //if (Second >= 10)
            //{
            //    SplashTimer.Stop(); // Timer stops functioning
            //    HideSplash();
            //}
            Console.Out.WriteLine("timer clicked");
            SplashTimer.Stop();
            this.Hide();
            Form1 mainform = new Form1();
            mainform.Show();

        }

        private void Form3_Load(object sender, EventArgs e)

        {
            ShowForm3();

        }

        public void ShowForm3()

        {
            // The minimum amount of time the splash screen
            // will be visible.
            SplashTimer.Enabled = true;
            SplashTimer.Interval = 2000;
            SplashTimer.Start();




        }

        public void ReadyToWork()
        {
        }
        private void HideSplash()
        {

            Form1 f1 = new Form1();
            f1.Enabled = true;
            f1.Show();


            this.Hide();
        }
    }
}
