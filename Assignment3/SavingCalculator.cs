using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class SavingCalculator
    {

        private double monthlyDeposit = 0;
        private double InterestRate = 0.00833333333; // 10 % yearly interest rate divided by 12 months
        private int period = 0; 


        public void SetPeriod(int val)
        {
            if (val >= 0)
                period = val;
        }
        public void SetInterestRate(double val)
        {
            if (val >= 0)
                InterestRate = val;
        }
        public void SetmonthlyDeposit(double val)
        {
            if (val >= 0)
                monthlyDeposit = val;
        }

        public double GetPeriod()
        {
            return period;
        }
        public double GetmonthlyDeposit()
        {
            return monthlyDeposit;
        }
        public double GetInterestRate()
        {
            return InterestRate;
        }





        public double CalculateAmountPaid()
        {
            return monthlyDeposit * 12 * period;
        }

        public double CalculateFinalBalance()
        {
            double NumOfMonths = period * 12;
            double balance = monthlyDeposit;
            for (int i = 1; i < NumOfMonths; i++) //Wasen't sure from when we should start calculating interest, so assumed after first month
            {
                double InterestEarned = InterestRate * balance;
                balance += InterestEarned + monthlyDeposit;
            }
            return balance;
        }
    }
}
