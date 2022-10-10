using System;
using System.Collections.Generic;
using System.IO;


namespace week5Competency
{
    public class Corporate : Member
    {
        public int CorporateRate { get; set; }

        public Corporate() : base ()
        {
            // MemberID = 0;
            // MemberEmail = "";
            // MemberType = "";
            // MembershipFee = 0;
            // CorporateRate = 0;
        }

        public Corporate(int newMemberID, string newMemberEmail, string newMemberType, int newMembershipFee, int newCorporateRate) : base()
        {
            MemberID = newMemberID;
            MemberEmail = newMemberEmail;
            MemberType = "Corporate";
            MembershipFee = newMembershipFee;
            CorporateRate = newCorporateRate;
        }





        public override void CashBackRewards(double newCashBackRewards)
        {
            
        }

        public override string? ToString ()
        {
            return $"\nMember ID : {MemberID}\nEmail : {MemberEmail}\nType : {MemberType}\nAnnual Membership Fee : ${MembershipFee}\nTotal Monthly Purchases : ${TotalMonthlyPurchases}\nCashBackRewards Rate : {CorporateRate}\n";
        }

    }//end class

}//end namespace