using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace BonusCalculator
{
    class Salaried : Employee, IPayRate, IBonus
    {
        private double salary;
        public double Salary
        { get ; set ; }

        public Salaried() : base()
        {
            LastName = "";
            FirstName = "";
            EmployeeType = "";
            Salary = 0.0;
        }
        public Salaried(string newLastName, string newFirstName, string newEmployeeType, double newSalary) : base(newLastName, newFirstName, newEmployeeType)
        {
            Salary = newSalary;
        }

        public void PayRate(double newPayRate)
        {
            Salary = newPayRate;
        }
        public double AnnualBonus()
        {            
            return (Salary/10);
        }

        public override string ToString()
        {
            return $"\nEmployee\nName: {LastName}, {FirstName}\nEmployee Type: {EmployeeType}\nEmployee Compensation : ${Salary}/year\nEmployee Bonus : {AnnualBonus()}\n\n";
        }
    }
}
