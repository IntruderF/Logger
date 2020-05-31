namespace LoggerUI
{
    partial class CarSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarSelection));
            this.CarSelectionLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LoadCarButton = new System.Windows.Forms.Button();
            this.CreateCarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CarSelectionLabel
            // 
            this.CarSelectionLabel.AutoSize = true;
            this.CarSelectionLabel.Font = new System.Drawing.Font("NewsGoth Lt BT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarSelectionLabel.Location = new System.Drawing.Point(12, 9);
            this.CarSelectionLabel.Name = "CarSelectionLabel";
            this.CarSelectionLabel.Size = new System.Drawing.Size(287, 57);
            this.CarSelectionLabel.TabIndex = 0;
            this.CarSelectionLabel.Text = "Car Selection";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(109, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(360, 38);
            this.comboBox1.TabIndex = 1;
            // 
            // LoadCarButton
            // 
            this.LoadCarButton.BackColor = System.Drawing.Color.White;
            this.LoadCarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadCarButton.Location = new System.Drawing.Point(210, 194);
            this.LoadCarButton.Name = "LoadCarButton";
            this.LoadCarButton.Size = new System.Drawing.Size(158, 62);
            this.LoadCarButton.TabIndex = 2;
            this.LoadCarButton.Text = "Load Car";
            this.LoadCarButton.UseVisualStyleBackColor = false;
            // 
            // CreateCarButton
            // 
            this.CreateCarButton.BackColor = System.Drawing.Color.White;
            this.CreateCarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateCarButton.Location = new System.Drawing.Point(210, 262);
            this.CreateCarButton.Name = "CreateCarButton";
            this.CreateCarButton.Size = new System.Drawing.Size(158, 62);
            this.CreateCarButton.TabIndex = 3;
            this.CreateCarButton.Text = "Create Car";
            this.CreateCarButton.UseVisualStyleBackColor = false;
            // 
            // CarSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CreateCarButton);
            this.Controls.Add(this.LoadCarButton);
            this.Controls.Add(this.CarSelectionLabel);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "CarSelection";
            this.Text = "CarSelection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CarSelectionLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button LoadCarButton;
        private System.Windows.Forms.Button CreateCarButton;
    }
}