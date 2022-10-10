using System;
using System.Collections.Generic;

namespace BankAccountManager
{
   class Savings : Account
   {

    public double SavingsInterestRate
    { get; set; }

    public Savings() : base()
    {
        AccountId = 0;
        CurrentBalance = 0.0;
        AccountType = "";
        SavingsInterestRate = 0;
    }

    public Savings(int newAccountId, double newCurrentBalance, string newAccountType, double newSavingsInterestRate) : base (newAccountId, newCurrentBalance, newAccountType)
    {
        AccountId = newAccountId;
        CurrentBalance = newCurrentBalance;
        AccountType = newAccountType;
        SavingsInterestRate = newSavingsInterestRate;
    }

    public override void AccountWithdrawal(double newWithdrawal)
    {
        Console.WriteLine($"You have requested to make a withdrawal in the amount of ${newWithdrawal} from Account Number {AccountId}.");

        if (newWithdrawal < CurrentBalance && newWithdrawal != 0)
        {
            double postWithdrawalBalance = (CurrentBalance - newWithdrawal);
            CurrentBalance = postWithdrawalBalance;
            Console.WriteLine($"Your new balance is : ${postWithdrawalBalance}");
            
        }
        else if (newWithdrawal == CurrentBalance)
        {
            Console.WriteLine($"A withdrawal in the ammount of ${newWithdrawal} would close your account.\nPlease visit your nearest bank branch to speak with an account specialist to proceed.");
        }
        else
        {
            Console.WriteLine($"You have insufficient funds to make this withdrawal.\nYour current balance is : ${CurrentBalance}\nPlease make a withdrawal in an amount less than ${CurrentBalance} to proceed.");
        }
        
    }

    public double EstimatedApy()
    {
        return (CurrentBalance*SavingsInterestRate);
    }

    public override string? ToString ()
    {
        return $"\nAccount Number : {AccountId}\nAccount Balance : ${CurrentBalance}\nAccount Type : {AccountType}\nEstimated Savings Account APY (based on Current Balance and Interest Rate) : ${EstimatedApy()}"; 
    }
   }    //end class
}   //end Namespace