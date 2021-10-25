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

namespace assignment9
{
    public partial class ContributionFeeCalculator : Form
    {
        public ContributionFeeCalculator()
        {
            InitializeComponent();
        }

        private void buttonCalculateFee_Click(object sender, EventArgs e)
        {
            const int FootballMembershipFee = 175;
            const int HandballMembershipFee = 225;
            const int AgeDiscount = 25;
            const int MembershipDiscount = 20;

            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            // Ask for the age and membership duration of the user and turn the input in to variables
            string ageInput = textBoxAgeInput.Text;
            int age = int.Parse(ageInput);
            string membershipDurationInput = textBoxMembershipDurationInput.Text;
            int membershipDuration = int.Parse(membershipDurationInput);

            // Calculate the discount amount and Display the calculated total membership fee
            if (radioButtonFootball.Checked&& age > 40)
            {
                int totalMembershipFee = FootballMembershipFee - AgeDiscount;
                labelCalculatedFeeToBePaidOutput.Text = $"{totalMembershipFee:€ 0.00}";
            }
            else if (radioButtonFootball.Checked&& membershipDuration > 10)
            {
                int totalMembershipFee = FootballMembershipFee - MembershipDiscount;
                labelCalculatedFeeToBePaidOutput.Text = $"{totalMembershipFee:€ 0.00}";
            }
            else if (radioButtonHandball.Checked&& age > 40)
            {
                int totalMembershipFee = HandballMembershipFee - AgeDiscount;
                labelCalculatedFeeToBePaidOutput.Text = $"{totalMembershipFee:€ 0.00}";
            }
            else if (radioButtonHandball.Checked&& membershipDuration > 10)
            {
                int totalMembershipFee = HandballMembershipFee - MembershipDiscount;
                labelCalculatedFeeToBePaidOutput.Text = $"{totalMembershipFee:€ 0.00}";
            }
            else if (radioButtonFootball.Checked)
            {
                int totalMembershipFee = FootballMembershipFee;
                labelCalculatedFeeToBePaidOutput.Text = $"{totalMembershipFee:€ 0.00}";
            }
            else if (radioButtonHandball.Checked)
            {
                int totalMembershipFee = HandballMembershipFee;
                labelCalculatedFeeToBePaidOutput.Text = $"{totalMembershipFee:€ 0.00}";
            }
        }
    }
}
