
namespace assingment5
{
    partial class Form1
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
            this.labelNumber1 = new System.Windows.Forms.Label();
            this.labelNumber2 = new System.Windows.Forms.Label();
            this.labelNumber3 = new System.Windows.Forms.Label();
            this.textBoxNumber1Input = new System.Windows.Forms.TextBox();
            this.textBoxNumber2Input = new System.Windows.Forms.TextBox();
            this.textBoxNumber3Input = new System.Windows.Forms.TextBox();
            this.buttonCalculateAverage = new System.Windows.Forms.Button();
            this.labelAverage = new System.Windows.Forms.Label();
            this.labelAverageOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNumber1
            // 
            this.labelNumber1.AutoSize = true;
            this.labelNumber1.Location = new System.Drawing.Point(12, 29);
            this.labelNumber1.Name = "labelNumber1";
            this.labelNumber1.Size = new System.Drawing.Size(63, 15);
            this.labelNumber1.TabIndex = 0;
            this.labelNumber1.Text = "Number 1:";
            // 
            // labelNumber2
            // 
            this.labelNumber2.AutoSize = true;
            this.labelNumber2.Location = new System.Drawing.Point(12, 63);
            this.labelNumber2.Name = "labelNumber2";
            this.labelNumber2.Size = new System.Drawing.Size(63, 15);
            this.labelNumber2.TabIndex = 1;
            this.labelNumber2.Text = "Number 2:";
            // 
            // labelNumber3
            // 
            this.labelNumber3.AutoSize = true;
            this.labelNumber3.Location = new System.Drawing.Point(12, 97);
            this.labelNumber3.Name = "labelNumber3";
            this.labelNumber3.Size = new System.Drawing.Size(63, 15);
            this.labelNumber3.TabIndex = 2;
            this.labelNumber3.Text = "Number 3:";
            // 
            // textBoxNumber1Input
            // 
            this.textBoxNumber1Input.Location = new System.Drawing.Point(152, 21);
            this.textBoxNumber1Input.Name = "textBoxNumber1Input";
            this.textBoxNumber1Input.Size = new System.Drawing.Size(119, 23);
            this.textBoxNumber1Input.TabIndex = 3;
            // 
            // textBoxNumber2Input
            // 
            this.textBoxNumber2Input.Location = new System.Drawing.Point(152, 55);
            this.textBoxNumber2Input.Name = "textBoxNumber2Input";
            this.textBoxNumber2Input.Size = new System.Drawing.Size(119, 23);
            this.textBoxNumber2Input.TabIndex = 4;
            // 
            // textBoxNumber3Input
            // 
            this.textBoxNumber3Input.Location = new System.Drawing.Point(152, 94);
            this.textBoxNumber3Input.Name = "textBoxNumber3Input";
            this.textBoxNumber3Input.Size = new System.Drawing.Size(119, 23);
            this.textBoxNumber3Input.TabIndex = 5;
            // 
            // buttonCalculateAverage
            // 
            this.buttonCalculateAverage.Location = new System.Drawing.Point(12, 138);
            this.buttonCalculateAverage.Name = "buttonCalculateAverage";
            this.buttonCalculateAverage.Size = new System.Drawing.Size(259, 23);
            this.buttonCalculateAverage.TabIndex = 6;
            this.buttonCalculateAverage.Text = "Calculate average";
            this.buttonCalculateAverage.UseVisualStyleBackColor = true;
            this.buttonCalculateAverage.Click += new System.EventHandler(this.buttonCalculateAverage_Click);
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Location = new System.Drawing.Point(14, 178);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(50, 15);
            this.labelAverage.TabIndex = 7;
            this.labelAverage.Text = "Average";
            // 
            // labelAverageOutput
            // 
            this.labelAverageOutput.AutoSize = true;
            this.labelAverageOutput.Location = new System.Drawing.Point(152, 178);
            this.labelAverageOutput.Name = "labelAverageOutput";
            this.labelAverageOutput.Size = new System.Drawing.Size(13, 15);
            this.labelAverageOutput.TabIndex = 8;
            this.labelAverageOutput.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 219);
            this.Controls.Add(this.labelAverageOutput);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.buttonCalculateAverage);
            this.Controls.Add(this.textBoxNumber3Input);
            this.Controls.Add(this.textBoxNumber2Input);
            this.Controls.Add(this.textBoxNumber1Input);
            this.Controls.Add(this.labelNumber3);
            this.Controls.Add(this.labelNumber2);
            this.Controls.Add(this.labelNumber1);
            this.Name = "Form1";
            this.Text = "Sequence - assingment 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumber1;
        private System.Windows.Forms.Label labelNumber2;
        private System.Windows.Forms.Label labelNumber3;
        private System.Windows.Forms.TextBox textBoxNumber1Input;
        private System.Windows.Forms.TextBox textBoxNumber2Input;
        private System.Windows.Forms.TextBox textBoxNumber3Input;
        private System.Windows.Forms.Button buttonCalculateAverage;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.Label labelAverageOutput;
    }
}

