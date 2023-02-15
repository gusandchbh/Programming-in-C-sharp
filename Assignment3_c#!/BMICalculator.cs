using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class BMICalculator
    {
        private string name = "Unknown";
        private double height = 0;
        private double weight = 0;
        private UnitTypes unit;

        public string GetName()
        {
            return name;
        }

        public double GetHeight()
        {
            return height;
        }

        public double GetWeight()
        {
            return weight;
        }

        public UnitTypes getUnitType()
        {
            return unit;
        }

        public void SetHeight(double val)
        {
            if (val >= 0)
                height = val;
        }

        public void SetWeight(double val)
        {
            if (val >= 0)
                weight = val;
        }

        public void SetName(string val)
        {
            if (!string.IsNullOrEmpty(val))
                name = val;
        }

        public void SetUnitType(UnitTypes unitType)
        {
            this.unit = unitType;
        }

        public double CalculateBMI()
        {
            double bmi = 0.0;
            if (getUnitType().ToString().Equals("Imperial"))
            {
                bmi = (((GetWeight() / GetHeight()) / GetHeight()) * 703); //Calculates bmi for imperial
        
            } else
            {
                bmi = GetWeight() / ((GetHeight() / 100) * (GetHeight() / 100)); //Calculates bmi for metric
            }
            return bmi;
        }

        public string BMIWeightCategory() //Returns the weight category based on the bmi value
        {
            double bmi = CalculateBMI();
            string output = string.Empty;
            if (bmi >= 40)
                output = "Overweight (Obesity class III)";
            else if (bmi >= 35)
                output = "Overweight (Obesity class II)";
            else if (bmi >= 30)
                output = "Overweight (Obesity class I)";
            else if (bmi > 25)
                output = "Overweight (Pre-obesity)";
            else if (bmi >= 18.5)
                output = "Normal weight";
            else if (bmi < 18.5)
                output = "Underweight";
            else
            {
                output = ""; 
            }
            return output;
        }

    }

 
}
