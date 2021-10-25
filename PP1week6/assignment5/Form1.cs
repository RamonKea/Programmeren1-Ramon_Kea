using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment5
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            // Assign textbox number 1 and 2 to int variables.
            int numberOne = int.Parse(textBoxNumberOneInput.Text);
            int numberTwo = int.Parse(textBoxNumberTwoInput.Text);

            double result = CalculatorPlus(numberOne, numberTwo);

            // Display the result of the calculation
            labelResultOutput.Text = $"{result}";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            // Asign textbox number 1 and 2 to int variables.
            int numberOne = int.Parse(textBoxNumberOneInput.Text);
            int numberTwo = int.Parse(textBoxNumberTwoInput.Text);

            int result = CalculatorMinus(numberOne, numberTwo);

            // Display the result of the calculation
            labelResultOutput.Text = $"{result}";
        }

        private void buttonTimes_Click(object sender, EventArgs e)
        {
            // Asign textbox number 1 and 2 to int variables.
            int numberOne = int.Parse(textBoxNumberOneInput.Text);
            int numberTwo = int.Parse(textBoxNumberTwoInput.Text);

            int result = CalculatorTimes(numberOne, numberTwo);

            // Display the result of the calculation
            labelResultOutput.Text = $"{result}";
        }

        private void buttonDivider_Click(object sender, EventArgs e)
        {
            // Asign textbox number 1 and 2 to int variables.
            int numberOne = int.Parse(textBoxNumberOneInput.Text);
            int numberTwo = int.Parse(textBoxNumberTwoInput.Text);

            double result = CalculatorDivider(numberOne, numberTwo);

            // Display the result of the calculation
            labelResultOutput.Text = $"{result:0.###}";
        }

        // Method for plus calculation
        static int CalculatorPlus(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }

        // Method for minus calculation
        static int CalculatorMinus(int numberOne, int numberTwo)
        {
            return numberOne - numberTwo;
        }

        // Method for times calculation
        static int CalculatorTimes(int numberOne, int numberTwo)
        {
            return numberOne * numberTwo;
        }

        // Method for divider calculation
        static double CalculatorDivider(int numberOne, int numberTwo)
        {
            return Convert.ToDouble(numberOne) / Convert.ToDouble(numberTwo);
        }
    }
}
