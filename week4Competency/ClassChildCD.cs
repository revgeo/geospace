using System;
using System.Collections.Generic;

namespace BankAccountManager
{
   class Cd : Account
   {

    public double CdApy
    { get; set; }

    public double CdWithdrawalPenalty
    { get; set; }

    public Cd() : base()
    {
        AccountId = 0;
        CurrentBalance = 0.0;
        AccountType = "";
        CdApy = 0.0;
        CdWithdrawalPenalty = 0.0;
    }

    public Cd(int newAccountId, double newCurrentBalance, string newAccountType, double newCdApy, double newCdWithdrawalPenalty) : base (newAccountId, newCurrentBalance, newAccountType)
    {
        AccountId = newAccountId;
        CurrentBalance = newCurrentBalance;
        AccountType = newAccountType;
        CdApy = newCdApy;
        CdWithdrawalPenalty = newCdWithdrawalPenalty;
    }

    public override void AccountWithdrawal(double newWithdrawal)
    {
        Console.WriteLine($"You have requested to make a withdrawal in the amount of ${newWithdrawal} from Account Number {AccountId}.");
        
        double feeAssessedWithdrawal = CdWithdrawalFee(newWithdrawal) + newWithdrawal;
        if (feeAssessedWithdrawal < CurrentBalance)
        {
            double postWithdrawalBalance = (CurrentBalance - feeAssessedWithdrawal);
            CurrentBalance = postWithdrawalBalance;
            Console.WriteLine($"Your new balance is : ${CurrentBalance}\n(A fee of ${CdWithdrawalFee(newWithdrawal)} was assessed for early withdrawal).");
        }
        else if (feeAssessedWithdrawal == CurrentBalance)
        {
            Console.WriteLine($"A withdrawal in the amount of ${newWithdrawal}(plus your early withdrawal fee of {CdWithdrawalFee(newWithdrawal)}) would close your account.\nPlease visit your nearest bank branch to speak with an account specialist to proceed.");
        }
        else
        {
            Console.WriteLine($"You have insufficient funds to make this withdrawal.\nYour current balance is : ${CurrentBalance}\nPlease make a withdrawal of equal to or less than ${((CurrentBalance-CdWithdrawalFee(CurrentBalance))-1)} to proceed.");
        }        
    }

    public double EstimatedApy()
    {
        return (CurrentBalance*CdApy);
    }

    public double CdWithdrawalFee(double cdWithdrawalCheck) 
    {
        return (cdWithdrawalCheck * CdWithdrawalPenalty);
    }

    public override string? ToString ()
    {
        return $"\nAccount Number : {AccountId}\nAccount Balance : ${CurrentBalance}\nAccount Type : {AccountType}\nCD APY : ${EstimatedApy()} (based on Current Balance and Interest Rate)\nEarly Withdrawal Fee : up to ${CdWithdrawalFee(CurrentBalance)}"; 
    }
   }    //end class
}   //end Namespace