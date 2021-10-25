
namespace assignment5
{
    partial class Calculator
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
            this.textBoxNumberOneInput = new System.Windows.Forms.TextBox();
            this.textBoxNumberTwoInput = new System.Windows.Forms.TextBox();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonTimes = new System.Windows.Forms.Button();
            this.buttonDivider = new System.Windows.Forms.Button();
            this.labelNumberOne = new System.Windows.Forms.Label();
            this.labelNumberTwo = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelResultOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNumberOneInput
            // 
            this.textBoxNumberOneInput.Location = new System.Drawing.Point(176, 21);
            this.textBoxNumberOneInput.Name = "textBoxNumberOneInput";
            this.textBoxNumberOneInput.Size = new System.Drawing.Size(139, 23);
            this.textBoxNumberOneInput.TabIndex = 0;
            // 
            // textBoxNumberTwoInput
            // 
            this.textBoxNumberTwoInput.Location = new System.Drawing.Point(176, 50);
            this.textBoxNumberTwoInput.Name = "textBoxNumberTwoInput";
            this.textBoxNumberTwoInput.Size = new System.Drawing.Size(139, 23);
            this.textBoxNumberTwoInput.TabIndex = 1;
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPlus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPlus.Location = new System.Drawing.Point(20, 95);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(62, 51);
            this.buttonPlus.TabIndex = 2;
            this.buttonPlus.Text = "+";
            this.buttonPlus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMinus.Location = new System.Drawing.Point(97, 95);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(62, 51);
            this.buttonMinus.TabIndex = 3;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonTimes
            // 
            this.buttonTimes.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonTimes.Location = new System.Drawing.Point(176, 95);
            this.buttonTimes.Name = "buttonTimes";
            this.buttonTimes.Size = new System.Drawing.Size(62, 51);
            this.buttonTimes.TabIndex = 4;
            this.buttonTimes.Text = "X";
            this.buttonTimes.UseVisualStyleBackColor = true;
            this.buttonTimes.Click += new System.EventHandler(this.buttonTimes_Click);
            // 
            // buttonDivider
            // 
            this.buttonDivider.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDivider.Location = new System.Drawing.Point(253, 95);
            this.buttonDivider.Name = "buttonDivider";
            this.buttonDivider.Size = new System.Drawing.Size(62, 51);
            this.buttonDivider.TabIndex = 5;
            this.buttonDivider.Text = ":";
            this.buttonDivider.UseVisualStyleBackColor = true;
            this.buttonDivider.Click += new System.EventHandler(this.buttonDivider_Click);
            // 
            // labelNumberOne
            // 
            this.labelNumberOne.AutoSize = true;
            this.labelNumberOne.Location = new System.Drawing.Point(20, 24);
            this.labelNumberOne.Name = "labelNumberOne";
            this.labelNumberOne.Size = new System.Drawing.Size(60, 15);
            this.labelNumberOne.TabIndex = 6;
            this.labelNumberOne.Text = "Number 1";
            // 
            // labelNumberTwo
            // 
            this.labelNumberTwo.AutoSize = true;
            this.labelNumberTwo.Location = new System.Drawing.Point(20, 50);
            this.labelNumberTwo.Name = "labelNumberTwo";
            this.labelNumberTwo.Size = new System.Drawing.Size(60, 15);
            this.labelNumberTwo.TabIndex = 7;
            this.labelNumberTwo.Text = "Number 2";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 165);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(39, 15);
            this.labelResult.TabIndex = 8;
            this.labelResult.Text = "Result";
            // 
            // labelResultOutput
            // 
            this.labelResultOutput.AutoSize = true;
            this.labelResultOutput.Location = new System.Drawing.Point(159, 165);
            this.labelResultOutput.Name = "labelResultOutput";
            this.labelResultOutput.Size = new System.Drawing.Size(13, 15);
            this.labelResultOutput.TabIndex = 9;
            this.labelResultOutput.Text = "0";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 192);
            this.Controls.Add(this.labelResultOutput);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelNumberTwo);
            this.Controls.Add(this.labelNumberOne);
            this.Controls.Add(this.buttonDivider);
            this.Controls.Add(this.buttonTimes);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.textBoxNumberTwoInput);
            this.Controls.Add(this.textBoxNumberOneInput);
            this.Name = "Calculator";
            this.Text = "Methods assignment 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumberOneInput;
        private System.Windows.Forms.TextBox textBoxNumberTwoInput;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonTimes;
        private System.Windows.Forms.Button buttonDivider;
        private System.Windows.Forms.Label labelNumberOne;
        private System.Windows.Forms.Label labelNumberTwo;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelResultOutput;
    }
}

