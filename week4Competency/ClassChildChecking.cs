using System;
using System.Collections.Generic;

namespace BankAccountManager
{
   class Checking : Account
   {

    public double CheckingFee
    { get; set; }

    public Checking() : base()
    {
        AccountId = 0;
        CurrentBalance = 0.0;
        AccountType = "";
        CheckingFee = 0;
    }

    public Checking(int newAccountId, double newCurrentBalance, string newAccountType, double newCheckingFee) : base (newAccountId, newCurrentBalance, newAccountType)
    {
        AccountId = newAccountId;
        CurrentBalance = newCurrentBalance;
        AccountType = newAccountType;
        CheckingFee = newCheckingFee;
    }

    public override void AccountWithdrawal(double newWithdrawal)
    {
        Console.WriteLine($"You have requested to make a withdrawal in the amount of ${newWithdrawal} from Account Number {AccountId}.");
        
        if (newWithdrawal <= (CurrentBalance/2))
        {
            double postWithdrawalBalance = (CurrentBalance - newWithdrawal);
            CurrentBalance = postWithdrawalBalance;
            Console.WriteLine($"Your new balance is : ${CurrentBalance}");
        }
        else
        {
            Console.WriteLine($"You have insufficient funds to make this withdrawal.\nYour current balance is : ${CurrentBalance}\nPlease make a withdrawal of equal to or less than ${Math.Round((CurrentBalance/2), 2)} to proceed.");
        }        
    }

    public override string? ToString ()
    {
        return $"\nAccount Number : {AccountId}\nAccount Balance : ${CurrentBalance}\nAccount Type : {AccountType}\nChecking Account Annual Fee : ${CheckingFee}"; 
    }
   }    //end class
}   //end Namespace