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

namespace assignment_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            const double vat = 0.21;

            // Ask the user how many kilometers where counted, at the start and the end.
            string firstinput = textBoxInputStartKm.Text;
            double startkm = double.Parse(firstinput);

            string secondinput = textBoxInputEndKm.Text;
            double endkm = double.Parse(secondinput);

            // Ask the user what the price per km is
            string thirdinput = textBoxInputPriceKm.Text;
            double priceKm = double.Parse(thirdinput);

            // Calculate the Price excluding VAT, including VAT and the VAT amount
            double priceexcludingvat = (endkm - startkm) * priceKm;
            double vatamount = priceexcludingvat * vat;
            double priceincludingvat = priceexcludingvat + vatamount;

            // Display the Price excluding VAT, including VAT and the VAT amount in the labels
            labelOuputPriceExclusiveVAT.Text = $"{priceexcludingvat:0.00}";
            labelOutputVAT.Text = $"{vatamount:0.00}";
            labelOutputInclusiveVAT.Text = $"{priceincludingvat:0.00}";
        }

        private void buttonErase_Click(object sender, EventArgs e)
        {
            // Erease all the inputs and outputs
            string firsinput = "";
            string secondinput = "";
            string thirdinput = "";
            labelOuputPriceExclusiveVAT.Text = $"0.00";
            labelOutputVAT.Text = $"0.00";
            labelOutputInclusiveVAT.Text = $"0.00";
        }
    }
}
