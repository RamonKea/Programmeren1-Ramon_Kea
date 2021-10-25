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
    public partial class DiceThrowValueCounter : Form
    {
        public DiceThrowValueCounter()
        {
            InitializeComponent();
        }

        private void buttonThrow_Click(object sender, EventArgs e)
        {
            int[] diceThrows = new int[6];

            Random random = new Random();

            // Throw the dice 6000x 
            for (int i = 0; i < 6000; i++)
            {
                int diceThrow = random.Next(0, 6);
                diceThrows[diceThrow]++;
            }
            // Display the result
            labelValueOne.Text = $"Number of throws of value 1 = {diceThrows[0]}";
            labelValueTwo.Text = $"Number of throws of value 2 = {diceThrows[1]}";
            labelValueThree.Text = $"Number of throws of value 3 = {diceThrows[2]}";
            labelValueFour.Text = $"Number of throws of value 4 = {diceThrows[3]}";
            labelValueFive.Text = $"Number of throws of value 5 = {diceThrows[4]}";
            labelValueSix.Text = $"Number of throws of value 6 = {diceThrows[5]}";
        }
    }
}
