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

namespace assingment_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            const double tshirtprice = 30;
            const double jeansprice = 100;
            const double vat = 0.21;

            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            // Ask for the amount of jeans and T-shirts
            string firstinput = textBoxNumberOfTshirtsInput.Text;
            double tshirts = double.Parse(firstinput);

            string secondinput = textBoxNumberOfJeansInput.Text;
            double jeans = double.Parse(secondinput);

            // Add the price of the amount off jeans and T-shirts up to eachother
            double totaltshirtprice = tshirts * tshirtprice;
            double totaljeansprice = jeans * jeansprice;
            double totalprice = totaljeansprice + totaltshirtprice;
            double vatprice = totalprice * vat;
            double totalpricewithvat = totalprice + vatprice;

            // Display label outputs with the outcomes
            labelDateOutput.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
            labelPriceOutput.Text = $"{totalprice:€ 0.00}";
            labelVATOutput.Text = $"{vatprice:€ 0.00}";
            labelTotalpriceWithVATOutput.Text = $"{totalpricewithvat:€ 0.00}";

        }
    }
}
