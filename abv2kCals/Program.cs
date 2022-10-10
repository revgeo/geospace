using System;

namespace abv2kcals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Value (ABV)  : ");
            double abv = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input Value (Ounces)  : ");
            double ounces = Convert.ToDouble(Console.ReadLine());

            double kcals = abv*2.5*ounces; 

            Console.WriteLine("There are approxiamtely {0} kcals in {1} ounces of a {2} ABV Beer", kcals, ounces, abv);
            Console.ReadKey();
        }
    }
}