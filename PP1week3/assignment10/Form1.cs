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

namespace assignment10
{
    public partial class CinemaTicketCalculator : Form
    {
        public CinemaTicketCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const int BasicPrice = 12;

            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            // Ask the user for the age in years
            string ageInput = textBoxAgeInput.Text;
            int age = int.Parse(ageInput);

            // Calculate the price for the given age and change the price of the output label
            if (age < 5 | age >= 55)
            {
                int ticketPrice = BasicPrice - 12;
                labelCalculatedPriceTicketOutput.Text = $"{ticketPrice:€ 0.00}";
            }
            else if (age > 5 && age < 12)
            {
                int ticketPrice = BasicPrice - 6;
                labelCalculatedPriceTicketOutput.Text = $"{ticketPrice:€ 0.00}";
            }
            else if (age > 13 && age < 54)
            {
                labelCalculatedPriceTicketOutput.Text = $"{BasicPrice:€ 0.00}";
            }
        }
    }
}
