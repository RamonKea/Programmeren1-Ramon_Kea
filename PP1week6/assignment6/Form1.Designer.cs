
namespace assignment6
{
    partial class SquareByThreeMethodsCalculator
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
            this.labelNumber = new System.Windows.Forms.Label();
            this.textBoxNumberInput = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelResultOutput = new System.Windows.Forms.Label();
            this.buttonSquareByReference = new System.Windows.Forms.Button();
            this.buttonSquareByReferenceOut = new System.Windows.Forms.Button();
            this.buttonSquareByValue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(13, 33);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(51, 15);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "Number";
            // 
            // textBoxNumberInput
            // 
            this.textBoxNumberInput.Location = new System.Drawing.Point(174, 25);
            this.textBoxNumberInput.Name = "textBoxNumberInput";
            this.textBoxNumberInput.Size = new System.Drawing.Size(100, 23);
            this.textBoxNumberInput.TabIndex = 1;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(13, 182);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(39, 15);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "Result";
            // 
            // labelResultOutput
            // 
            this.labelResultOutput.AutoSize = true;
            this.labelResultOutput.Location = new System.Drawing.Point(174, 182);
            this.labelResultOutput.Name = "labelResultOutput";
            this.labelResultOutput.Size = new System.Drawing.Size(13, 15);
            this.labelResultOutput.TabIndex = 3;
            this.labelResultOutput.Text = "0";
            // 
            // buttonSquareByReference
            // 
            this.buttonSquareByReference.Location = new System.Drawing.Point(13, 72);
            this.buttonSquareByReference.Name = "buttonSquareByReference";
            this.buttonSquareByReference.Size = new System.Drawing.Size(261, 23);
            this.buttonSquareByReference.TabIndex = 4;
            this.buttonSquareByReference.Text = "Square By Reference";
            this.buttonSquareByReference.UseVisualStyleBackColor = true;
            this.buttonSquareByReference.Click += new System.EventHandler(this.buttonSquareByReference_Click);
            // 
            // buttonSquareByReferenceOut
            // 
            this.buttonSquareByReferenceOut.Location = new System.Drawing.Point(13, 101);
            this.buttonSquareByReferenceOut.Name = "buttonSquareByReferenceOut";
            this.buttonSquareByReferenceOut.Size = new System.Drawing.Size(261, 23);
            this.buttonSquareByReferenceOut.TabIndex = 5;
            this.buttonSquareByReferenceOut.Text = "Square By Reference Out";
            this.buttonSquareByReferenceOut.UseVisualStyleBackColor = true;
            this.buttonSquareByReferenceOut.Click += new System.EventHandler(this.buttonSquareByReferenceOut_Click);
            // 
            // buttonSquareByValue
            // 
            this.buttonSquareByValue.Location = new System.Drawing.Point(13, 130);
            this.buttonSquareByValue.Name = "buttonSquareByValue";
            this.buttonSquareByValue.Size = new System.Drawing.Size(261, 23);
            this.buttonSquareByValue.TabIndex = 6;
            this.buttonSquareByValue.Text = "Square By Value";
            this.buttonSquareByValue.UseVisualStyleBackColor = true;
            this.buttonSquareByValue.Click += new System.EventHandler(this.buttonSquareByValue_Click);
            // 
            // SquareByThreeMethodsCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 212);
            this.Controls.Add(this.buttonSquareByValue);
            this.Controls.Add(this.buttonSquareByReferenceOut);
            this.Controls.Add(this.buttonSquareByReference);
            this.Controls.Add(this.labelResultOutput);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxNumberInput);
            this.Controls.Add(this.labelNumber);
            this.Name = "SquareByThreeMethodsCalculator";
            this.Text = "Methods assignment 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TextBox textBoxNumberInput;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelResultOutput;
        private System.Windows.Forms.Button buttonSquareByReference;
        private System.Windows.Forms.Button buttonSquareByReferenceOut;
        private System.Windows.Forms.Button buttonSquareByValue;
    }
}

