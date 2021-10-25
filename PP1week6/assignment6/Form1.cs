using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment6
{
    public partial class SquareByThreeMethodsCalculator : Form
    {
        public SquareByThreeMethodsCalculator()
        {
            InitializeComponent();
        }

        private void buttonSquareByReference_Click(object sender, EventArgs e)
        {
            // Assign the value of the textbox to an int variable.
            int number = int.Parse(textBoxNumberInput.Text);

            // Display the Square By Reference
            SquareByReference(ref number);
            labelResultOutput.Text = number.ToString();
        }

        private void buttonSquareByReferenceOut_Click(object sender, EventArgs e)
        {
            // Assign the value of the textbox to an int variable.
            int number = int.Parse(textBoxNumberInput.Text);

            // Display the Square By Reference Out
            SquareByReferenceOut(number, out int square);
            labelResultOutput.Text = $"{square}";
        }

        private void buttonSquareByValue_Click(object sender, EventArgs e)
        {
            // Assign the value of the textbox to an int variable.
            int number = int.Parse(textBoxNumberInput.Text);

            // Display the Square By Value
            SquareByValue(number);
            labelResultOutput.Text = SquareByValue(number).ToString();
        }

        // Three methods for calculating squares
        void SquareByReference(ref int number)
        {
            number = number * number;
        }

        void SquareByReferenceOut(int number, out int square)
        {
            square = number * number;
        }

        int SquareByValue(int number)
        {
            return number * number;
        }
    }
}
