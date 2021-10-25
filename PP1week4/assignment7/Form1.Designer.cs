
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
            this.textBoxSideInput = new System.Windows.Forms.TextBox();
            this.labelSide = new System.Windows.Forms.Label();
            this.labelResultSquare = new System.Windows.Forms.Label();
            this.buttonCreateSquare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSideInput
            // 
            this.textBoxSideInput.Location = new System.Drawing.Point(330, 54);
            this.textBoxSideInput.Name = "textBoxSideInput";
            this.textBoxSideInput.Size = new System.Drawing.Size(100, 23);
            this.textBoxSideInput.TabIndex = 0;
            // 
            // labelSide
            // 
            this.labelSide.AutoSize = true;
            this.labelSide.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSide.Location = new System.Drawing.Point(22, 49);
            this.labelSide.Name = "labelSide";
            this.labelSide.Size = new System.Drawing.Size(48, 25);
            this.labelSide.TabIndex = 1;
            this.labelSide.Text = "Side";
            // 
            // labelResultSquare
            // 
            this.labelResultSquare.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelResultSquare.Location = new System.Drawing.Point(22, 177);
            this.labelResultSquare.Name = "labelResultSquare";
            this.labelResultSquare.Size = new System.Drawing.Size(408, 345);
            this.labelResultSquare.TabIndex = 2;
            this.labelResultSquare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCreateSquare
            // 
            this.buttonCreateSquare.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCreateSquare.Location = new System.Drawing.Point(22, 102);
            this.buttonCreateSquare.Name = "buttonCreateSquare";
            this.buttonCreateSquare.Size = new System.Drawing.Size(408, 44);
            this.buttonCreateSquare.TabIndex = 3;
            this.buttonCreateSquare.Text = "Create square";
            this.buttonCreateSquare.UseVisualStyleBackColor = true;
            // 
            // Patternmaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 550);
            this.Controls.Add(this.buttonCreateSquare);
            this.Controls.Add(this.labelResultSquare);
            this.Controls.Add(this.labelSide);
            this.Controls.Add(this.textBoxSideInput);
            this.Name = "Patternmaker";
            this.Text = "Iteration assignment 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSideInput;
        private System.Windows.Forms.Label labelSide;
        private System.Windows.Forms.Label labelResultSquare;
        private System.Windows.Forms.Button buttonCreateSquare;
    }
}

