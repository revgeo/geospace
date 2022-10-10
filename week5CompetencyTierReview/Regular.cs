using System;
using System.Collections.Generic;
using System.IO;


namespace week5Competency
{
    public class Regular : Member
    {
        public int RegularRate { get; set; }

        public Regular() : base ()
        {
            // MemberID = 0;
            // MemberEmail = "";
            // MemberType = "";
            // MembershipFee = 0;
            // RegularRate = 0;
        }

        public Regular(int newMemberID, string newMemberEmail, string newMemberType, int newMembershipFee, int newRegularRate) : base()
        {
            MemberID = newMemberID;
            MemberEmail = newMemberEmail;
            MemberType = "Regular";
            MembershipFee = newMembershipFee;
            RegularRate = newRegularRate;
        }





        public override void CashBackRewards(double newCashBackRewards)
        {
            
        }

        public override string? ToString ()
        {
            return $"\nMember ID : {MemberID}\nEmail : {MemberEmail}\nType : {MemberType}\nAnnual Membership Fee : {MembershipFee}\nTotal Monthly Purchases : {TotalMonthlyPurchases}\nCashBackRewards Rate : {RegularRate}\n";
        }
    }//end class

}//end namespace