
namespace assingment_8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelNumberTshirts = new System.Windows.Forms.Label();
            this.labelNumberJeans = new System.Windows.Forms.Label();
            this.labelInvoice = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelVAT = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.labelDateOutput = new System.Windows.Forms.Label();
            this.labelPriceOutput = new System.Windows.Forms.Label();
            this.labelVATOutput = new System.Windows.Forms.Label();
            this.labelTotalpriceWithVATOutput = new System.Windows.Forms.Label();
            this.textBoxNumberOfTshirtsInput = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfJeansInput = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(68, 156);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(312, 41);
            this.buttonCalculate.TabIndex = 0;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelNumberTshirts
            // 
            this.labelNumberTshirts.AutoSize = true;
            this.labelNumberTshirts.Location = new System.Drawing.Point(68, 60);
            this.labelNumberTshirts.Name = "labelNumberTshirts";
            this.labelNumberTshirts.Size = new System.Drawing.Size(163, 15);
            this.labelNumberTshirts.TabIndex = 1;
            this.labelNumberTshirts.Text = "Number of T-shirts (x € 30.00)";
            // 
            // labelNumberJeans
            // 
            this.labelNumberJeans.AutoSize = true;
            this.labelNumberJeans.Location = new System.Drawing.Point(68, 100);
            this.labelNumberJeans.Name = "labelNumberJeans";
            this.labelNumberJeans.Size = new System.Drawing.Size(157, 15);
            this.labelNumberJeans.TabIndex = 2;
            this.labelNumberJeans.Text = "Number of jeans (x € 100.00)";
            // 
            // labelInvoice
            // 
            this.labelInvoice.AutoSize = true;
            this.labelInvoice.Location = new System.Drawing.Point(68, 228);
            this.labelInvoice.Name = "labelInvoice";
            this.labelInvoice.Size = new System.Drawing.Size(45, 15);
            this.labelInvoice.TabIndex = 3;
            this.labelInvoice.Text = "Invoice";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(68, 264);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(34, 15);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "Date:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(68, 301);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(36, 15);
            this.labelPrice.TabIndex = 5;
            this.labelPrice.Text = "Price:";
            // 
            // labelVAT
            // 
            this.labelVAT.AutoSize = true;
            this.labelVAT.Location = new System.Drawing.Point(68, 334);
            this.labelVAT.Name = "labelVAT";
            this.labelVAT.Size = new System.Drawing.Size(29, 15);
            this.labelVAT.TabIndex = 6;
            this.labelVAT.Text = "VAT:";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Location = new System.Drawing.Point(68, 367);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(64, 15);
            this.labelTotalPrice.TabIndex = 7;
            this.labelTotalPrice.Text = "Total price:";
            // 
            // labelDateOutput
            // 
            this.labelDateOutput.AutoSize = true;
            this.labelDateOutput.Location = new System.Drawing.Point(270, 264);
            this.labelDateOutput.Name = "labelDateOutput";
            this.labelDateOutput.Size = new System.Drawing.Size(110, 15);
            this.labelDateOutput.TabIndex = 8;
            this.labelDateOutput.Text = "00:00:00 00/00/0000";
            // 
            // labelPriceOutput
            // 
            this.labelPriceOutput.AutoSize = true;
            this.labelPriceOutput.Location = new System.Drawing.Point(340, 301);
            this.labelPriceOutput.Name = "labelPriceOutput";
            this.labelPriceOutput.Size = new System.Drawing.Size(40, 15);
            this.labelPriceOutput.TabIndex = 9;
            this.labelPriceOutput.Text = "€00.00";
            // 
            // labelVATOutput
            // 
            this.labelVATOutput.AutoSize = true;
            this.labelVATOutput.Location = new System.Drawing.Point(340, 334);
            this.labelVATOutput.Name = "labelVATOutput";
            this.labelVATOutput.Size = new System.Drawing.Size(40, 15);
            this.labelVATOutput.TabIndex = 10;
            this.labelVATOutput.Text = "€00.00";
            // 
            // labelTotalpriceWithVATOutput
            // 
            this.labelTotalpriceWithVATOutput.AutoSize = true;
            this.labelTotalpriceWithVATOutput.Location = new System.Drawing.Point(340, 367);
            this.labelTotalpriceWithVATOutput.Name = "labelTotalpriceWithVATOutput";
            this.labelTotalpriceWithVATOutput.Size = new System.Drawing.Size(40, 15);
            this.labelTotalpriceWithVATOutput.TabIndex = 11;
            this.labelTotalpriceWithVATOutput.Text = "€00.00";
            // 
            // textBoxNumberOfTshirtsInput
            // 
            this.textBoxNumberOfTshirtsInput.Location = new System.Drawing.Point(280, 52);
            this.textBoxNumberOfTshirtsInput.Name = "textBoxNumberOfTshirtsInput";
            this.textBoxNumberOfTshirtsInput.Size = new System.Drawing.Size(100, 23);
            this.textBoxNumberOfTshirtsInput.TabIndex = 12;
            // 
            // textBoxNumberOfJeansInput
            // 
            this.textBoxNumberOfJeansInput.Location = new System.Drawing.Point(280, 92);
            this.textBoxNumberOfJeansInput.Name = "textBoxNumberOfJeansInput";
            this.textBoxNumberOfJeansInput.Size = new System.Drawing.Size(100, 23);
            this.textBoxNumberOfJeansInput.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(84, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 30);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxNumberOfJeansInput);
            this.Controls.Add(this.textBoxNumberOfTshirtsInput);
            this.Controls.Add(this.labelTotalpriceWithVATOutput);
            this.Controls.Add(this.labelVATOutput);
            this.Controls.Add(this.labelPriceOutput);
            this.Controls.Add(this.labelDateOutput);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.labelVAT);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelInvoice);
            this.Controls.Add(this.labelNumberJeans);
            this.Controls.Add(this.labelNumberTshirts);
            this.Controls.Add(this.buttonCalculate);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sequence - assignment 8";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelNumberTshirts;
        private System.Windows.Forms.Label labelNumberJeans;
        private System.Windows.Forms.Label labelInvoice;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelVAT;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label labelDateOutput;
        private System.Windows.Forms.Label labelPriceOutput;
        private System.Windows.Forms.Label labelVATOutput;
        private System.Windows.Forms.Label labelTotalpriceWithVATOutput;
        private System.Windows.Forms.TextBox textBoxNumberOfTshirtsInput;
        private System.Windows.Forms.TextBox textBoxNumberOfJeansInput;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

