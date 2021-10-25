
namespace assignment9
{
    partial class ContributionFeeCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSport = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelMembershipDuration = new System.Windows.Forms.Label();
            this.buttonCalculateFee = new System.Windows.Forms.Button();
            this.labelFeeToBePaid = new System.Windows.Forms.Label();
            this.labelCalculatedFeeToBePaidOutput = new System.Windows.Forms.Label();
            this.radioButtonFootball = new System.Windows.Forms.RadioButton();
            this.radioButtonHandball = new System.Windows.Forms.RadioButton();
            this.textBoxAgeInput = new System.Windows.Forms.TextBox();
            this.textBoxMembershipDurationInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelSport
            // 
            this.labelSport.AutoSize = true;
            this.labelSport.Location = new System.Drawing.Point(13, 48);
            this.labelSport.Name = "labelSport";
            this.labelSport.Size = new System.Drawing.Size(35, 15);
            this.labelSport.TabIndex = 0;
            this.labelSport.Text = "Sport";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(13, 108);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(28, 15);
            this.labelAge.TabIndex = 1;
            this.labelAge.Text = "Age";
            // 
            // labelMembershipDuration
            // 
            this.labelMembershipDuration.AutoSize = true;
            this.labelMembershipDuration.Location = new System.Drawing.Point(12, 137);
            this.labelMembershipDuration.Name = "labelMembershipDuration";
            this.labelMembershipDuration.Size = new System.Drawing.Size(122, 15);
            this.labelMembershipDuration.TabIndex = 2;
            this.labelMembershipDuration.Text = "Membership duration";
            // 
            // buttonCalculateFee
            // 
            this.buttonCalculateFee.Location = new System.Drawing.Point(13, 167);
            this.buttonCalculateFee.Name = "buttonCalculateFee";
            this.buttonCalculateFee.Size = new System.Drawing.Size(258, 31);
            this.buttonCalculateFee.TabIndex = 3;
            this.buttonCalculateFee.Text = "Calculate Fee";
            this.buttonCalculateFee.UseVisualStyleBackColor = true;
            this.buttonCalculateFee.Click += new System.EventHandler(this.buttonCalculateFee_Click);
            // 
            // labelFeeToBePaid
            // 
            this.labelFeeToBePaid.AutoSize = true;
            this.labelFeeToBePaid.Location = new System.Drawing.Point(13, 220);
            this.labelFeeToBePaid.Name = "labelFeeToBePaid";
            this.labelFeeToBePaid.Size = new System.Drawing.Size(81, 15);
            this.labelFeeToBePaid.TabIndex = 4;
            this.labelFeeToBePaid.Text = "Fee to be paid";
            // 
            // labelCalculatedFeeToBePaidOutput
            // 
            this.labelCalculatedFeeToBePaidOutput.AutoSize = true;
            this.labelCalculatedFeeToBePaidOutput.Location = new System.Drawing.Point(171, 220);
            this.labelCalculatedFeeToBePaidOutput.Name = "labelCalculatedFeeToBePaidOutput";
            this.labelCalculatedFeeToBePaidOutput.Size = new System.Drawing.Size(43, 15);
            this.labelCalculatedFeeToBePaidOutput.TabIndex = 5;
            this.labelCalculatedFeeToBePaidOutput.Text = "€ 00.00";
            // 
            // radioButtonFootball
            // 
            this.radioButtonFootball.AutoSize = true;
            this.radioButtonFootball.Location = new System.Drawing.Point(171, 44);
            this.radioButtonFootball.Name = "radioButtonFootball";
            this.radioButtonFootball.Size = new System.Drawing.Size(68, 19);
            this.radioButtonFootball.TabIndex = 6;
            this.radioButtonFootball.TabStop = true;
            this.radioButtonFootball.Text = "Football";
            this.radioButtonFootball.UseVisualStyleBackColor = true;
            // 
            // radioButtonHandball
            // 
            this.radioButtonHandball.AutoSize = true;
            this.radioButtonHandball.Location = new System.Drawing.Point(171, 69);
            this.radioButtonHandball.Name = "radioButtonHandball";
            this.radioButtonHandball.Size = new System.Drawing.Size(73, 19);
            this.radioButtonHandball.TabIndex = 7;
            this.radioButtonHandball.TabStop = true;
            this.radioButtonHandball.Text = "Handball";
            this.radioButtonHandball.UseVisualStyleBackColor = true;
            // 
            // textBoxAgeInput
            // 
            this.textBoxAgeInput.Location = new System.Drawing.Point(171, 100);
            this.textBoxAgeInput.Name = "textBoxAgeInput";
            this.textBoxAgeInput.Size = new System.Drawing.Size(100, 23);
            this.textBoxAgeInput.TabIndex = 8;
            // 
            // textBoxMembershipDurationInput
            // 
            this.textBoxMembershipDurationInput.Location = new System.Drawing.Point(171, 129);
            this.textBoxMembershipDurationInput.Name = "textBoxMembershipDurationInput";
            this.textBoxMembershipDurationInput.Size = new System.Drawing.Size(100, 23);
            this.textBoxMembershipDurationInput.TabIndex = 9;
            // 
            // ContributionFeeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 244);
            this.Controls.Add(this.textBoxMembershipDurationInput);
            this.Controls.Add(this.textBoxAgeInput);
            this.Controls.Add(this.radioButtonHandball);
            this.Controls.Add(this.radioButtonFootball);
            this.Controls.Add(this.labelCalculatedFeeToBePaidOutput);
            this.Controls.Add(this.labelFeeToBePaid);
            this.Controls.Add(this.buttonCalculateFee);
            this.Controls.Add(this.labelMembershipDuration);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelSport);
            this.Name = "ContributionFeeCalculator";
            this.Text = "Selection assignment 9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSport;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelMembershipDuration;
        private System.Windows.Forms.Button buttonCalculateFee;
        private System.Windows.Forms.Label labelFeeToBePaid;
        private System.Windows.Forms.Label labelCalculatedFeeToBePaidOutput;
        private System.Windows.Forms.RadioButton radioButtonFootball;
        private System.Windows.Forms.RadioButton radioButtonHandball;
        private System.Windows.Forms.TextBox textBoxAgeInput;
        private System.Windows.Forms.TextBox textBoxMembershipDurationInput;
    }
}

