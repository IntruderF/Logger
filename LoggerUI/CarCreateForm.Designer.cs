namespace LoggerUI
{
    partial class CarCreateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarCreateForm));
            this.CreateCarLabel = new System.Windows.Forms.Label();
            this.CreateCarButton = new System.Windows.Forms.Button();
            this.CarNameLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CarYearLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.FuelEconomyCityLabel = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.CarInitialMileage = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.FuelEconomyHighwayLabel = new System.Windows.Forms.Label();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.UnitsLabel = new System.Windows.Forms.Label();
            this.MileageUnitLabel = new System.Windows.Forms.Label();
            this.FuelEconomyCityUnit = new System.Windows.Forms.Label();
            this.FuelEconomyHighwayUnit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateCarLabel
            // 
            this.CreateCarLabel.AutoSize = true;
            this.CreateCarLabel.Font = new System.Drawing.Font("NewsGoth Lt BT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateCarLabel.Location = new System.Drawing.Point(12, 9);
            this.CreateCarLabel.Name = "CreateCarLabel";
            this.CreateCarLabel.Size = new System.Drawing.Size(234, 57);
            this.CreateCarLabel.TabIndex = 1;
            this.CreateCarLabel.Text = "Create Car";
            // 
            // CreateCarButton
            // 
            this.CreateCarButton.BackColor = System.Drawing.Color.White;
            this.CreateCarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateCarButton.Location = new System.Drawing.Point(174, 367);
            this.CreateCarButton.Name = "CreateCarButton";
            this.CreateCarButton.Size = new System.Drawing.Size(158, 62);
            this.CreateCarButton.TabIndex = 4;
            this.CreateCarButton.Text = "Create Car";
            this.CreateCarButton.UseVisualStyleBackColor = false;
            // 
            // CarNameLabel
            // 
            this.CarNameLabel.AutoSize = true;
            this.CarNameLabel.Location = new System.Drawing.Point(159, 97);
            this.CarNameLabel.Name = "CarNameLabel";
            this.CarNameLabel.Size = new System.Drawing.Size(77, 30);
            this.CarNameLabel.TabIndex = 5;
            this.CarNameLabel.Text = "Name";
            this.CarNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(242, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 38);
            this.textBox1.TabIndex = 6;
            // 
            // CarYearLabel
            // 
            this.CarYearLabel.AutoSize = true;
            this.CarYearLabel.Location = new System.Drawing.Point(177, 141);
            this.CarYearLabel.Name = "CarYearLabel";
            this.CarYearLabel.Size = new System.Drawing.Size(59, 30);
            this.CarYearLabel.TabIndex = 7;
            this.CarYearLabel.Text = "Year";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(242, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(242, 38);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(242, 266);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(129, 38);
            this.textBox3.TabIndex = 12;
            // 
            // FuelEconomyCityLabel
            // 
            this.FuelEconomyCityLabel.AutoSize = true;
            this.FuelEconomyCityLabel.Location = new System.Drawing.Point(64, 269);
            this.FuelEconomyCityLabel.Name = "FuelEconomyCityLabel";
            this.FuelEconomyCityLabel.Size = new System.Drawing.Size(172, 30);
            this.FuelEconomyCityLabel.TabIndex = 11;
            this.FuelEconomyCityLabel.Text = "Efficiency (city)";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(242, 222);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(190, 38);
            this.textBox4.TabIndex = 10;
            // 
            // CarInitialMileage
            // 
            this.CarInitialMileage.AutoSize = true;
            this.CarInitialMileage.Location = new System.Drawing.Point(137, 225);
            this.CarInitialMileage.Name = "CarInitialMileage";
            this.CarInitialMileage.Size = new System.Drawing.Size(99, 30);
            this.CarInitialMileage.TabIndex = 9;
            this.CarInitialMileage.Text = "Mileage";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(242, 310);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(129, 38);
            this.textBox5.TabIndex = 14;
            // 
            // FuelEconomyHighwayLabel
            // 
            this.FuelEconomyHighwayLabel.AutoSize = true;
            this.FuelEconomyHighwayLabel.Location = new System.Drawing.Point(12, 313);
            this.FuelEconomyHighwayLabel.Name = "FuelEconomyHighwayLabel";
            this.FuelEconomyHighwayLabel.Size = new System.Drawing.Size(224, 30);
            this.FuelEconomyHighwayLabel.TabIndex = 13;
            this.FuelEconomyHighwayLabel.Text = "Efficiency (highway)";
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Location = new System.Drawing.Point(242, 182);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(99, 34);
            this.MetricRadioButton.TabIndex = 15;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            this.MetricRadioButton.CheckedChanged += new System.EventHandler(this.MetricRadioButton_CheckedChanged);
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Location = new System.Drawing.Point(367, 182);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(117, 34);
            this.ImperialRadioButton.TabIndex = 16;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            // 
            // UnitsLabel
            // 
            this.UnitsLabel.AutoSize = true;
            this.UnitsLabel.Location = new System.Drawing.Point(169, 184);
            this.UnitsLabel.Name = "UnitsLabel";
            this.UnitsLabel.Size = new System.Drawing.Size(67, 30);
            this.UnitsLabel.TabIndex = 17;
            this.UnitsLabel.Text = "Units";
            // 
            // MileageUnitLabel
            // 
            this.MileageUnitLabel.AutoSize = true;
            this.MileageUnitLabel.Location = new System.Drawing.Point(438, 225);
            this.MileageUnitLabel.Name = "MileageUnitLabel";
            this.MileageUnitLabel.Size = new System.Drawing.Size(46, 30);
            this.MileageUnitLabel.TabIndex = 18;
            this.MileageUnitLabel.Text = "km";
            // 
            // FuelEconomyCityUnit
            // 
            this.FuelEconomyCityUnit.AutoSize = true;
            this.FuelEconomyCityUnit.Location = new System.Drawing.Point(377, 269);
            this.FuelEconomyCityUnit.Name = "FuelEconomyCityUnit";
            this.FuelEconomyCityUnit.Size = new System.Drawing.Size(107, 30);
            this.FuelEconomyCityUnit.TabIndex = 19;
            this.FuelEconomyCityUnit.Text = "l/100 km";
            // 
            // FuelEconomyHighwayUnit
            // 
            this.FuelEconomyHighwayUnit.AutoSize = true;
            this.FuelEconomyHighwayUnit.Location = new System.Drawing.Point(377, 313);
            this.FuelEconomyHighwayUnit.Name = "FuelEconomyHighwayUnit";
            this.FuelEconomyHighwayUnit.Size = new System.Drawing.Size(107, 30);
            this.FuelEconomyHighwayUnit.TabIndex = 20;
            this.FuelEconomyHighwayUnit.Text = "l/100 km";
            // 
            // CarCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(497, 441);
            this.Controls.Add(this.FuelEconomyHighwayUnit);
            this.Controls.Add(this.FuelEconomyCityUnit);
            this.Controls.Add(this.MileageUnitLabel);
            this.Controls.Add(this.UnitsLabel);
            this.Controls.Add(this.ImperialRadioButton);
            this.Controls.Add(this.MetricRadioButton);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.FuelEconomyHighwayLabel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.FuelEconomyCityLabel);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.CarInitialMileage);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.CarYearLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CarNameLabel);
            this.Controls.Add(this.CreateCarButton);
            this.Controls.Add(this.CreateCarLabel);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "CarCreateForm";
            this.Text = "Create Car";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreateCarLabel;
        private System.Windows.Forms.Button CreateCarButton;
        private System.Windows.Forms.Label CarNameLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label CarYearLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label FuelEconomyCityLabel;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label CarInitialMileage;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label FuelEconomyHighwayLabel;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.Label UnitsLabel;
        private System.Windows.Forms.Label MileageUnitLabel;
        private System.Windows.Forms.Label FuelEconomyCityUnit;
        private System.Windows.Forms.Label FuelEconomyHighwayUnit;
    }
}