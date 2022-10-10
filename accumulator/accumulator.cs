// Get the count of numbers (Integers) from the User. 
// Verify that the number is between 2 and 10 (Including 2 and 10)
// Get the numbers (Integers) from the User.
// Verify that the numbers input are integers
// Total the numbers
// Display the Sum Total
// Brought to you by Brian, Geoff, Nithya
// Created on 09/14/2022
using System;

    namespace Accumulator
    {
        class Program
        {
            static void Main(string[] args)
            {

        // Get the count of Numbers(Integers) from the User.
                int numberOfItems = 0;
                do
                {
                    Console.Write("Please enter a number between 2 and 10 (including 2 and 10) : ");
                    numberOfItems = Convert.ToInt32(Console.ReadLine());

        // Verify that the number is between 2 and 10 (Including 2 and 10)
                    if (numberOfItems < 2 || numberOfItems > 10)
                        {
                            Console.WriteLine("The number you entered is invalid.");
                        }
                } while (numberOfItems < 2 || numberOfItems > 10 );

        // Get the numbers(Integers) from the User.

            //First initialize all the variables we're going to use

                int totalNumber = 0;                                        //this is the variable that will accumulate all the variables
                int getNumber = 0;                                          //number obtained from the user after verifying integer
                double enterNumber = 0;                                     //actaul user input before verification
                double remainder = 0;                                       //variable used for checking integer
                int counter = 1;                                            //the count of numbers being input

            //Second, enter a loop that will grab each number
                do
                {
                    Console.Write("Please enter {0} number : ", counter);
                    enterNumber = Convert.ToDouble(Console.ReadLine());     //get a number
                    remainder = enterNumber % 1;                            //formula to determine whether is an integer
                    if (remainder == 0)                                     //if it is an integer, do the following:
                    {
                        getNumber = Convert.ToInt32(enterNumber);               // convert the number to integer, assigning to getNumber
                        totalNumber = totalNumber + getNumber;                  //adding to total
                        counter++;                                              //incrementing number of counter
                    }
                    else                                                    //wasn't an integer, give error message
                    {
                        Console.WriteLine("Please enter a whole number");
                    }
                } while (counter <= numberOfItems);

        // Display the Sum Total
             Console.WriteLine("Count of numbers : {0} ", numberOfItems);              
             Console.WriteLine("Total of the numbers Entered : {0} ", totalNumber);  
            } // End Main
        } // End Class
        
    } // End NameSpace   
