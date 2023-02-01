using System;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class MainForm : Form
    {

        private BMICalculator BMICalculator = new BMICalculator(); //Initialize BMI Calculator
        private SavingCalculator SavingCalculator = new SavingCalculator(); // Initialize Saving Calculator
        public MainForm()
        {
            InitializeComponent();
            InitializeGui();
        }


        private void InitializeGui() //Setting all the default values of the visual elements
        {
            this.Text = "Super Calculator by Christopher";
            BMICalc.Text = "BMI Calculator";
            Unit.Text = "Unit";
            Imperial.Checked = true;
            SavingPlan.Text = "Saving plan";
            groupBox5.Text = "Future value";
            NameDisplay.Text = "Name";
            BMI.Text = "BMI";
            WeightCategory.Text = "Weight category";
            AmountPaid.Text = "Amount paid";
            FinalBalance.Text = "Final balance";
            MonthlyDep.Text = "Monthly deposit";
            Period.Text = "Period (years)";
            Metric.Text = "Metric (kg, cm)";
            Imperial.Text = "Imperial (ft, lbs)";
            CalculateBMI.Text = "Calculate BMI";
            groupBox3.Text = "Results for " + BMICalculator.GetName();
            CalculateSaving.Text = "Calculate saving";

        }

        private void ReadName() //Method to read the name of the user
        {
            NameInput.Text.Trim();
            if (!string.IsNullOrEmpty(NameInput.Text))
            {
                BMICalculator.SetName(NameInput.Text);
            }
        }

        private bool ReadHeight() //Method to read the height of the user
        {
            if (BMICalculator.getUnitType().ToString() == "Metric") // If the unittype is metric we should only show one box, if it is imperial we sohuld show two boxes
            {
                double outValue = 0;
                bool ok1 = double.TryParse(textBox3.Text, out outValue);
                if (ok1)
                {
                    if (outValue > 0)
                    {
                        BMICalculator.SetHeight(outValue);
                    }
                }
                if (!ok1)
                {
                    MessageBox.Show("Invalid height value!", "Error!");
                }
            } else
            {
                double feet = 0;
                double inches = 0;

                bool ok1 = double.TryParse(textBox1.Text, out feet);
                bool ok2 = double.TryParse(textBox3.Text, out inches);
                if (ok1 && ok2)
                {
                    if (feet > 0)
                    {
                       
                        double TotalInches = feet * 12; // Converting feet to inches
                        TotalInches += inches;
                        BMICalculator.SetHeight(TotalInches);
                        groupBox3.Text = TotalInches.ToString();
                    }
                } if (!ok1)
                {
                    MessageBox.Show("Invalid height value!", "Error!");
                }
            } return true;
        }

        private bool ReadWeight() //Reading the weight of the user
        {
            double outValue = 0;
            bool ok = double.TryParse(textBox4.Text, out outValue);
            if (ok)
            {
                if (outValue > 0)
                {
                    BMICalculator.SetWeight(outValue);
                }
                else
                {
                    ok = false;
                }
            }
            if (!ok)
            {
                MessageBox.Show("Invalid weight value!", "Error!");
            }
            return ok;
        }

        private bool ReadMonthlyDeposit() //Reading monthly deposit of user
        {
            double outValue = 0;
            bool ok = double.TryParse(textBox5.Text, out outValue);
            if (ok)
            {
                if (outValue > 0)
                {
                    SavingCalculator.SetmonthlyDeposit(outValue);
                }
                else
                {
                    ok = false;
                }
            }
            if (!ok)
            {
                MessageBox.Show("Invalid value!", "Error!");
            }
            return ok;

        }

        private bool ReadPeriod()
        {
            int outValue = 0;
            bool ok = int.TryParse(textBox6.Text, out outValue);
            if (ok)
            {
                if (outValue > 0) //Only values larger than 0
                {
                    SavingCalculator.SetPeriod(outValue);
                }
                else
                {
                    ok = false;
                }
            }
            if (!ok)
            {
                MessageBox.Show("Invalid value!", "Error!"); //Make messagebox appear to inform user that input was invalid
            }
            return ok;

        }


        private void DisplayResults()
        {
            BMIShown.Text = BMICalculator.CalculateBMI().ToString("f2"); //Format to show two decimals
            WeightCatShown.Text = BMICalculator.BMIWeightCategory().ToString();
            groupBox3.Text = "Results for " + BMICalculator.GetName(); //Get the name of the user
        }

        private void DisplaySavingResults()
        {
            AmountPaidShown.Text = SavingCalculator.CalculateAmountPaid().ToString("f2");
            FinalBalanceShown.Text = SavingCalculator.CalculateFinalBalance().ToString("f2");
        }

        private void Metric_CheckedChanged(object sender, EventArgs e)
        {
            if (Metric.Checked)
            {
                Height.Text = "Height (cm)";
                Weight.Text = "Weight (kg)";
                BMICalculator.SetUnitType(UnitTypes.Metric);
                textBox1.Visible = false; //Hide visibility of the input box for feet as this is not needed when using the metric system
            }
        }

        private void Imperial_CheckedChanged(object sender, EventArgs e)
        {
            if (Imperial.Checked)
            {
                Height.Text = "Height (ft and in)";
                Weight.Text = "Weight (lbs)";
                BMICalculator.SetUnitType(UnitTypes.Imperial);
                textBox1.Visible = true;
            }
        }




        private void CalculateSaving_Enter(object sender, EventArgs e)
        {
            ReadMonthlyDeposit();
            ReadPeriod();
            DisplaySavingResults();
        }
        private void CalculateBMI_Enter(object sender, EventArgs e)
        {
            ReadName();
            ReadHeight();
            ReadWeight();
            DisplayResults();
        }
    }
}
