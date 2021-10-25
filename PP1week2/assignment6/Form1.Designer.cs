
namespace assingment6
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
            this.buttonToCalculateTime = new System.Windows.Forms.Button();
            this.textBoxInputTimeInSeconds = new System.Windows.Forms.TextBox();
            this.labelAskInputSeconds = new System.Windows.Forms.Label();
            this.labelTimeFormatDescription = new System.Windows.Forms.Label();
            this.labelOutputOfTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonToCalculateTime
            // 
            this.buttonToCalculateTime.Location = new System.Drawing.Point(12, 62);
            this.buttonToCalculateTime.Name = "buttonToCalculateTime";
            this.buttonToCalculateTime.Size = new System.Drawing.Size(267, 22);
            this.buttonToCalculateTime.TabIndex = 0;
            this.buttonToCalculateTime.Text = "Calculate time";
            this.buttonToCalculateTime.UseVisualStyleBackColor = true;
            this.buttonToCalculateTime.Click += new System.EventHandler(this.buttonToCalculateTime_Click);
            // 
            // textBoxInputTimeInSeconds
            // 
            this.textBoxInputTimeInSeconds.Location = new System.Drawing.Point(147, 24);
            this.textBoxInputTimeInSeconds.Name = "textBoxInputTimeInSeconds";
            this.textBoxInputTimeInSeconds.Size = new System.Drawing.Size(132, 23);
            this.textBoxInputTimeInSeconds.TabIndex = 1;
            // 
            // labelAskInputSeconds
            // 
            this.labelAskInputSeconds.AutoSize = true;
            this.labelAskInputSeconds.Location = new System.Drawing.Point(12, 27);
            this.labelAskInputSeconds.Name = "labelAskInputSeconds";
            this.labelAskInputSeconds.Size = new System.Drawing.Size(54, 15);
            this.labelAskInputSeconds.TabIndex = 2;
            this.labelAskInputSeconds.Text = "Seconds:";
            // 
            // labelTimeFormatDescription
            // 
            this.labelTimeFormatDescription.AutoSize = true;
            this.labelTimeFormatDescription.Location = new System.Drawing.Point(12, 108);
            this.labelTimeFormatDescription.Name = "labelTimeFormatDescription";
            this.labelTimeFormatDescription.Size = new System.Drawing.Size(141, 15);
            this.labelTimeFormatDescription.TabIndex = 3;
            this.labelTimeFormatDescription.Text = "hours : minutes : seconds";
            // 
            // labelOutputOfTime
            // 
            this.labelOutputOfTime.AutoSize = true;
            this.labelOutputOfTime.Location = new System.Drawing.Point(17, 132);
            this.labelOutputOfTime.Name = "labelOutputOfTime";
            this.labelOutputOfTime.Size = new System.Drawing.Size(49, 15);
            this.labelOutputOfTime.TabIndex = 4;
            this.labelOutputOfTime.Text = "00:00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 177);
            this.Controls.Add(this.labelOutputOfTime);
            this.Controls.Add(this.labelTimeFormatDescription);
            this.Controls.Add(this.labelAskInputSeconds);
            this.Controls.Add(this.textBoxInputTimeInSeconds);
            this.Controls.Add(this.buttonToCalculateTime);
            this.Name = "Form1";
            this.Text = "Sequence - assingment 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonToCalculateTime;
        private System.Windows.Forms.TextBox textBoxInputTimeInSeconds;
        private System.Windows.Forms.Label labelAskInputSeconds;
        private System.Windows.Forms.Label labelTimeFormatDescription;
        private System.Windows.Forms.Label labelOutputOfTime;
    }
}

