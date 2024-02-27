using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool isTimerRunning = false;
        const double k = 0.01;
        Random rnd = new Random();
        double euro, usa;
        double dt = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                dt = 0;
                timer1.Stop();
            }
            else
            {
                euro = (double)InputEuro.Value;
                usa = (double)InputUSA.Value;


                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();

                chart1.Series[0].Points.AddXY(0, euro);
                chart1.Series[1].Points.AddXY(0, usa);



                timer1.Start();

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dt += 1;

            euro = euro * (1 + k * (rnd.NextDouble() - 0.5));
            chart1.Series[0].Points.AddXY(dt, euro);

            usa = usa * (1 + k * (rnd.NextDouble() - 0.5));
            chart1.Series[1].Points.AddXY(dt, usa);
            if (dt > 10)
                timer1.Stop();
        }
    }
}
