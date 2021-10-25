using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment8
{
    public partial class FomulaResultComperor : Form
    {
        public FomulaResultComperor()
        {
            InitializeComponent();
        }

        private void buttonCompare_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBoxEnterNumberInput.Text);
            labelComparisonOutput.Text = "";
            int i = 0;
            int sumOne = 0;
            int sumTwo = 0;
            int counter = 0;

            for (i = 0; i < number; ++i)
            {
                counter++;
                sumOne += counter;
            }

            sumTwo = number * (number + 1) / 2;

            labelSumOneOutput.Text = $"{sumOne:0}";
            labelSumTwoOutput.Text = $"{sumTwo:0}";

            // State whether or not these sums are equal to each other.
            if (sumOne == sumTwo)
            {
                labelComparisonOutput.Text = "The sum and formula are equal.";
            }
            else
            {
                labelComparisonOutput.Text = "The sum and formula are not equal.";
            }
        }
    }
}
