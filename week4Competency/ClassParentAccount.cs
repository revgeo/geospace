using System;
using System.Collections.Generic;

namespace BankAccountManager
{
   public abstract class Account
   {
    public int AccountId
    { get; set; }

    public double CurrentBalance
    { get; set; }

    public string? AccountType
    { get; set; }

    public Account()
    {
        AccountId = 0;
        CurrentBalance = 0.0;
        AccountType = "";
    }

    public Account(int newAccountId, double newCurrentBalance, string newAccountType)
    {
        AccountId = newAccountId;
        CurrentBalance = newCurrentBalance;
        AccountType = newAccountType;
    }

    public void Deposit(double newDeposit)
    {
        double postDepositBalance = (newDeposit + CurrentBalance);
        CurrentBalance = postDepositBalance;
        Console.WriteLine($"You have made a deposit in the amount of ${newDeposit} into your {AccountType} account, Account Number : {AccountId}.\nYour new balance is : ${CurrentBalance}");
    }

    public abstract void AccountWithdrawal(double newWithdrawal);
    
    public virtual new string? ToString ()
    {
        return $"\nAccount Number : {AccountId}\nAccount Balance : ${CurrentBalance}\nAccount Type : {AccountType}";
    }

   }    //end class
}   //end Namespace