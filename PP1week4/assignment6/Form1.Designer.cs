
namespace assignment6
{
    partial class Capitalcalculator
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
            this.labelStartAmount = new System.Windows.Forms.Label();
            this.labelFinalCapital = new System.Windows.Forms.Label();
            this.labelFinalCapitalOutput = new System.Windows.Forms.Label();
            this.textBoxStartAmountInput = new System.Windows.Forms.TextBox();
            this.labelCalculateFinalCapital = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelStartAmount
            // 
            this.labelStartAmount.AutoSize = true;
            this.labelStartAmount.Location = new System.Drawing.Point(12, 28);
            this.labelStartAmount.Name = "labelStartAmount";
            this.labelStartAmount.Size = new System.Drawing.Size(76, 15);
            this.labelStartAmount.TabIndex = 0;
            this.labelStartAmount.Text = "Start amount";
            // 
            // labelFinalCapital
            // 
            this.labelFinalCapital.AutoSize = true;
            this.labelFinalCapital.Location = new System.Drawing.Point(12, 112);
            this.labelFinalCapital.Name = "labelFinalCapital";
            this.labelFinalCapital.Size = new System.Drawing.Size(70, 15);
            this.labelFinalCapital.TabIndex = 1;
            this.labelFinalCapital.Text = "Final capital";
            // 
            // labelFinalCapitalOutput
            // 
            this.labelFinalCapitalOutput.AutoSize = true;
            this.labelFinalCapitalOutput.Location = new System.Drawing.Point(199, 112);
            this.labelFinalCapitalOutput.Name = "labelFinalCapitalOutput";
            this.labelFinalCapitalOutput.Size = new System.Drawing.Size(40, 15);
            this.labelFinalCapitalOutput.TabIndex = 2;
            this.labelFinalCapitalOutput.Text = "€00,00";
            // 
            // textBoxStartAmountInput
            // 
            this.textBoxStartAmountInput.Location = new System.Drawing.Point(139, 20);
            this.textBoxStartAmountInput.Name = "textBoxStartAmountInput";
            this.textBoxStartAmountInput.Size = new System.Drawing.Size(100, 23);
            this.textBoxStartAmountInput.TabIndex = 3;
            // 
            // labelCalculateFinalCapital
            // 
            this.labelCalculateFinalCapital.Location = new System.Drawing.Point(12, 59);
            this.labelCalculateFinalCapital.Name = "labelCalculateFinalCapital";
            this.labelCalculateFinalCapital.Size = new System.Drawing.Size(227, 23);
            this.labelCalculateFinalCapital.TabIndex = 4;
            this.labelCalculateFinalCapital.Text = "Calculate final capital";
            this.labelCalculateFinalCapital.UseVisualStyleBackColor = true;
            this.labelCalculateFinalCapital.Click += new System.EventHandler(this.labelCalculateFinalCapital_Click);
            // 
            // Capitalcalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 150);
            this.Controls.Add(this.labelCalculateFinalCapital);
            this.Controls.Add(this.textBoxStartAmountInput);
            this.Controls.Add(this.labelFinalCapitalOutput);
            this.Controls.Add(this.labelFinalCapital);
            this.Controls.Add(this.labelStartAmount);
            this.Name = "Capitalcalculator";
            this.Text = "Iteration assignment 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStartAmount;
        private System.Windows.Forms.Label labelFinalCapital;
        private System.Windows.Forms.Label labelFinalCapitalOutput;
        private System.Windows.Forms.TextBox textBoxStartAmountInput;
        private System.Windows.Forms.Button labelCalculateFinalCapital;
    }
}

