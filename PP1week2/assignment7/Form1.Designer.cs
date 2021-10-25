
namespace assignment_7
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
            this.buttonErase = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelStartKm = new System.Windows.Forms.Label();
            this.labelEndKm = new System.Windows.Forms.Label();
            this.labelPriceKm = new System.Windows.Forms.Label();
            this.labelPriceExclusiveVAT = new System.Windows.Forms.Label();
            this.labelVAT = new System.Windows.Forms.Label();
            this.labelPriceInclusiveVAT = new System.Windows.Forms.Label();
            this.labelOuputPriceExclusiveVAT = new System.Windows.Forms.Label();
            this.labelOutputVAT = new System.Windows.Forms.Label();
            this.labelOutputInclusiveVAT = new System.Windows.Forms.Label();
            this.textBoxInputStartKm = new System.Windows.Forms.TextBox();
            this.textBoxInputEndKm = new System.Windows.Forms.TextBox();
            this.textBoxInputPriceKm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonErase
            // 
            this.buttonErase.Location = new System.Drawing.Point(320, 37);
            this.buttonErase.Name = "buttonErase";
            this.buttonErase.Size = new System.Drawing.Size(75, 23);
            this.buttonErase.TabIndex = 0;
            this.buttonErase.Text = "Erase";
            this.buttonErase.UseVisualStyleBackColor = true;
            this.buttonErase.Click += new System.EventHandler(this.buttonErase_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(320, 105);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 1;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelStartKm
            // 
            this.labelStartKm.AutoSize = true;
            this.labelStartKm.Location = new System.Drawing.Point(12, 45);
            this.labelStartKm.Name = "labelStartKm";
            this.labelStartKm.Size = new System.Drawing.Size(51, 15);
            this.labelStartKm.TabIndex = 2;
            this.labelStartKm.Text = "Start km";
            // 
            // labelEndKm
            // 
            this.labelEndKm.AutoSize = true;
            this.labelEndKm.Location = new System.Drawing.Point(12, 78);
            this.labelEndKm.Name = "labelEndKm";
            this.labelEndKm.Size = new System.Drawing.Size(47, 15);
            this.labelEndKm.TabIndex = 3;
            this.labelEndKm.Text = "End km";
            // 
            // labelPriceKm
            // 
            this.labelPriceKm.AutoSize = true;
            this.labelPriceKm.Location = new System.Drawing.Point(12, 113);
            this.labelPriceKm.Name = "labelPriceKm";
            this.labelPriceKm.Size = new System.Drawing.Size(58, 15);
            this.labelPriceKm.TabIndex = 4;
            this.labelPriceKm.Text = "Price /km";
            // 
            // labelPriceExclusiveVAT
            // 
            this.labelPriceExclusiveVAT.AutoSize = true;
            this.labelPriceExclusiveVAT.Location = new System.Drawing.Point(12, 181);
            this.labelPriceExclusiveVAT.Name = "labelPriceExclusiveVAT";
            this.labelPriceExclusiveVAT.Size = new System.Drawing.Size(79, 15);
            this.labelPriceExclusiveVAT.TabIndex = 5;
            this.labelPriceExclusiveVAT.Text = "Price excl VAT";
            // 
            // labelVAT
            // 
            this.labelVAT.AutoSize = true;
            this.labelVAT.Location = new System.Drawing.Point(120, 181);
            this.labelVAT.Name = "labelVAT";
            this.labelVAT.Size = new System.Drawing.Size(26, 15);
            this.labelVAT.TabIndex = 6;
            this.labelVAT.Text = "VAT";
            // 
            // labelPriceInclusiveVAT
            // 
            this.labelPriceInclusiveVAT.AutoSize = true;
            this.labelPriceInclusiveVAT.Location = new System.Drawing.Point(320, 181);
            this.labelPriceInclusiveVAT.Name = "labelPriceInclusiveVAT";
            this.labelPriceInclusiveVAT.Size = new System.Drawing.Size(77, 15);
            this.labelPriceInclusiveVAT.TabIndex = 7;
            this.labelPriceInclusiveVAT.Text = "Price incl VAT";
            // 
            // labelOuputPriceExclusiveVAT
            // 
            this.labelOuputPriceExclusiveVAT.AutoSize = true;
            this.labelOuputPriceExclusiveVAT.Location = new System.Drawing.Point(12, 222);
            this.labelOuputPriceExclusiveVAT.Name = "labelOuputPriceExclusiveVAT";
            this.labelOuputPriceExclusiveVAT.Size = new System.Drawing.Size(34, 15);
            this.labelOuputPriceExclusiveVAT.TabIndex = 8;
            this.labelOuputPriceExclusiveVAT.Text = "00.00";
            // 
            // labelOutputVAT
            // 
            this.labelOutputVAT.AutoSize = true;
            this.labelOutputVAT.Location = new System.Drawing.Point(120, 222);
            this.labelOutputVAT.Name = "labelOutputVAT";
            this.labelOutputVAT.Size = new System.Drawing.Size(34, 15);
            this.labelOutputVAT.TabIndex = 9;
            this.labelOutputVAT.Text = "00.00";
            // 
            // labelOutputInclusiveVAT
            // 
            this.labelOutputInclusiveVAT.AutoSize = true;
            this.labelOutputInclusiveVAT.Location = new System.Drawing.Point(320, 222);
            this.labelOutputInclusiveVAT.Name = "labelOutputInclusiveVAT";
            this.labelOutputInclusiveVAT.Size = new System.Drawing.Size(34, 15);
            this.labelOutputInclusiveVAT.TabIndex = 10;
            this.labelOutputInclusiveVAT.Text = "00.00";
            // 
            // textBoxInputStartKm
            // 
            this.textBoxInputStartKm.Location = new System.Drawing.Point(120, 37);
            this.textBoxInputStartKm.Name = "textBoxInputStartKm";
            this.textBoxInputStartKm.Size = new System.Drawing.Size(134, 23);
            this.textBoxInputStartKm.TabIndex = 11;
            // 
            // textBoxInputEndKm
            // 
            this.textBoxInputEndKm.Location = new System.Drawing.Point(120, 70);
            this.textBoxInputEndKm.Name = "textBoxInputEndKm";
            this.textBoxInputEndKm.Size = new System.Drawing.Size(134, 23);
            this.textBoxInputEndKm.TabIndex = 12;
            // 
            // textBoxInputPriceKm
            // 
            this.textBoxInputPriceKm.Location = new System.Drawing.Point(120, 105);
            this.textBoxInputPriceKm.Name = "textBoxInputPriceKm";
            this.textBoxInputPriceKm.Size = new System.Drawing.Size(134, 23);
            this.textBoxInputPriceKm.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 249);
            this.Controls.Add(this.textBoxInputPriceKm);
            this.Controls.Add(this.textBoxInputEndKm);
            this.Controls.Add(this.textBoxInputStartKm);
            this.Controls.Add(this.labelOutputInclusiveVAT);
            this.Controls.Add(this.labelOutputVAT);
            this.Controls.Add(this.labelOuputPriceExclusiveVAT);
            this.Controls.Add(this.labelPriceInclusiveVAT);
            this.Controls.Add(this.labelVAT);
            this.Controls.Add(this.labelPriceExclusiveVAT);
            this.Controls.Add(this.labelPriceKm);
            this.Controls.Add(this.labelEndKm);
            this.Controls.Add(this.labelStartKm);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.buttonErase);
            this.Name = "Form1";
            this.Text = "Sequence - assingment 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonErase;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelStartKm;
        private System.Windows.Forms.Label labelEndKm;
        private System.Windows.Forms.Label labelPriceKm;
        private System.Windows.Forms.Label labelPriceExclusiveVAT;
        private System.Windows.Forms.Label labelVAT;
        private System.Windows.Forms.Label labelPriceInclusiveVAT;
        private System.Windows.Forms.Label labelOuputPriceExclusiveVAT;
        private System.Windows.Forms.Label labelOutputVAT;
        private System.Windows.Forms.Label labelOutputInclusiveVAT;
        private System.Windows.Forms.TextBox textBoxInputStartKm;
        private System.Windows.Forms.TextBox textBoxInputEndKm;
        private System.Windows.Forms.TextBox textBoxInputPriceKm;
    }
}

