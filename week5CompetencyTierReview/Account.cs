using System;
using System.Collections.Generic;
using System.IO;


namespace week5Competency
{
    public abstract class Member
    {
        public int MemberID { get; set; }
        
        public string? MemberEmail { get; set; }

        public string? MemberType { get; set; }

        public int MembershipFee { get; set; }

        public int TotalMonthlyPurchases { get; set; }

        public Member()
        {
            // MemberID = 0;
            // MemberEmail = "";
            // MemberType = "";
            // MembershipFee = 0;
        }

        public Member(int newMemberID, string newMemberEmail, string newMemberType, int newMembershipFee)
        {
            MemberID = newMemberID;
            MemberEmail = newMemberEmail;
            MemberType = newMemberType;
            MembershipFee = newMembershipFee;
        }
        
        public void Purchase(int newPurchase)
        {
                TotalMonthlyPurchases += newPurchase;
                Console.WriteLine($"You have made a purchase in the amount of ${newPurchase} for Member Number : {MemberID}\nThis member's new monthly purchase total is : ${TotalMonthlyPurchases}");
        }

        public void Return(int newReturn)
        {
                TotalMonthlyPurchases -= newReturn;
                Console.WriteLine($"You have proccessed a return, and issued a refund in the amount of ${newReturn} for Member Number : {MemberID}\nThis member's new monthly purchase total is : ${TotalMonthlyPurchases}");
        }

        public abstract void CashBackRewards(double newCashBackRewards);

        public virtual new string? ToString ()
        {
            return $"\nMember ID : {MemberID}\nEmail : {MemberEmail}\nType : {MemberType}\nAnnual Membership Fee : ${MembershipFee}\nTotal Monthly Purchases : ${TotalMonthlyPurchases}\n";
        }
    }//end class

}//end namespace

