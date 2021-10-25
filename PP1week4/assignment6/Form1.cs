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

namespace assignment6
{
    public partial class Capitalcalculator : Form
    {
        public Capitalcalculator()
        {
            InitializeComponent();
        }

        private void labelCalculateFinalCapital_Click(object sender, EventArgs e)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("nl");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            // Making the Growth factor a constant, calculated by doing (1.05)^5
            const double InterestRateGrowthFactor = 1.2762815625;

            string startAmountInput = textBoxStartAmountInput.Text;
            double startAmount = double.Parse(startAmountInput);

            // Calculation off the finacapital using the growth factor
            double finalCapital = startAmount * InterestRateGrowthFactor;
            labelFinalCapitalOutput.Text = $"{finalCapital:€0.00}";
        }
    }
}
