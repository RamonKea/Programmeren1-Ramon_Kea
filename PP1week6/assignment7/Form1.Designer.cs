
namespace assignment7
{
    partial class TemperatureConverter
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
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelConvertedDegrees = new System.Windows.Forms.Label();
            this.labelConvertedDegreesOutput = new System.Windows.Forms.Label();
            this.labelDegrees = new System.Windows.Forms.Label();
            this.labelConversion = new System.Windows.Forms.Label();
            this.radioButtonCelsiusToKelvin = new System.Windows.Forms.RadioButton();
            this.radioButtonCelsiusToFahrenheit = new System.Windows.Forms.RadioButton();
            this.radioButtonFahrenheitToCelsius = new System.Windows.Forms.RadioButton();
            this.textBoxDegreesInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCalculate.Location = new System.Drawing.Point(12, 188);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(240, 40);
            this.buttonCalculate.TabIndex = 0;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelConvertedDegrees
            // 
            this.labelConvertedDegrees.AutoSize = true;
            this.labelConvertedDegrees.Location = new System.Drawing.Point(12, 240);
            this.labelConvertedDegrees.Name = "labelConvertedDegrees";
            this.labelConvertedDegrees.Size = new System.Drawing.Size(106, 15);
            this.labelConvertedDegrees.TabIndex = 1;
            this.labelConvertedDegrees.Text = "Converted degrees";
            // 
            // labelConvertedDegreesOutput
            // 
            this.labelConvertedDegreesOutput.AutoSize = true;
            this.labelConvertedDegreesOutput.Location = new System.Drawing.Point(155, 240);
            this.labelConvertedDegreesOutput.Name = "labelConvertedDegreesOutput";
            this.labelConvertedDegreesOutput.Size = new System.Drawing.Size(28, 15);
            this.labelConvertedDegreesOutput.TabIndex = 2;
            this.labelConvertedDegreesOutput.Text = "0.00";
            // 
            // labelDegrees
            // 
            this.labelDegrees.AutoSize = true;
            this.labelDegrees.Location = new System.Drawing.Point(12, 25);
            this.labelDegrees.Name = "labelDegrees";
            this.labelDegrees.Size = new System.Drawing.Size(49, 15);
            this.labelDegrees.TabIndex = 3;
            this.labelDegrees.Text = "Degrees";
            // 
            // labelConversion
            // 
            this.labelConversion.AutoSize = true;
            this.labelConversion.Location = new System.Drawing.Point(23, 64);
            this.labelConversion.Name = "labelConversion";
            this.labelConversion.Size = new System.Drawing.Size(67, 15);
            this.labelConversion.TabIndex = 4;
            this.labelConversion.Text = "Conversion";
            // 
            // radioButtonCelsiusToKelvin
            // 
            this.radioButtonCelsiusToKelvin.AutoSize = true;
            this.radioButtonCelsiusToKelvin.Location = new System.Drawing.Point(34, 82);
            this.radioButtonCelsiusToKelvin.Name = "radioButtonCelsiusToKelvin";
            this.radioButtonCelsiusToKelvin.Size = new System.Drawing.Size(111, 19);
            this.radioButtonCelsiusToKelvin.TabIndex = 5;
            this.radioButtonCelsiusToKelvin.TabStop = true;
            this.radioButtonCelsiusToKelvin.Text = "Celsius to Kelvin";
            this.radioButtonCelsiusToKelvin.UseVisualStyleBackColor = true;
            // 
            // radioButtonCelsiusToFahrenheit
            // 
            this.radioButtonCelsiusToFahrenheit.AutoSize = true;
            this.radioButtonCelsiusToFahrenheit.Location = new System.Drawing.Point(34, 107);
            this.radioButtonCelsiusToFahrenheit.Name = "radioButtonCelsiusToFahrenheit";
            this.radioButtonCelsiusToFahrenheit.Size = new System.Drawing.Size(135, 19);
            this.radioButtonCelsiusToFahrenheit.TabIndex = 6;
            this.radioButtonCelsiusToFahrenheit.TabStop = true;
            this.radioButtonCelsiusToFahrenheit.Text = "Celsius to Fahrenheit";
            this.radioButtonCelsiusToFahrenheit.UseVisualStyleBackColor = true;
            // 
            // radioButtonFahrenheitToCelsius
            // 
            this.radioButtonFahrenheitToCelsius.AutoSize = true;
            this.radioButtonFahrenheitToCelsius.Location = new System.Drawing.Point(34, 132);
            this.radioButtonFahrenheitToCelsius.Name = "radioButtonFahrenheitToCelsius";
            this.radioButtonFahrenheitToCelsius.Size = new System.Drawing.Size(135, 19);
            this.radioButtonFahrenheitToCelsius.TabIndex = 7;
            this.radioButtonFahrenheitToCelsius.TabStop = true;
            this.radioButtonFahrenheitToCelsius.Text = "Fahrenheit to Celsius";
            this.radioButtonFahrenheitToCelsius.UseVisualStyleBackColor = true;
            // 
            // textBoxDegreesInput
            // 
            this.textBoxDegreesInput.Location = new System.Drawing.Point(155, 25);
            this.textBoxDegreesInput.Name = "textBoxDegreesInput";
            this.textBoxDegreesInput.Size = new System.Drawing.Size(100, 23);
            this.textBoxDegreesInput.TabIndex = 8;
            // 
            // TemperatureConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 264);
            this.Controls.Add(this.textBoxDegreesInput);
            this.Controls.Add(this.radioButtonFahrenheitToCelsius);
            this.Controls.Add(this.radioButtonCelsiusToFahrenheit);
            this.Controls.Add(this.radioButtonCelsiusToKelvin);
            this.Controls.Add(this.labelConversion);
            this.Controls.Add(this.labelDegrees);
            this.Controls.Add(this.labelConvertedDegreesOutput);
            this.Controls.Add(this.labelConvertedDegrees);
            this.Controls.Add(this.buttonCalculate);
            this.Name = "TemperatureConverter";
            this.Text = "Methods assignment 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelConvertedDegrees;
        private System.Windows.Forms.Label labelConvertedDegreesOutput;
        private System.Windows.Forms.Label labelDegrees;
        private System.Windows.Forms.Label labelConversion;
        private System.Windows.Forms.RadioButton radioButtonCelsiusToKelvin;
        private System.Windows.Forms.RadioButton radioButtonCelsiusToFahrenheit;
        private System.Windows.Forms.RadioButton radioButtonFahrenheitToCelsius;
        private System.Windows.Forms.TextBox textBoxDegreesInput;
    }
}

