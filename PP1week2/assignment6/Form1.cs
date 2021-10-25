using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assingment6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonToCalculateTime_Click(object sender, EventArgs e)
        {
            string input = textBoxInputTimeInSeconds.Text;
            int totalseconds = int.Parse(input);

            // Calculate how many hours can be substracted from the number of seconds
            int hours = totalseconds / 3600;
            int remainingseconds = totalseconds % 3600;

            // Calculate how many minutes can be substracted from the number of seconds
            int minutes = remainingseconds / 60;
            int seconds = remainingseconds % 60;

            // Display the number of hours, minutes and seconds
            labelOutputOfTime.Text = $"{hours:00}:{minutes:00}:{seconds:00}";
        }
    }
}
