using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BMICalculator
{
    public partial class MainForm : Form
    {
        private string name = string.Empty;
        private BMICalculator bmiCalc = new BMICalculator();
        public MainForm()
        {
            InitializeComponent();

            InitializeGUI();
        }
        private void InitializeGUI()
        {
            this.Text += " John's calculator";

            lblBMI.Text = String.Empty;
            lblWeightCat.Text = String.Empty;
            lblNormalBMI.Text = "Normal weight";
            rbtnMetric.Checked = true;
            lblNormalBMI.Text = "Normal BMI is between 18.50 to 24.9";
        }

        private void UpdateHeightText()
        {
            if (rbtnMetric.Checked)
            {
                lblHeight.Text = "Height (cm)";
                lblWeight.Text = "Weight (kg)";
                txtInch.Visible = false; //Hide Inches if Metric selected
            }
            else
            {
                lblHeight.Text = "Height (ft, in)";
                lblWeight.Text = "Weight (lbs)";
                txtInch.Visible = true; //Show Inches if Imperial/US Selected
            }
            lblWeightCat.Text = ""; //Clear after use
            lblBMI.Text = ""; //Clear after use
        }
        private void rbtnMetric_CheckedChanged(object sender, EventArgs e)
        {
            UpdateHeightText();
            txtCmFt.Clear();
            txtInch.Clear();
            txtWeight.Clear();
        }

        private void rbtnUS_CheckedChanged(object sender, EventArgs e)
        {
            UpdateHeightText();
            txtCmFt.Clear();
            txtInch.Clear();
            txtWeight.Clear();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //1: Read input
            bool ok = ReadInputBMI();

            //2: Calculate input
            if (ok)
            {
                CalculateAndDisplayResults();
            }
            //3: Print Output
        }
        private void CalculateAndDisplayResults()
        {
            double bmi = bmiCalc.CalculateBMI();
            lblBMI.Text = bmi.ToString("f2");  //convert value to string and show 2 decimals
            lblWeightCat.Text = bmiCalc.BMIweightCategory().ToString();
            grpResults.Text = "Results for: " + name; //Change name group box to name input by user
        }
        private bool ReadInputBMI() 
        {
            ReadName();
            bool heightOK = ReadHeight(); //Read if Height value is valid
            bool weightOK = ReadWeight(); //Read if Weight value is valid
            ReadUnit();

            return heightOK && weightOK; //Returns if both values are true
        }
        private void ReadName()
        {
            name = txtName.Text;
            name = name.Trim(); //Remove spaces
        }

        private void ReadUnit()
        {
            if (rbtnMetric.Checked)
                bmiCalc.SetUnitType(UnitTypes.Metric);
            else
                bmiCalc.SetUnitType(UnitTypes.Imperial);
        }

        private bool ReadHeight()
        {
            double height = 0.0;
            
            //Convert string to number (Try Parse)
            //Height Metric
            bool ok = double.TryParse(txtCmFt.Text, out height);
            if (!ok) //If false
            {
                MessageBox.Show("Height value is invalid", "Error"); //Error message
            }
            //Height Imperial/US
            double inch = 0.0;
            if (rbtnUS.Checked)
            {
                ok = ok && double.TryParse(txtInch.Text, out inch);
                if (!ok) //If false
                {
                    MessageBox.Show("Height value (inch) is invalid", "Error"); //Error message
                }
            }

            // cm converted to m, ft  converted to inch.
            if (bmiCalc.GetUnitType() == UnitTypes.Metric)
                height = height / 100.0; //cm to meter
            else
                height = height * 12.0 + inch; //ft to inch

            bmiCalc.SetHeight(height);
            return ok;
        }
        private bool ReadWeight()
        {
            double weight = 0.0;
            //Convert string to number (Try Parse)
            //Weight
            bool ok = double.TryParse(txtWeight.Text, out weight);
            if (!ok) //false
            {
                MessageBox.Show("Weight value is invalid", "Error");
            }

            bmiCalc.SetWeight(weight);

            return ok;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CenterToScreen(); //Display window in center of screen
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
