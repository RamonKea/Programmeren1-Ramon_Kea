
namespace assingment4
{
    partial class Formvatcalculator
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
            this.buttondeterminevat = new System.Windows.Forms.Button();
            this.textBoxprice = new System.Windows.Forms.TextBox();
            this.labelenteraprice = new System.Windows.Forms.Label();
            this.labelprice = new System.Windows.Forms.Label();
            this.labelvat = new System.Windows.Forms.Label();
            this.labeltotal = new System.Windows.Forms.Label();
            this.labelPriceOutput = new System.Windows.Forms.Label();
            this.labelVATInput = new System.Windows.Forms.Label();
            this.labelTotalInput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttondeterminevat
            // 
            this.buttondeterminevat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttondeterminevat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttondeterminevat.Location = new System.Drawing.Point(93, 59);
            this.buttondeterminevat.Margin = new System.Windows.Forms.Padding(2);
            this.buttondeterminevat.Name = "buttondeterminevat";
            this.buttondeterminevat.Size = new System.Drawing.Size(284, 23);
            this.buttondeterminevat.TabIndex = 0;
            this.buttondeterminevat.Text = "Determine VAT";
            this.buttondeterminevat.UseVisualStyleBackColor = true;
            this.buttondeterminevat.Click += new System.EventHandler(this.buttondeterminevat_Click);
            // 
            // textBoxprice
            // 
            this.textBoxprice.Location = new System.Drawing.Point(272, 23);
            this.textBoxprice.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxprice.Name = "textBoxprice";
            this.textBoxprice.Size = new System.Drawing.Size(106, 23);
            this.textBoxprice.TabIndex = 1;
            // 
            // labelenteraprice
            // 
            this.labelenteraprice.AutoSize = true;
            this.labelenteraprice.Location = new System.Drawing.Point(93, 26);
            this.labelenteraprice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelenteraprice.Name = "labelenteraprice";
            this.labelenteraprice.Size = new System.Drawing.Size(75, 15);
            this.labelenteraprice.TabIndex = 2;
            this.labelenteraprice.Text = "Enter a price:";
            // 
            // labelprice
            // 
            this.labelprice.AutoSize = true;
            this.labelprice.Location = new System.Drawing.Point(93, 103);
            this.labelprice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelprice.Name = "labelprice";
            this.labelprice.Size = new System.Drawing.Size(36, 15);
            this.labelprice.TabIndex = 3;
            this.labelprice.Text = "Price:";
            // 
            // labelvat
            // 
            this.labelvat.AutoSize = true;
            this.labelvat.Location = new System.Drawing.Point(93, 136);
            this.labelvat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelvat.Name = "labelvat";
            this.labelvat.Size = new System.Drawing.Size(29, 15);
            this.labelvat.TabIndex = 4;
            this.labelvat.Text = "VAT:";
            // 
            // labeltotal
            // 
            this.labeltotal.AutoSize = true;
            this.labeltotal.Location = new System.Drawing.Point(93, 173);
            this.labeltotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeltotal.Name = "labeltotal";
            this.labeltotal.Size = new System.Drawing.Size(35, 15);
            this.labeltotal.TabIndex = 5;
            this.labeltotal.Text = "Total:";
            // 
            // labelPriceOutput
            // 
            this.labelPriceOutput.AutoSize = true;
            this.labelPriceOutput.Location = new System.Drawing.Point(331, 103);
            this.labelPriceOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPriceOutput.Name = "labelPriceOutput";
            this.labelPriceOutput.Size = new System.Drawing.Size(13, 15);
            this.labelPriceOutput.TabIndex = 6;
            this.labelPriceOutput.Text = "0";
            this.labelPriceOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelVATInput
            // 
            this.labelVATInput.AutoSize = true;
            this.labelVATInput.Location = new System.Drawing.Point(331, 136);
            this.labelVATInput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVATInput.Name = "labelVATInput";
            this.labelVATInput.Size = new System.Drawing.Size(13, 15);
            this.labelVATInput.TabIndex = 7;
            this.labelVATInput.Text = "0";
            this.labelVATInput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotalInput
            // 
            this.labelTotalInput.AutoSize = true;
            this.labelTotalInput.Location = new System.Drawing.Point(331, 173);
            this.labelTotalInput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalInput.Name = "labelTotalInput";
            this.labelTotalInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTotalInput.Size = new System.Drawing.Size(13, 15);
            this.labelTotalInput.TabIndex = 8;
            this.labelTotalInput.Text = "0";
            this.labelTotalInput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Formvatcalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 270);
            this.Controls.Add(this.labelTotalInput);
            this.Controls.Add(this.labelVATInput);
            this.Controls.Add(this.labelPriceOutput);
            this.Controls.Add(this.labeltotal);
            this.Controls.Add(this.labelvat);
            this.Controls.Add(this.labelprice);
            this.Controls.Add(this.labelenteraprice);
            this.Controls.Add(this.textBoxprice);
            this.Controls.Add(this.buttondeterminevat);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Formvatcalculator";
            this.Text = "Sequence - assignment 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttondeterminevat;
        private System.Windows.Forms.TextBox textBoxprice;
        private System.Windows.Forms.Label labelenteraprice;
        private System.Windows.Forms.Label labelprice;
        private System.Windows.Forms.Label labelvat;
        private System.Windows.Forms.Label labeltotal;
        private System.Windows.Forms.Label labelPriceOutput;
        private System.Windows.Forms.Label labelVATInput;
        private System.Windows.Forms.Label labelTotalInput;
    }
}

