using System;
using System.Collections.Generic;
using System.IO;


namespace week5Competency
{
    public class Executive : Member
    {
        public int ExecutiveRate { get; set; }

        public Executive() : base ()
        {
            // MemberID = 0;
            // MemberEmail = "";
            // MemberType = "";
            // MembershipFee = 0;
            // ExecutiveRate = 0;
        }

        public Executive(int newMemberID, string newMemberEmail, string newMemberType, int newMembershipFee, int newExecutiveRate) : base()
        {
            MemberID = newMemberID;
            MemberEmail = newMemberEmail;
            MemberType = "Executive";
            MembershipFee = newMembershipFee;
            ExecutiveRate = newExecutiveRate;
        }





        public override void CashBackRewards(double newCashBackRewards)
        {

        }

        public override string? ToString ()
        {
            return $"\nMember ID : {MemberID}\nEmail : {MemberEmail}\nType : {MemberType}\nAnnual Membership Fee : ${MembershipFee}\nTotal Monthly Purchases : ${TotalMonthlyPurchases}\nCashBackRewards Rate : {ExecutiveRate}\n";
        }
    }//end class

}//end namespace