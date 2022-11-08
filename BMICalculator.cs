using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    //Input - Height, weight, unit
    //Instance variables
    //Calculate
    //Output - Instance variables or method return value
    class BMICalculator
    {
        //instance variables for input
        private double height; //Can be any unit
        private double weight; //Can be any unit

        private UnitTypes unit;

        //methods
        //Constructors, Runs when an object of a class is created
        //Default constructor, Constructor without parameters
        public BMICalculator()
        {
            unit = UnitTypes.Metric;  
        }

        #region Getters and setters
        public double GetHeight()
        {
            return height;
        }
        public void SetHeight(double height)
        {
            if (height >= 0.0)
            this.height = height; //To avoid nearest declaration

        }
        public double GetWeight()
        {
            return weight;
        }
        public void SetWeight(double weight)
        {
            if (weight >= 0)
                this.weight = weight; //To avoid nearest declaration
        }

        public UnitTypes GetUnitType()
        {
            return unit;
        }
        public void SetUnitType(UnitTypes unit)
        {
            this.unit = unit; //To avoid nearest declaration
        }
        #endregion
        //Getters and setters

        public double CalculateBMI()
        {
            //metric values
            //height must be in m or inches
            double bmiValue = 0.0;
            double ImpFactor = 1.0;

            if (unit == UnitTypes.Imperial)
            {
                ImpFactor = 703.0;
            }

            bmiValue = ImpFactor * weight / (height * height);

            return bmiValue;
        }

        //Method that sets the weight category dependiong on the valueof BMI.
        //Calls the method CalculateBMI before setting the categories
        public string BMIweightCategory()
        {
            double bmi = CalculateBMI();
            string stringout = string.Empty;

            if (bmi < 18.5) //If first one true, does not calculate rest
                stringout = "Underweight";
            else if (bmi <= 24.9)
                stringout = "Normal weight";
            else if (bmi <= 29.9)
                stringout = "Overweight (Pre-obesity)";
            else if (bmi <= 34.9)
                stringout = "Overweight (Obesity class I)";
            else if (bmi <= 39.9)
                stringout = "Overweight (Obesity class II)";
            else if (bmi >= 40.0)
                stringout = "Overweight (Obesity class III)";

            return stringout;
        }
    }
}
