using System;
using System.Windows.Forms;

namespace assignment6
{
    public partial class ContentTableConverter : Form
    {
        // Define the lenght of the array
        const int ValueLength = 20;

        // Make an array with an int variable
        int[] value = new int[ValueLength];

        public ContentTableConverter()
        {
            InitializeComponent();
        }

        private void ContentTableConverter_Load(object sender, EventArgs e)
        {
            // Determine value
            int randomNumber = 0;
            Random random = new Random();

            // Fill Array with 20 random values between 0 and 500
            for (int i = 0; i < ValueLength; i++)
            {
                randomNumber = random.Next(0, 501);
                value[i] = randomNumber;
            }

            // Make a string format with the value array
            for (int i = 0; i < ValueLength; i++)
            {
                string textFormatLabel = string.Format($"Element {i.ToString("D2")} = {value[i]}\n");
                //print the 20 random values in the labels
                labelBeforeElementComparison.Text += textFormatLabel;
            }
        }

        private void buttonCompareValues_Click(object sender, EventArgs e)
        {
            // Make the label empty before entering the new values
            labelAfterElementComparison.Text = "";

            // Make a new array with the same length as the first one
            int[] newValue = new int[ValueLength];
            int comparisonNumber = int.Parse(textboxComparisonNumberInput.Text);
            string textFormatLabel = "";

            // Compare the numbers in the array with the number that is entered in the textbox and fill it in the new array
            for (int i = 0; i < ValueLength; i++)
            {
                if (value[i] >= comparisonNumber)
                {
                    newValue[i] = value[i] + 10;
                }
                else
                {
                    newValue[i] = value[i] - 5;
                }
            }

            // Make a string format with the newValue array
            for (int i = 0; i < ValueLength; i++)
            {
                textFormatLabel = string.Format($"Element {i.ToString("D2")} = {newValue[i]}\n");
                // Print the new values
                labelAfterElementComparison.Text += textFormatLabel;
            }
            // Make the button unclickable when its pressed once
             int count = 0;
             count++;

            if (count == 1)
            {
                buttonCompareValues.Enabled = false;
            }
        }
    }
}
