using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment7
{
    public partial class TemperatureConverter : Form
    {
        public TemperatureConverter()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // Assign the input to the variables according to which radiobutton is checked and display the correct conversion
            if (radioButtonCelsiusToKelvin.Checked) // First radiobutton
            {
                double c = double.Parse(textBoxDegreesInput.Text);
                labelConvertedDegreesOutput.Text = Celsius2Kelvin(c).ToString("0.00");
            }
            else if (radioButtonCelsiusToFahrenheit.Checked) // Second radiobutton
            {
                double c = double.Parse(textBoxDegreesInput.Text);
                labelConvertedDegreesOutput.Text = Celsius2Fahrenheit(c).ToString("0.00");
            }
            else if (radioButtonFahrenheitToCelsius.Checked) // Third radiobutton
            {
                double f = double.Parse(textBoxDegreesInput.Text);
                labelConvertedDegreesOutput.Text = Fahrenheit2Celsius(f).ToString("0.00");
            }
        }

        // Methods with the calculations of the conversions
        static double Celsius2Kelvin(double c)
        {
            return (c + 273);
        }

        static double Celsius2Fahrenheit(double c)
        {
            return (c * 9/5 + 32);
        }

        static double Fahrenheit2Celsius(double f)
        {
            return ((f - 32) * 5/9);
        }
    }
}