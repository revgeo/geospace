using System;

namespace abv2kcals
{
	class Program
	{
		static void Main(string[] args)
/*
		{
			int guess = 0;

			do 
			{
				Console.Write("Input 0 for Heads or 1 for Tails: ");
				guess = Convert.ToInt32(Console.ReadLine());
				if (guess != 0 && guess != 1)
				{
					Console.WriteLine("Please enter a guess of 0 or 1");
				}
			} 
			while (guess != 0 && guess != 1);
		}
*/
		{
      		string firstName = "John ";
      		string lastName = "Doe";
      		string name = string.Concat(firstName, lastName);
      		Console.WriteLine(name);
    	}
	}
}