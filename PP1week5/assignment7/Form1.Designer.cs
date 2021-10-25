
namespace assignment7
{
    partial class DiceThrowValueCounter
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
            this.buttonThrow = new System.Windows.Forms.Button();
            this.labelValueOne = new System.Windows.Forms.Label();
            this.labelValueTwo = new System.Windows.Forms.Label();
            this.labelValueThree = new System.Windows.Forms.Label();
            this.labelValueFour = new System.Windows.Forms.Label();
            this.labelValueFive = new System.Windows.Forms.Label();
            this.labelValueSix = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonThrow
            // 
            this.buttonThrow.Location = new System.Drawing.Point(116, 160);
            this.buttonThrow.Name = "buttonThrow";
            this.buttonThrow.Size = new System.Drawing.Size(154, 44);
            this.buttonThrow.TabIndex = 0;
            this.buttonThrow.Text = "Throw";
            this.buttonThrow.UseVisualStyleBackColor = true;
            this.buttonThrow.Click += new System.EventHandler(this.buttonThrow_Click);
            // 
            // labelValueOne
            // 
            this.labelValueOne.AutoSize = true;
            this.labelValueOne.Location = new System.Drawing.Point(12, 37);
            this.labelValueOne.Name = "labelValueOne";
            this.labelValueOne.Size = new System.Drawing.Size(178, 15);
            this.labelValueOne.TabIndex = 1;
            this.labelValueOne.Text = "Number of throws of value 1 = 0";
            // 
            // labelValueTwo
            // 
            this.labelValueTwo.AutoSize = true;
            this.labelValueTwo.Location = new System.Drawing.Point(12, 52);
            this.labelValueTwo.Name = "labelValueTwo";
            this.labelValueTwo.Size = new System.Drawing.Size(178, 15);
            this.labelValueTwo.TabIndex = 2;
            this.labelValueTwo.Text = "Number of throws of value 2 = 0";
            // 
            // labelValueThree
            // 
            this.labelValueThree.AutoSize = true;
            this.labelValueThree.Location = new System.Drawing.Point(12, 67);
            this.labelValueThree.Name = "labelValueThree";
            this.labelValueThree.Size = new System.Drawing.Size(178, 15);
            this.labelValueThree.TabIndex = 3;
            this.labelValueThree.Text = "Number of throws of value 3 = 0";
            // 
            // labelValueFour
            // 
            this.labelValueFour.AutoSize = true;
            this.labelValueFour.Location = new System.Drawing.Point(12, 82);
            this.labelValueFour.Name = "labelValueFour";
            this.labelValueFour.Size = new System.Drawing.Size(178, 15);
            this.labelValueFour.TabIndex = 4;
            this.labelValueFour.Text = "Number of throws of value 4 = 0";
            // 
            // labelValueFive
            // 
            this.labelValueFive.AutoSize = true;
            this.labelValueFive.Location = new System.Drawing.Point(12, 97);
            this.labelValueFive.Name = "labelValueFive";
            this.labelValueFive.Size = new System.Drawing.Size(178, 15);
            this.labelValueFive.TabIndex = 5;
            this.labelValueFive.Text = "Number of throws of value 5 = 0";
            // 
            // labelValueSix
            // 
            this.labelValueSix.AutoSize = true;
            this.labelValueSix.Location = new System.Drawing.Point(12, 112);
            this.labelValueSix.Name = "labelValueSix";
            this.labelValueSix.Size = new System.Drawing.Size(178, 15);
            this.labelValueSix.TabIndex = 6;
            this.labelValueSix.Text = "Number of throws of value 6 = 0";
            // 
            // DiceThrowValueCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 228);
            this.Controls.Add(this.labelValueSix);
            this.Controls.Add(this.labelValueFive);
            this.Controls.Add(this.labelValueFour);
            this.Controls.Add(this.labelValueThree);
            this.Controls.Add(this.labelValueTwo);
            this.Controls.Add(this.labelValueOne);
            this.Controls.Add(this.buttonThrow);
            this.Name = "DiceThrowValueCounter";
            this.Text = "Arrays assignment 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonThrow;
        private System.Windows.Forms.Label labelValueOne;
        private System.Windows.Forms.Label labelValueTwo;
        private System.Windows.Forms.Label labelValueThree;
        private System.Windows.Forms.Label labelValueFour;
        private System.Windows.Forms.Label labelValueFive;
        private System.Windows.Forms.Label labelValueSix;
    }
}

