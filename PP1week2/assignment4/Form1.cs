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

namespace assingment4
{
    public partial class Formvatcalculator : Form
    {
        public Formvatcalculator()
        {
            InitializeComponent();
        }

        private void buttondeterminevat_Click(object sender, EventArgs e)
        {
            const double vat = 0.21;

            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            // Read the price of the product without VAT.
            // ("Enter a price: ");
            string input = textBoxprice.Text;

            // Convert string to double (data type conversion)
            double price = double.Parse(input);

            // Calculate the VAT (21%) on this price in euro's.
            double vatprice = price * vat;

            // Calculate the price + VAT.
            double pricewithvat = price + vatprice;

            // Display the price, the VAT and VAT + price
            labelPriceOutput.Text = $"{price:0.00}";
            labelVATInput.Text = $"{vatprice:0.00}";
            labelTotalInput.Text = $"{pricewithvat:0.00}";

        }
    }
}
