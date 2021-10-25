
namespace assignment8
{
    partial class FomulaResultComperor
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
            this.buttonCompare = new System.Windows.Forms.Button();
            this.textBoxEnterNumberInput = new System.Windows.Forms.TextBox();
            this.labelEnterNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSumOneOutput = new System.Windows.Forms.Label();
            this.labelSumTwoOutput = new System.Windows.Forms.Label();
            this.labelComparisonOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCompare
            // 
            this.buttonCompare.Location = new System.Drawing.Point(12, 70);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(287, 31);
            this.buttonCompare.TabIndex = 0;
            this.buttonCompare.Text = "Compare";
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
            // 
            // textBoxEnterNumberInput
            // 
            this.textBoxEnterNumberInput.Location = new System.Drawing.Point(199, 31);
            this.textBoxEnterNumberInput.Name = "textBoxEnterNumberInput";
            this.textBoxEnterNumberInput.Size = new System.Drawing.Size(100, 23);
            this.textBoxEnterNumberInput.TabIndex = 1;
            // 
            // labelEnterNumber
            // 
            this.labelEnterNumber.AutoSize = true;
            this.labelEnterNumber.Location = new System.Drawing.Point(13, 39);
            this.labelEnterNumber.Name = "labelEnterNumber";
            this.labelEnterNumber.Size = new System.Drawing.Size(106, 15);
            this.labelEnterNumber.TabIndex = 2;
            this.labelEnterNumber.Text = "Enter a number (n)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "sum = 1 + 2 + ... + n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "sum = n * (n + 1) / 2";
            // 
            // labelSumOneOutput
            // 
            this.labelSumOneOutput.AutoSize = true;
            this.labelSumOneOutput.Location = new System.Drawing.Point(261, 139);
            this.labelSumOneOutput.Name = "labelSumOneOutput";
            this.labelSumOneOutput.Size = new System.Drawing.Size(0, 15);
            this.labelSumOneOutput.TabIndex = 5;
            // 
            // labelSumTwoOutput
            // 
            this.labelSumTwoOutput.AutoSize = true;
            this.labelSumTwoOutput.Location = new System.Drawing.Point(261, 170);
            this.labelSumTwoOutput.Name = "labelSumTwoOutput";
            this.labelSumTwoOutput.Size = new System.Drawing.Size(0, 15);
            this.labelSumTwoOutput.TabIndex = 6;
            // 
            // labelComparisonOutput
            // 
            this.labelComparisonOutput.AutoSize = true;
            this.labelComparisonOutput.Location = new System.Drawing.Point(13, 206);
            this.labelComparisonOutput.Name = "labelComparisonOutput";
            this.labelComparisonOutput.Size = new System.Drawing.Size(0, 15);
            this.labelComparisonOutput.TabIndex = 7;
            // 
            // FomulaResultComperor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 242);
            this.Controls.Add(this.labelComparisonOutput);
            this.Controls.Add(this.labelSumTwoOutput);
            this.Controls.Add(this.labelSumOneOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelEnterNumber);
            this.Controls.Add(this.textBoxEnterNumberInput);
            this.Controls.Add(this.buttonCompare);
            this.Name = "FomulaResultComperor";
            this.Text = "Iteration assignment 8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCompare;
        private System.Windows.Forms.TextBox textBoxEnterNumberInput;
        private System.Windows.Forms.Label labelEnterNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSumOneOutput;
        private System.Windows.Forms.Label labelSumTwoOutput;
        private System.Windows.Forms.Label labelComparisonOutput;
    }
}

