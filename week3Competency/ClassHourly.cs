using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace BonusCalculator
{
    class Hourly : Employee, IPayRate, IBonus 
    {
        private double hourlyRate;
        public double HourlyRate
        { get ; set ; }
        public Hourly() : base()
        {
            LastName = "";
            FirstName = "";
            EmployeeType = "";
            HourlyRate = 0.0;
        }

        public Hourly(string newLastName, string newFirstName, string newEmployeeType, double newHourlyRate) : base(newLastName, newFirstName, newEmployeeType)
        {
            PayRate(newHourlyRate);
        }

        public void PayRate(double newPayRate)
        {
            HourlyRate = newPayRate;
        }

        public double AnnualBonus()
        {       
            return HourlyRate*80;
        }

        public override string ToString()
        {
            return $"\nEmployee\nName: {LastName}, {FirstName}\nEmployee Type: {EmployeeType}\nEmployee Compensation : ${HourlyRate}/hr\nEmployee Bonus : {AnnualBonus()}\n\n";
        }
    }
}