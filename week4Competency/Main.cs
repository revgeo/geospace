using System;
using System.Collections.Generic;

namespace BankAccountManager
{
    class Program
    {
        static void Main (String[]args)
        {
//Instantiate Accounts for testing
            Savings saving1 = new Savings(1111, 1000.00, "Savings", .001);
            Savings saving2 = new Savings(4444, 4000.00, "Savings", 0.01);
            Checking checking1 = new Checking(2222, 2000.00, "Checking", 15);
            Checking checking2 = new Checking(5555, 5000.00, "Checking", 25);
            Cd cd1 = new Cd(3333, 3000.00, "CD", 0.01, 0.02);
            Cd cd2 = new Cd(6666, 6000.00, "CD", 0.1, 0.2);

            //Loading Account objects into List<> bankAccounts
            List<Account> bankAccounts = new List <Account> ();
            bankAccounts.Add(saving1);
            bankAccounts.Add(saving2);
            bankAccounts.Add(checking1);
            bankAccounts.Add(checking2);
            bankAccounts.Add(cd1);
            bankAccounts.Add(cd2);
//end of testing accounts"File" data

            //Define variables
            bool menuChoice;
            bool accountIdInput;
            bool accountDepositCheck;
            double userAccountDeposit;
            double userAccountWithdrawal;
            int activeAccountIndex;
            int userAccountIdInput;
            string? userMenuSelect;

            //Create an array of the account numbers for accountId validation method used in cases "D" and "W"
            int[] activeAccounts = new int[bankAccounts.Count];
            for (activeAccountIndex = 0 ; activeAccountIndex < activeAccounts.Length ; activeAccountIndex++)
            {
                activeAccounts[activeAccountIndex] = bankAccounts[activeAccountIndex].AccountId;
            }
            
            //Main DO loop to iterate as long as user does not quit out of program
            do
            {    
                //Collect user menu choice
                do  
                {
                    //boolean to loop until valid choice is made from the following
                    menuChoice = false; 

                    Console.WriteLine("\nBank Account Manager\n");
                    Console.WriteLine("L : View the accounts currently saved in the List.");
                    Console.WriteLine("D : Deposit money into an account.");
                    Console.WriteLine("W : Withdraw money from an account.");
                    Console.WriteLine("Q : Quit the program.");

                    Console.Write("\nEnter selection here : ");
                    userMenuSelect = Console.ReadLine();

                    //method that forces user to input one of presented selections
                    menuChoice = CheckMenuSelection(userMenuSelect!, new string[]{"l", "d", "w", "q"});

                    //cycle back to force valid selection
                    if (!menuChoice)
                    {
                        Console.WriteLine("\nThe choice you made was invalid, please try again.\n");
                    }
                } while (!menuChoice);
                    
                //Begin Switch statement to go through user menu options
                switch (userMenuSelect)
                {
                    case "L":
                    case "l":
                        Console.WriteLine("Here are the accounts currently loaded into the list:");
                        foreach (var bankAccount in bankAccounts)
                        {
                            Console.WriteLine(bankAccount.ToString());
                        }
                    break;
                    case "D":
                    case "d":                        
                        Console.WriteLine("You have chosen to make a deposit.");
                        
                        //Do loop for AccountId verification
                        do
                        {
                            Console.Write("\nTo which account would you like to make a deposit?\nAccount Number : ");
                            userAccountIdInput = Convert.ToInt32(Console.ReadLine());
                            //Call method to check if AccountId is present and valid
                            accountIdInput = CheckAccountId(userAccountIdInput, activeAccounts);
                            if (!accountIdInput)
                            {
                                Console.WriteLine("\nThe Account Number you entered was not found, please try again.\n");
                            }
                        }while (!accountIdInput);

                        //Do loop to verify deposit 
                        do
                        {
                            Console.Write($"\nPlease enter amount to deposit into Account Number {userAccountIdInput} : ");
                            userAccountDeposit = Convert.ToDouble(Console.ReadLine());
                            //Call Method to check that entered amount is greater than zero
                            accountDepositCheck = CheckAmount(userAccountDeposit);
                            if (!accountDepositCheck)
                            {
                                Console.WriteLine("\nPlease enter an deposit amount greater than $0");
                            }
                        } while (!accountDepositCheck);
                        
                        //Search List<> bankAccounts for specific AcountId 
                        foreach (var bankAccount in bankAccounts)
                        {
                            if (bankAccount.AccountId == userAccountIdInput)
                            {
                                bankAccount.Deposit(userAccountDeposit);//Call Method from abstract class for deposit
                            }
                        }
                    break;
                    case "W":
                    case "w":
                        Console.WriteLine("You have chosen to make a withdrawal.");

                        //Do loop for AccountId verification
                        do
                        {
                            Console.Write("\nFrom which account would you like to make a withdrawal?\nAccount Number : ");
                            userAccountIdInput = Convert.ToInt32(Console.ReadLine());
                            //Call method to check if AccountId is present and valid
                            accountIdInput = CheckAccountId(userAccountIdInput, activeAccounts);
                            if (!accountIdInput)
                            {
                                Console.WriteLine("\nThe Account Number you entered was not found, please try again.\n");
                            }
                        }while (!accountIdInput);

                        //Do loop to verify withdrawal 
                        do
                        {
                            Console.Write($"\nPlease enter amount to withdraw from Account Number {userAccountIdInput} : ");
                            userAccountWithdrawal = Convert.ToDouble(Console.ReadLine());
                            //Call Method to check that entered amount is greater than zero
                            accountDepositCheck = CheckAmount(userAccountWithdrawal);
                            if (!accountDepositCheck)
                            {
                                Console.WriteLine("\nPlease enter an withdrawal amount greater than $0");
                            }
                        } while (!accountDepositCheck);

                        //Search List<> bankAccounts for specific AcountId
                        foreach (var bankAccount in bankAccounts)
                        {
                            if (bankAccount.AccountId == userAccountIdInput)
                            {
                                bankAccount.AccountWithdrawal(userAccountWithdrawal);//Execute withdraw method from specific child class
                            }
                        }
                    break;
                    case "Q":
                    case "q":
                    default: Console.WriteLine("\n\nThank You for using the week4CompetencyProgram.\n\n");
                    break;
                }
                        
            } while (userMenuSelect != "Q" && userMenuSelect != "q");   //end main do loop
        }//end Main

        //Method, Man

        //Limit user input to choices available in Menu
        private static bool CheckMenuSelection(string userInput, string[] acceptedValues)
        {
            foreach (var value in acceptedValues)
            {
                if (userInput == value || userInput == value.ToLower() || userInput == value.ToUpper()) return true;
            }
            return false;
        }

        //Method for verifying the entered accountId is valid
        private static bool CheckAccountId(int userAccountInput, int[] activeAccounts)
        {
            foreach (int activeAccount in activeAccounts)
            {
                if (userAccountInput == activeAccount) return true;
            }
            return false;
        }

        //Meethod to 
        private static bool CheckAmount(double accountIO)
        {
            if (accountIO > 0) return true;
            else return false;
        }
        //end of Method, Man.
    }//end Program
}//end Namespace
