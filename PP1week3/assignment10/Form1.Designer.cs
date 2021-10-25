
namespace assignment10
{
    partial class CinemaTicketCalculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxAgeInput = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelPriceTicket = new System.Windows.Forms.Label();
            this.labelCalculatedPriceTicketOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate Price";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxAgeInput
            // 
            this.textBoxAgeInput.Location = new System.Drawing.Point(145, 34);
            this.textBoxAgeInput.Name = "textBoxAgeInput";
            this.textBoxAgeInput.Size = new System.Drawing.Size(100, 23);
            this.textBoxAgeInput.TabIndex = 1;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(12, 34);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(28, 15);
            this.labelAge.TabIndex = 2;
            this.labelAge.Text = "Age";
            // 
            // labelPriceTicket
            // 
            this.labelPriceTicket.AutoSize = true;
            this.labelPriceTicket.Location = new System.Drawing.Point(12, 109);
            this.labelPriceTicket.Name = "labelPriceTicket";
            this.labelPriceTicket.Size = new System.Drawing.Size(65, 15);
            this.labelPriceTicket.TabIndex = 3;
            this.labelPriceTicket.Text = "Price ticket";
            // 
            // labelCalculatedPriceTicketOutput
            // 
            this.labelCalculatedPriceTicketOutput.AutoSize = true;
            this.labelCalculatedPriceTicketOutput.Location = new System.Drawing.Point(145, 109);
            this.labelCalculatedPriceTicketOutput.Name = "labelCalculatedPriceTicketOutput";
            this.labelCalculatedPriceTicketOutput.Size = new System.Drawing.Size(37, 15);
            this.labelCalculatedPriceTicketOutput.TabIndex = 4;
            this.labelCalculatedPriceTicketOutput.Text = "€ 0.00";
            // 
            // CinemaTicketCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 149);
            this.Controls.Add(this.labelCalculatedPriceTicketOutput);
            this.Controls.Add(this.labelPriceTicket);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.textBoxAgeInput);
            this.Controls.Add(this.button1);
            this.Name = "CinemaTicketCalculator";
            this.Text = "Selection assignment 10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxAgeInput;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelPriceTicket;
        private System.Windows.Forms.Label labelCalculatedPriceTicketOutput;
    }
}

