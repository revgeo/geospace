using System;
using System.Collections.Generic;
using System.IO;


namespace week5Competency
{
    class Program
    {
        static void Main(string[] args)
        {
            Corporate corporate1 = new Corporate (1111, "corporate1@corpocorp.com", "c", 250, 5);
            NonProfit nonProfit1 = new NonProfit (3333, "nonprofit1@nonprofit.org", "n", 125, 5);
            Executive executive1 = new Executive (5555, "executive1@exectutive.com", "e", 500, 10);
            Regular regular1 = new Regular (7777,"regular1@regular1.net", "r", 75, 2);


            // Console.Write(regular1.ToString());
            // Console.ReadKey();
            // regular1.Purchase(5000);
            // Console.ReadKey();
            // Console.Write(regular1.ToString());
            // Console.ReadKey();
            // regular1.Purchase(1000);
            // Console.ReadKey();
            // Console.Write(regular1.ToString());
            // Console.ReadKey();
            // regular1.Purchase(2000);
            // Console.ReadKey();
            // Console.Write(regular1.ToString());
            // Console.ReadKey();
            // regular1.Return(9000);
            // Console.ReadKey();
            // Console.Write(regular1.ToString());
            // Console.ReadKey();

            // Console.Write($"\nMember ID : {nonProfit1.MemberID}\nEmail : {nonProfit1.MemberEmail}\nType : {nonProfit1.MemberType}\nAnnual Membership Fee : {nonProfit1.MembershipFee}\nCashBackRewards Rate : {nonProfit1.NonProfitRate}\n");
            // Console.ReadKey();
            // Console.Write($"\nMember ID : {executive1.MemberID}\nEmail : {executive1.MemberEmail}\nType : {executive1.MemberType}\nAnnual Membership Fee : {executive1.MembershipFee}\nCashBackRewards Rate : {executive1.ExecutiveRate}\n");
            // Console.ReadKey();
            // Console.Write($"\nMember ID : {regular1.MemberID}\nEmail : {regular1.MemberEmail}\nType : {regular1.MemberType}\nAnnual Membership Fee : {regular1.MembershipFee}\nCashBackRewards Rate : {regular1.RegularRate}\n");
            // Console.ReadKey();
            


        }//end Main
    }//end class
}//end namespace