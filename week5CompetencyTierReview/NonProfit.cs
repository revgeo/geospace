using System;
using System.Collections.Generic;
using System.IO;


namespace week5Competency
{
    public class NonProfit : Member
    {
        public int NonProfitRate { get; set; }

        public NonProfit() : base ()
        {
            // MemberID = 0;
            // MemberEmail = "";
            // MemberType = "";
            // MembershipFee = 0;
            // NonProfitRate = 0;
        }

        public NonProfit(int newMemberID, string newMemberEmail, string newMemberType, int newMembershipFee, int newNonProfitRate) : base()
        {
            MemberID = newMemberID;
            MemberEmail = newMemberEmail;
            MemberType = "Non-Profit";
            MembershipFee = newMembershipFee;
            NonProfitRate = newNonProfitRate;
        }





        public override void CashBackRewards(double newCashBackRewards)
        {
            
        }

        public override string? ToString ()
        {
            return $"\nMember ID : {MemberID}\nEmail : {MemberEmail}\nType : {MemberType}\nAnnual Membership Fee : ${MembershipFee}\nTotal Monthly Purchases : ${TotalMonthlyPurchases}\nCashBackRewards Rate : {NonProfitRate}\n";
        }
    }//end class

}//end namespace