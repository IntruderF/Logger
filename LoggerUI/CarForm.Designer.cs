namespace LoggerUI
{
    partial class CarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarForm));
            this.CarNameLabel = new System.Windows.Forms.Label();
            this.TripListBox = new System.Windows.Forms.ListBox();
            this.CarInfoButton = new System.Windows.Forms.Button();
            this.RemoveTripButton = new System.Windows.Forms.Button();
            this.AddTripButton = new System.Windows.Forms.Button();
            this.CarBasicInfoLabel = new System.Windows.Forms.Label();
            this.LatestTripsLabel = new System.Windows.Forms.Label();
            this.WeekLabel = new System.Windows.Forms.Label();
            this.MonthLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.FuelLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CarNameLabel
            // 
            this.CarNameLabel.AutoSize = true;
            this.CarNameLabel.Font = new System.Drawing.Font("NewsGoth Lt BT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarNameLabel.Location = new System.Drawing.Point(16, 9);
            this.CarNameLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.CarNameLabel.Name = "CarNameLabel";
            this.CarNameLabel.Size = new System.Drawing.Size(308, 57);
            this.CarNameLabel.TabIndex = 1;
            this.CarNameLabel.Text = "<Car Name>";
            // 
            // TripListBox
            // 
            this.TripListBox.FormattingEnabled = true;
            this.TripListBox.ItemHeight = 30;
            this.TripListBox.Location = new System.Drawing.Point(181, 163);
            this.TripListBox.Margin = new System.Windows.Forms.Padding(7);
            this.TripListBox.Name = "TripListBox";
            this.TripListBox.Size = new System.Drawing.Size(325, 214);
            this.TripListBox.TabIndex = 3;
            // 
            // CarInfoButton
            // 
            this.CarInfoButton.BackColor = System.Drawing.Color.White;
            this.CarInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CarInfoButton.Location = new System.Drawing.Point(13, 163);
            this.CarInfoButton.Name = "CarInfoButton";
            this.CarInfoButton.Size = new System.Drawing.Size(158, 62);
            this.CarInfoButton.TabIndex = 7;
            this.CarInfoButton.Text = "Car Info";
            this.CarInfoButton.UseVisualStyleBackColor = false;
            // 
            // RemoveTripButton
            // 
            this.RemoveTripButton.BackColor = System.Drawing.Color.White;
            this.RemoveTripButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveTripButton.Location = new System.Drawing.Point(13, 299);
            this.RemoveTripButton.Name = "RemoveTripButton";
            this.RemoveTripButton.Size = new System.Drawing.Size(158, 62);
            this.RemoveTripButton.TabIndex = 6;
            this.RemoveTripButton.Text = "Remove Trip";
            this.RemoveTripButton.UseVisualStyleBackColor = false;
            // 
            // AddTripButton
            // 
            this.AddTripButton.BackColor = System.Drawing.Color.White;
            this.AddTripButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTripButton.Location = new System.Drawing.Point(13, 231);
            this.AddTripButton.Name = "AddTripButton";
            this.AddTripButton.Size = new System.Drawing.Size(158, 62);
            this.AddTripButton.TabIndex = 5;
            this.AddTripButton.Text = "Add Trip";
            this.AddTripButton.UseVisualStyleBackColor = false;
            // 
            // CarBasicInfoLabel
            // 
            this.CarBasicInfoLabel.AutoSize = true;
            this.CarBasicInfoLabel.Font = new System.Drawing.Font("NewsGoth Lt BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarBasicInfoLabel.Location = new System.Drawing.Point(16, 66);
            this.CarBasicInfoLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.CarBasicInfoLabel.Name = "CarBasicInfoLabel";
            this.CarBasicInfoLabel.Size = new System.Drawing.Size(259, 39);
            this.CarBasicInfoLabel.TabIndex = 8;
            this.CarBasicInfoLabel.Text = "<Car Basic Info>";
            // 
            // LatestTripsLabel
            // 
            this.LatestTripsLabel.AutoSize = true;
            this.LatestTripsLabel.Font = new System.Drawing.Font("NewsGoth Lt BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LatestTripsLabel.Location = new System.Drawing.Point(174, 117);
            this.LatestTripsLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LatestTripsLabel.Name = "LatestTripsLabel";
            this.LatestTripsLabel.Size = new System.Drawing.Size(172, 39);
            this.LatestTripsLabel.TabIndex = 9;
            this.LatestTripsLabel.Text = "Latest Trips";
            // 
            // WeekLabel
            // 
            this.WeekLabel.AutoSize = true;
            this.WeekLabel.Font = new System.Drawing.Font("NewsGoth Lt BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekLabel.Location = new System.Drawing.Point(266, 384);
            this.WeekLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.WeekLabel.Name = "WeekLabel";
            this.WeekLabel.Size = new System.Drawing.Size(68, 29);
            this.WeekLabel.TabIndex = 12;
            this.WeekLabel.Text = "Week";
            // 
            // MonthLabel
            // 
            this.MonthLabel.AutoSize = true;
            this.MonthLabel.Font = new System.Drawing.Font("NewsGoth Lt BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthLabel.Location = new System.Drawing.Point(348, 384);
            this.MonthLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Size = new System.Drawing.Size(78, 29);
            this.MonthLabel.TabIndex = 13;
            this.MonthLabel.Text = "Month";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Font = new System.Drawing.Font("NewsGoth Lt BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLabel.Location = new System.Drawing.Point(440, 384);
            this.YearLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(56, 29);
            this.YearLabel.TabIndex = 14;
            this.YearLabel.Text = "Year";
            // 
            // DistanceLabel
            // 
            this.DistanceLabel.AutoSize = true;
            this.DistanceLabel.Font = new System.Drawing.Font("NewsGoth Lt BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DistanceLabel.Location = new System.Drawing.Point(194, 416);
            this.DistanceLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(59, 29);
            this.DistanceLabel.TabIndex = 15;
            this.DistanceLabel.Text = "Dist.";
            // 
            // FuelLabel
            // 
            this.FuelLabel.AutoSize = true;
            this.FuelLabel.Font = new System.Drawing.Font("NewsGoth Lt BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuelLabel.Location = new System.Drawing.Point(194, 445);
            this.FuelLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.FuelLabel.Name = "FuelLabel";
            this.FuelLabel.Size = new System.Drawing.Size(56, 29);
            this.FuelLabel.TabIndex = 16;
            this.FuelLabel.Text = "Fuel";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("NewsGoth Lt BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLabel.Location = new System.Drawing.Point(194, 474);
            this.CostLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(56, 29);
            this.CostLabel.TabIndex = 17;
            this.CostLabel.Text = "Cost";
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(521, 524);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.FuelLabel);
            this.Controls.Add(this.DistanceLabel);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.MonthLabel);
            this.Controls.Add(this.WeekLabel);
            this.Controls.Add(this.LatestTripsLabel);
            this.Controls.Add(this.CarBasicInfoLabel);
            this.Controls.Add(this.CarInfoButton);
            this.Controls.Add(this.RemoveTripButton);
            this.Controls.Add(this.AddTripButton);
            this.Controls.Add(this.TripListBox);
            this.Controls.Add(this.CarNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "CarForm";
            this.Text = "Car";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CarNameLabel;
        private System.Windows.Forms.ListBox TripListBox;
        private System.Windows.Forms.Button CarInfoButton;
        private System.Windows.Forms.Button RemoveTripButton;
        private System.Windows.Forms.Button AddTripButton;
        private System.Windows.Forms.Label CarBasicInfoLabel;
        private System.Windows.Forms.Label LatestTripsLabel;
        private System.Windows.Forms.Label WeekLabel;
        private System.Windows.Forms.Label MonthLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label DistanceLabel;
        private System.Windows.Forms.Label FuelLabel;
        private System.Windows.Forms.Label CostLabel;
    }
}