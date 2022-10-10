using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace BonusCalculator
{
    class Employee
    {
        private string? lastName;
        public string? LastName
        { get ; set ; }

        private string? firstName;
        public string? FirstName
        { get ; set ; }

        private string? employeeType;
        public string? EmployeeType
        { get ; set ; }

        public Employee()
        {
            LastName = "";
            FirstName = "";
            EmployeeType = "";
        }

        public Employee(string newLastName, string newFirstName, string newEmployeeType)
        {
            LastName = newLastName;
            FirstName = newFirstName;
            EmployeeType = newEmployeeType;
        }

        
        static void NoBonus()
        {
            Console.WriteLine("Only full time employees receive bonuses");
        }

        // public virtual string ToString()
        // {
        //     return $"\nEmployee\nName: {LastName}, {FirstName}\nEmployee Type: {EmployeeType}\n";
        // }
    }
}
