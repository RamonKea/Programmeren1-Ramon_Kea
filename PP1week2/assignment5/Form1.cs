using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace assingment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculateAverage_Click(object sender, EventArgs e)
        {
            const double three = 3;

            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            // Read the numbers that the user puts in the textboxes
            string firstinput = textBoxNumber1Input.Text;
            double firstnumber = double.Parse(firstinput);

            string secondinput = textBoxNumber2Input.Text;
            double secondnumber = double.Parse(secondinput);

            string thirdinput = textBoxNumber3Input.Text;
            double thirdnumber = double.Parse(thirdinput);

            // calculate the average of the numbers and display it
            double average = (firstnumber + secondnumber + thirdnumber) / three;
            labelAverageOutput.Text = $"{average:0.000}";
        }
    }
}
