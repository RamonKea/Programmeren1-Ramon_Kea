
namespace assignment6
{
    partial class ContentTableConverter
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
            this.labelContentTableBefore = new System.Windows.Forms.Label();
            this.labelContentTableAfter = new System.Windows.Forms.Label();
            this.labelBeforeElementComparison = new System.Windows.Forms.Label();
            this.labelComparisonNumber = new System.Windows.Forms.Label();
            this.textboxComparisonNumberInput = new System.Windows.Forms.TextBox();
            this.labelAfterElementComparison = new System.Windows.Forms.Label();
            this.buttonCompareValues = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelContentTableBefore
            // 
            this.labelContentTableBefore.AutoSize = true;
            this.labelContentTableBefore.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelContentTableBefore.Location = new System.Drawing.Point(13, 9);
            this.labelContentTableBefore.Name = "labelContentTableBefore";
            this.labelContentTableBefore.Size = new System.Drawing.Size(132, 15);
            this.labelContentTableBefore.TabIndex = 0;
            this.labelContentTableBefore.Text = "Content table (before)";
            // 
            // labelContentTableAfter
            // 
            this.labelContentTableAfter.AutoSize = true;
            this.labelContentTableAfter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelContentTableAfter.Location = new System.Drawing.Point(203, 9);
            this.labelContentTableAfter.Name = "labelContentTableAfter";
            this.labelContentTableAfter.Size = new System.Drawing.Size(122, 15);
            this.labelContentTableAfter.TabIndex = 1;
            this.labelContentTableAfter.Text = "Content table (after)";
            // 
            // labelBeforeElementComparison
            // 
            this.labelBeforeElementComparison.AutoSize = true;
            this.labelBeforeElementComparison.Location = new System.Drawing.Point(13, 43);
            this.labelBeforeElementComparison.Name = "labelBeforeElementComparison";
            this.labelBeforeElementComparison.Size = new System.Drawing.Size(0, 15);
            this.labelBeforeElementComparison.TabIndex = 2;
            // 
            // labelComparisonNumber
            // 
            this.labelComparisonNumber.AutoSize = true;
            this.labelComparisonNumber.Location = new System.Drawing.Point(17, 389);
            this.labelComparisonNumber.Name = "labelComparisonNumber";
            this.labelComparisonNumber.Size = new System.Drawing.Size(117, 15);
            this.labelComparisonNumber.TabIndex = 4;
            this.labelComparisonNumber.Text = "Comparison number";
            // 
            // textboxComparisonNumberInput
            // 
            this.textboxComparisonNumberInput.Location = new System.Drawing.Point(173, 389);
            this.textboxComparisonNumberInput.Name = "textboxComparisonNumberInput";
            this.textboxComparisonNumberInput.Size = new System.Drawing.Size(100, 23);
            this.textboxComparisonNumberInput.TabIndex = 5;
            // 
            // labelAfterElementComparison
            // 
            this.labelAfterElementComparison.AutoSize = true;
            this.labelAfterElementComparison.Location = new System.Drawing.Point(203, 43);
            this.labelAfterElementComparison.Name = "labelAfterElementComparison";
            this.labelAfterElementComparison.Size = new System.Drawing.Size(16, 15);
            this.labelAfterElementComparison.TabIndex = 3;
            this.labelAfterElementComparison.Text = "...";
            // 
            // buttonCompareValues
            // 
            this.buttonCompareValues.Location = new System.Drawing.Point(302, 389);
            this.buttonCompareValues.Name = "buttonCompareValues";
            this.buttonCompareValues.Size = new System.Drawing.Size(75, 23);
            this.buttonCompareValues.TabIndex = 7;
            this.buttonCompareValues.Text = "Compare";
            this.buttonCompareValues.UseVisualStyleBackColor = true;
            this.buttonCompareValues.Click += new System.EventHandler(this.buttonCompareValues_Click);
            // 
            // ContentTableConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 427);
            this.Controls.Add(this.buttonCompareValues);
            this.Controls.Add(this.labelAfterElementComparison);
            this.Controls.Add(this.textboxComparisonNumberInput);
            this.Controls.Add(this.labelComparisonNumber);
            this.Controls.Add(this.labelBeforeElementComparison);
            this.Controls.Add(this.labelContentTableAfter);
            this.Controls.Add(this.labelContentTableBefore);
            this.Name = "ContentTableConverter";
            this.Text = "Arrays assignment 6";
            this.Load += new System.EventHandler(this.ContentTableConverter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelContentTableBefore;
        private System.Windows.Forms.Label labelContentTableAfter;
        private System.Windows.Forms.Label labelBeforeElementComparison;
        private System.Windows.Forms.Label labelComparisonNumber;
        private System.Windows.Forms.TextBox textboxComparisonNumberInput;
        private System.Windows.Forms.Label labelAfterElementComparison;
        private System.Windows.Forms.Button buttonCompareValues;
    }
}

