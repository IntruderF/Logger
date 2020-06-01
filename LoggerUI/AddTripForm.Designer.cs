namespace LoggerUI
{
    partial class AddTripForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTripForm));
            this.AddTrip = new System.Windows.Forms.Label();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TripDistance = new System.Windows.Forms.Label();
            this.TripDate = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.AdditionalInfoLabel = new System.Windows.Forms.Label();
            this.TripDistanceUnit = new System.Windows.Forms.Label();
            this.CityRadioButton = new System.Windows.Forms.RadioButton();
            this.FuelPrice = new System.Windows.Forms.Label();
            this.EfficiencyLabel = new System.Windows.Forms.Label();
            this.HighwayRadioButton = new System.Windows.Forms.RadioButton();
            this.CombinedRadioButton = new System.Windows.Forms.RadioButton();
            this.AddTripButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddTrip
            // 
            this.AddTrip.AutoSize = true;
            this.AddTrip.Font = new System.Drawing.Font("NewsGoth Lt BT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTrip.Location = new System.Drawing.Point(16, 9);
            this.AddTrip.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.AddTrip.Name = "AddTrip";
            this.AddTrip.Size = new System.Drawing.Size(196, 57);
            this.AddTrip.TabIndex = 2;
            this.AddTrip.Text = "Add Trip";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker.Location = new System.Drawing.Point(189, 83);
            this.DateTimePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(152, 38);
            this.DateTimePicker.TabIndex = 3;
            this.DateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(189, 127);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 38);
            this.textBox2.TabIndex = 12;
            // 
            // TripDistance
            // 
            this.TripDistance.AutoSize = true;
            this.TripDistance.Location = new System.Drawing.Point(79, 130);
            this.TripDistance.Name = "TripDistance";
            this.TripDistance.Size = new System.Drawing.Size(104, 30);
            this.TripDistance.TabIndex = 11;
            this.TripDistance.Text = "Distance";
            // 
            // TripDate
            // 
            this.TripDate.AutoSize = true;
            this.TripDate.Location = new System.Drawing.Point(120, 89);
            this.TripDate.Name = "TripDate";
            this.TripDate.Size = new System.Drawing.Size(63, 30);
            this.TripDate.TabIndex = 9;
            this.TripDate.Text = "Date";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(189, 171);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(152, 38);
            this.textBox3.TabIndex = 13;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(189, 335);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(152, 62);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // AdditionalInfoLabel
            // 
            this.AdditionalInfoLabel.AutoSize = true;
            this.AdditionalInfoLabel.Location = new System.Drawing.Point(12, 351);
            this.AdditionalInfoLabel.Name = "AdditionalInfoLabel";
            this.AdditionalInfoLabel.Size = new System.Drawing.Size(171, 30);
            this.AdditionalInfoLabel.TabIndex = 15;
            this.AdditionalInfoLabel.Text = "Additional Info";
            // 
            // TripDistanceUnit
            // 
            this.TripDistanceUnit.AutoSize = true;
            this.TripDistanceUnit.Location = new System.Drawing.Point(347, 130);
            this.TripDistanceUnit.Name = "TripDistanceUnit";
            this.TripDistanceUnit.Size = new System.Drawing.Size(46, 30);
            this.TripDistanceUnit.TabIndex = 16;
            this.TripDistanceUnit.Text = "km";
            // 
            // CityRadioButton
            // 
            this.CityRadioButton.AutoSize = true;
            this.CityRadioButton.Location = new System.Drawing.Point(189, 215);
            this.CityRadioButton.Name = "CityRadioButton";
            this.CityRadioButton.Size = new System.Drawing.Size(72, 34);
            this.CityRadioButton.TabIndex = 17;
            this.CityRadioButton.TabStop = true;
            this.CityRadioButton.Text = "City";
            this.CityRadioButton.UseVisualStyleBackColor = true;
            // 
            // FuelPrice
            // 
            this.FuelPrice.AutoSize = true;
            this.FuelPrice.Location = new System.Drawing.Point(67, 174);
            this.FuelPrice.Name = "FuelPrice";
            this.FuelPrice.Size = new System.Drawing.Size(116, 30);
            this.FuelPrice.TabIndex = 18;
            this.FuelPrice.Text = "Fuel Price";
            // 
            // EfficiencyLabel
            // 
            this.EfficiencyLabel.AutoSize = true;
            this.EfficiencyLabel.Location = new System.Drawing.Point(69, 217);
            this.EfficiencyLabel.Name = "EfficiencyLabel";
            this.EfficiencyLabel.Size = new System.Drawing.Size(114, 30);
            this.EfficiencyLabel.TabIndex = 19;
            this.EfficiencyLabel.Text = "Efficiency";
            // 
            // HighwayRadioButton
            // 
            this.HighwayRadioButton.AutoSize = true;
            this.HighwayRadioButton.Location = new System.Drawing.Point(189, 255);
            this.HighwayRadioButton.Name = "HighwayRadioButton";
            this.HighwayRadioButton.Size = new System.Drawing.Size(123, 34);
            this.HighwayRadioButton.TabIndex = 20;
            this.HighwayRadioButton.TabStop = true;
            this.HighwayRadioButton.Text = "Highway";
            this.HighwayRadioButton.UseVisualStyleBackColor = true;
            // 
            // CombinedRadioButton
            // 
            this.CombinedRadioButton.AutoSize = true;
            this.CombinedRadioButton.Location = new System.Drawing.Point(189, 295);
            this.CombinedRadioButton.Name = "CombinedRadioButton";
            this.CombinedRadioButton.Size = new System.Drawing.Size(142, 34);
            this.CombinedRadioButton.TabIndex = 21;
            this.CombinedRadioButton.TabStop = true;
            this.CombinedRadioButton.Text = "Combined";
            this.CombinedRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddTripButton
            // 
            this.AddTripButton.BackColor = System.Drawing.Color.White;
            this.AddTripButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTripButton.Location = new System.Drawing.Point(125, 413);
            this.AddTripButton.Name = "AddTripButton";
            this.AddTripButton.Size = new System.Drawing.Size(158, 62);
            this.AddTripButton.TabIndex = 22;
            this.AddTripButton.Text = "Add Trip";
            this.AddTripButton.UseVisualStyleBackColor = false;
            // 
            // AddTripForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(398, 486);
            this.Controls.Add(this.AddTripButton);
            this.Controls.Add(this.CombinedRadioButton);
            this.Controls.Add(this.HighwayRadioButton);
            this.Controls.Add(this.EfficiencyLabel);
            this.Controls.Add(this.FuelPrice);
            this.Controls.Add(this.CityRadioButton);
            this.Controls.Add(this.TripDistanceUnit);
            this.Controls.Add(this.AdditionalInfoLabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TripDistance);
            this.Controls.Add(this.TripDate);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.AddTrip);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "AddTripForm";
            this.Text = "Add Trip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddTrip;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label TripDistance;
        private System.Windows.Forms.Label TripDate;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label AdditionalInfoLabel;
        private System.Windows.Forms.Label TripDistanceUnit;
        private System.Windows.Forms.RadioButton CityRadioButton;
        private System.Windows.Forms.Label FuelPrice;
        private System.Windows.Forms.Label EfficiencyLabel;
        private System.Windows.Forms.RadioButton HighwayRadioButton;
        private System.Windows.Forms.RadioButton CombinedRadioButton;
        private System.Windows.Forms.Button AddTripButton;
    }
}