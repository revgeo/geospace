using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace BonusCalculator
{
    class Program
    {
        static void Main(String[]args)
        {   
            //such variable. wow.
            bool menuChoice;
            bool subMenuChoice;
            bool repeatSubMenu;
            bool repeatUpdateMenu;
            bool updateMenuChoice;
            bool newEmployeeTypeChoice;            
            string? userMenuSelect;
            string? updateDataChoice;
            string? lastName;
            string? firstName;
            string? employeeType;
            double employeePayRate;
            string? newLastName;
            string? newFirstName;
            string? newEmployeeType;
            double newEmployeePayRate;       
            string employeeRecord = "EmployeePaymentRecord.txt";
            List<Employee> myEmployees = new List<Employee>();

            do      //Main DO loop to iterate as long as user does not quit out of program
            {    
                do      //Collect user menu choice
                {
                    menuChoice = false;     //iterate until makes valid choice

                    Console.WriteLine("\nEmployee Bonus Calculator\n");
                    Console.WriteLine("L: Load your saved employee records.");
                    Console.WriteLine("S: Save employee records to disk.");
                    Console.WriteLine("C: Add an employee data file.");
                    Console.WriteLine("R: Display a current list of your employees, with bonus pay information.");
                    Console.WriteLine("U: Update an existing employee data file.");
                    Console.WriteLine("D: Remove an employee from the data file.");
                    Console.WriteLine("Q: Quit the program.");

                    Console.Write("\nEnter selection here : ");
                    userMenuSelect = Console.ReadLine();

                    menuChoice = CheckMenuSelection(userMenuSelect!, new string[]{"l", "s", "c", "r", "u", "d", "q"});      //Use Method(see at below MAIN) to force user input

                    if (!menuChoice)        //cycle back to force valid selection
                    {
                        Console.WriteLine("\nThe choice you made was invalid, please try again.\n");
                    }
                    
                } while (!menuChoice);
                switch (userMenuSelect)     //Switch of different menu choices
                {
                    case "L":       //menu option to LOAD data file
                    case "l":                    
                    try     //make sure console doesn't boot out due to invalid file load
                    {
                        using (StreamReader recordReader = File.OpenText(employeeRecord))       //open text file and read it!
                        {
                            string[] employeeData = File.ReadAllLines(employeeRecord);      //convert all strings line by line into an array
                            var dataIndex = 0;      //used for key index
                            do      //iterate through array
                            {                               
                                lastName = employeeData[dataIndex];     //Starting at index 0
                                firstName = employeeData[dataIndex+1];      //assign the items, in sequesntially
                                employeeType = employeeData [dataIndex+2];      //to the variables
                                employeePayRate = Convert.ToDouble(employeeData [dataIndex+3]);       //used in Class constructors
                                if (employeeType.Contains("Salaried"))      //filters type of employee class object to create - Salaried
                                {
                                    Salaried newSalaried = new Salaried(lastName, firstName, employeeType, employeePayRate);        //Send all variables to constructor
                                    myEmployees.Add(newSalaried);       //send object to newly created List
                                }
                                else if (employeeType.Contains("Hourly"))       //Filter Hourly
                                {
                                    Hourly newHourly = new Hourly(lastName, firstName, employeeType, employeePayRate);
                                    myEmployees.Add(newHourly);     //send separate object to list
                                }
                                dataIndex += 4;     //advance Index to next set of 4 data points
                            } while (dataIndex < employeeData.Length);      //set end of data collection/assignment
                            Console.WriteLine($"\n\nYour data has been loaded into the calculator. {myEmployees.Count} data files are ready to review.\n\n");       //insert [SeanConneryCelebrityJeopardyLetThePeopleSeeMyWork.gif]
                        }
                    }
                    catch (Exception)       //make sure no crash out
                    {
                        Console.WriteLine("\n\nThere are no records to display.\nPlease enter new employee data from the Main Menu.\n");
                    }
                        break;
                    case "S":       //option to SAVE data to file
                    case "s":
                    try
                    {
                        if (File.Exists(employeeRecord))        //Check for existing data file
                        {
                            File.Delete(employeeRecord);        //Clean up existing data if it exists
                        }
                        
                        using (StreamWriter fileCreate = File.CreateText(employeeRecord))
                        {
                            foreach (var savedEmployee in myEmployees)
                            {
                                fileCreate.WriteLine(savedEmployee.LastName!); 
                                fileCreate.WriteLine(savedEmployee.FirstName!); 
                                fileCreate.WriteLine(savedEmployee.EmployeeType!);
                                if (savedEmployee.EmployeeType == "Salaried")
                                { 
                                    fileCreate.WriteLine((savedEmployee as Salaried)!.Salary);
                                }
                                else if (savedEmployee.EmployeeType == "Hourly")
                                {
                                    fileCreate.WriteLine((savedEmployee as Hourly)!.HourlyRate);
                                }
                            }
                            
                            Console.WriteLine($"\nYour file {employeeRecord} was created, and {myEmployees.Count} employee records were saved to disk.\n\n");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("\nSomething went wrong, and your file was not created. Please try again.\nIf your problem persists, please contact your system administrator.\n\n");
                    }
                        break;
                    case "C":
                    case "c":
                    {
                        subMenuChoice = false;
                        repeatSubMenu = false;

                        Console.WriteLine("\nEnter New Employee Information");
                        do
                        {
                            Console.Write("\nPlease enter the employee's name.\nLast Name : ");
                            lastName = Console.ReadLine();
                            Console.Write("First Name : ");
                            firstName = Console.ReadLine();
                            do
                            {
                                Console.Write("Enter an employee type.\n[S] for Salaried, [H] for Hourly\nEnter Selection : ");
                                employeeType = Console.ReadLine();
                                subMenuChoice = (employeeType == "S" || employeeType == "s" ||
                                                employeeType == "H" || employeeType == "h");
                                if (CheckSingleMenuInput(employeeType!, "s"))
                                {
                                    employeeType = "Salaried";
                                    Console.Write("Finally, please enter the employee's yearly salary.\n(No punctuation, rounded to nearest whole number) : ");
                                    employeePayRate = Convert.ToDouble(Console.ReadLine());
                                    Salaried newSalaried = new Salaried(lastName!, firstName!, employeeType!, employeePayRate!);
                                    myEmployees.Add(newSalaried);
                                }
                                else if (CheckSingleMenuInput(employeeType!, "h"))
                                {
                                    employeeType = "Hourly";
                                    Console.Write("\nFinally, please enter the employee's hourly rate.\n(No punctuation, rounded to nearest whole number) : ");
                                    employeePayRate = Convert.ToDouble(Console.ReadLine());
                                    Hourly newHourly = new Hourly(lastName!, firstName!, employeeType!, employeePayRate!);
                                    myEmployees.Add(newHourly);
                                }
                                else
                                {
                                    Console.WriteLine("\nThe choice you made was invalid, please try again.\n");    
                                }
                            } while (!subMenuChoice);

                            Console.Write("\nWould you like to enter another new employee? [ Y / N ] : ");
                            var repeatSubMenuChoice = Console.ReadLine();
                            repeatSubMenu = (repeatSubMenuChoice == "Y" || repeatSubMenuChoice == "y" ||
                                            repeatSubMenuChoice == "N" || repeatSubMenuChoice == "n");
                            if (CheckSingleMenuInput(repeatSubMenuChoice!, "y"))
                            {
                                repeatSubMenu = false;
                            }
                            else if (CheckSingleMenuInput(repeatSubMenuChoice!, "n"))
                            {
                                repeatSubMenu = true;
                            }
                            else
                            {
                                Console.Write("\nThe choice you made was invalid, please try again.\n\n");
                            }
                        } while (!repeatSubMenu);
                    }
                        break;
                    case "R":
                    case "r":
                    {
                        foreach (var savedEmployee in myEmployees)
                        {
                            Console.WriteLine(savedEmployee);
                        }
                    }
                        break;
                    case "U":
                    case "u":
                    try
                    {
                        Console.WriteLine("\nUpdate Existing Employee Records");
                        do
                        {
                            Console.WriteLine("\nHere is a list of your Currently saved employees : \n");
                            var listIndex = 1;
                            foreach (var savedEmployee in myEmployees)
                            {
                                Console.WriteLine($"{listIndex}. {savedEmployee.LastName!}, {savedEmployee.FirstName!}");
                                listIndex++;
                            }
                            Console.Write("\nPlease enter the listed number of the employee you'd like to update : ");
                            var updatEmployeeSelection = Convert.ToInt16(Console.ReadLine());
                            var updateListIndex = updatEmployeeSelection-1;
                            Console.WriteLine($"What data would you like to change about {myEmployees[updateListIndex].FirstName} {myEmployees[updateListIndex].LastName}?");
                            
                            updateMenuChoice = false;

                            do
                            {                            
                                Console.WriteLine("\n[LN] Last Name");
                                Console.WriteLine("[FN] First Name");
                                Console.WriteLine("[ET] Employee Type");
                                Console.WriteLine("[EP] Employee Pay\n");
                                Console.Write("\nPlease enter selection : ");
                                updateDataChoice = Console.ReadLine()!.ToUpper();
                                updateMenuChoice = CheckMenuSelection(updateDataChoice!, new string[] {"ln", "fn", "et", "ep"});
                                if (!updateMenuChoice)      //cycle back to force valid selection
                                {
                                    Console.WriteLine("\nThe choice you made was invalid, please try again.\n");
                                }
                            } while (!updateMenuChoice);
                            switch (updateDataChoice)
                            {
                                case "LN":
                                case "ln":
                                case "Ln":
                                case "lN":
                                {
                                    Console.Write("Update Employee Last Name\nPlease enter new Last Name : ");
                                    newLastName = Console.ReadLine();
                                    myEmployees[updateListIndex].LastName = newLastName;

                                }
                                    break;
                                case "FN":
                                case "fn":
                                case "Fn":
                                case "fN":
                                {
                                    Console.Write("Update Employee First Name\nPlease enter new First Name : ");
                                    newFirstName = Console.ReadLine();
                                    myEmployees[updateListIndex].FirstName = newFirstName;
                                }
                                    break;
                                case "ET":
                                case "et":
                                case "Et":
                                case "eT":
                                {
                                    var newEmployeeLastName = myEmployees[updateListIndex].LastName;
                                    var newEmployeeFirstName = myEmployees[updateListIndex].FirstName;
                                    newEmployeeTypeChoice = false;
                                    do
                                    {
                                        Console.Write("Update Employee Type\nEnter a new employee type.\n[S] for Salaried, [H] for Hourly\nEnter Selection : ");
                                        newEmployeeType = Console.ReadLine();
                                        newEmployeeTypeChoice = (newEmployeeType == "S" || newEmployeeType == "s" ||
                                                        newEmployeeType == "H" || newEmployeeType == "h");
                                        if (CheckSingleMenuInput(newEmployeeType!, "s"))
                                        {
                                            if (myEmployees[updateListIndex].EmployeeType == "Salaried")
                                            {
                                                Console.WriteLine($"{myEmployees[updateListIndex].FirstName} {myEmployees[updateListIndex].LastName} is already a salaried employee.");
                                            }
                                            else
                                            {    
                                                newEmployeeType = "Salaried";
                                                myEmployees[updateListIndex].EmployeeType = newEmployeeType;
                                                Console.Write("The employee's type has been changed to Salaried.\nThis change in employee type requires a change in pay rate.\nPlease enter the employee's yearly salary.\n(No punctuation, rounded to nearest whole number) : ");
                                                newEmployeePayRate = Convert.ToDouble(Console.ReadLine());
                                                myEmployees[updateListIndex] = new Salaried(newEmployeeLastName!, newEmployeeFirstName!, newEmployeeType, newEmployeePayRate);
                                            }
                                        }
                                        else if (CheckSingleMenuInput(newEmployeeType!, "h"))
                                        {
                                            if (myEmployees[updateListIndex].EmployeeType == "Hourly")
                                            {
                                                Console.WriteLine($"{myEmployees[updateListIndex].FirstName} {myEmployees[updateListIndex].LastName} is already an hourly employee.");
                                            }
                                            else
                                            {
                                                newEmployeeType = "Hourly";
                                                myEmployees[updateListIndex].EmployeeType = newEmployeeType;
                                                Console.Write("The employee's type has been changed to Hourly.\nThis change in employee type requires a change in pay rate.\nPlease enter the employee's hourly rate.\n(No punctuation, rounded to nearest whole number) : ");
                                                newEmployeePayRate = Convert.ToDouble(Console.ReadLine());
                                                myEmployees[updateListIndex] = new Hourly(newEmployeeLastName!, newEmployeeFirstName!, newEmployeeType, newEmployeePayRate);
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nThe choice you made was invalid, please try again.\n");    
                                        }
                                    } while (!newEmployeeTypeChoice);
                                }
                                
                                    break;
                                case "EP":
                                case "ep":
                                case "Ep":
                                case "eP":
                                {
                                    Console.Write($"Update Employee Pay\nPlease enter the new pay rate for {myEmployees[updateListIndex].FirstName} {myEmployees[updateListIndex].LastName} : ");
                                    newEmployeePayRate = Convert.ToDouble(Console.ReadLine());
                                    if (myEmployees[updateListIndex].EmployeeType == "Salaried")
                                    {
                                        (myEmployees[updateListIndex] as Salaried)!.PayRate(newEmployeePayRate);
                                    }
                                    else if (myEmployees[updateListIndex].EmployeeType == "Hourly")
                                    {
                                        (myEmployees[updateListIndex] as Hourly)!.PayRate(newEmployeePayRate);
                                    }
                                    Console.WriteLine($"\n{myEmployees[updateListIndex].FirstName} {myEmployees[updateListIndex].LastName}'s pay rate has been updated.\n");
                                }
                                    break;
                                
                            }
                            Console.Write("\nWould you like to update another employee record? [ Y / N ] : ");
                            var repeatUpdateMenuChoice = Console.ReadLine();
                            repeatUpdateMenu = (repeatUpdateMenuChoice == "Y" || repeatUpdateMenuChoice == "y" ||
                                            repeatUpdateMenuChoice == "N" || repeatUpdateMenuChoice == "n");
                            if (CheckSingleMenuInput(repeatUpdateMenuChoice!, "y"))
                            {
                                repeatUpdateMenu = false;
                            }
                            else if (CheckSingleMenuInput(repeatUpdateMenuChoice!, "n"))
                            {
                                repeatUpdateMenu = true;
                            }
                            else
                            {
                                Console.Write("\nThe choice you made was invalid, please try again.\n\n");
                            }
                        } while (!repeatUpdateMenu);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("\nSomething went wrong, and your file was not created. Please try again.\nIf your problem persists, please contact your system administrator.\n\n");
                    }
                        break;
                    case "D":
                    case "d":
                    {
                        Console.WriteLine("\n\ncase D, d\n\n");
                    }
                        break;
                    case "Q":
                    case "q":
                    default: Console.WriteLine("\n\n        Thank you for using the Employee Bonus Calculator.\n                Please pay your employees fairly.         \n                        Have a nice day!        \n\n\n\n\n\n\n\n\n              (#butforrealthoughpayalivingwage)\n\n");
                        break;
                }
            } while (userMenuSelect != "Q" && userMenuSelect != "q");   //end main do loop
        }//end Main
        //Methods
        private static bool CheckMenuSelection(string userInput, string[] acceptedValues)
        {
            foreach (var value in acceptedValues)
            {
                if (userInput == value || userInput == value.ToLower() || userInput == value.ToUpper()) return true;
            }
            return false;
        }

        private static bool CheckSingleMenuInput(string userInput, string acceptedValue)
        {

            return (userInput == acceptedValue || userInput == acceptedValue.ToLower() || userInput == acceptedValue.ToUpper());
        }

        //end Methods
    }//end program
}//end namespace
