using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoggerUI
{
    public partial class CarCreateForm : Form
    {
        public CarCreateForm()
        {
            InitializeComponent();

            MetricRadioButton.Checked = true;
        }

        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MileageUnitLabel.Text = "km";
            FuelEconomyCityUnit.Text = "l/100 km";
            FuelEconomyHighwayUnit.Text = "l/100 km";
        }

        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MileageUnitLabel.Text = "m";
            FuelEconomyCityUnit.Text = "gal/100 m";
            FuelEconomyHighwayUnit.Text = "gal/100 m";
        }
    }
}
