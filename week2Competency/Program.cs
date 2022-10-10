using System;
using System.IO;

// Problem description: You want to maintain a list of the restaurants at which you have dined.

// Requirements/User stories:

// You want to keep track of the name and your review of restaurants (0-5 stars) and you want it to be persistent (stored in a text file).  Provide room for 25 restaurants.
// You want a menu that will provide you the options of doing the following:
// O - Open the user's list of restaurants,
// S - Save the user's list of restaurants
// ----Save them so there are no blank lines in the data file
// C - Add a restaurant and rating,
// ----Make sure the user provides both a restaurant and rating
// ----Make sure to handle the "file full" case
// R - Print a list of all the restaurants and their rating,
// ----Only print a list of the restaurants and ratings - no blank lines in your list
// ----Make sure to handle the case where there are no restaurants in the list
// U - Update the rating for a restaurant,
// D - Delete a restaurant
// Q - Quit the program
// For your initial MVP (Minimum Viable Product), you will implement the O, S, C, R and Q options.
// 2d array of string
// pair restaurant with rating 1-5 stars

// 1 x 2d Array

// Name | Rating
// (nested for loops to gather inputs and assign them to arrays) 

// only access the files to open and

// first, tackle O, S, C, R, Q***

// 1. Menu*******
// 2. Quit
// 3. Look at read data File
// 4. Look at write data file
// 5. Crete array
// 6. Save array to - possible sequential (for each maybe?
// 7. R - If (array is empty, let them know)

// Punch List:
// MENU : DONE
// O : Mostly, none are fully done
// S : Done?
// C : Done
// R : HADONE
// Q : DONE
// 
// 

// DOCUMENT! 
// TEST!

// WORK ON IT TODAY, SUBMIT TODAY.

namespace Week2Competency
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menuChoice;
            string? userMenuSelect;
            string[ , ] restaurantReviews = new string[25, 2];
            string savedRatings = "restaurantRatings.txt";

            Console.WriteLine("\n\n   Hello, and welcome to Ramsey's Restaurant Reviewer!  \n»»»»»»»»»»»»»»»»»»»»»»»»»»»»««««««««««««««««««««««««««««\n   Please make a selection from the following choices   \n\n");
            do
            {

                do
                {                    
                    menuChoice = false;

                    //I liked the menu from the previous exercise, so I re-typed it
                    Console.WriteLine("O: Open your saved restaurant ratings.");
                    Console.WriteLine("S: Save your ratings.");
                    Console.WriteLine("C: Enter your restaurant ratings.");
                    Console.WriteLine("R: Print out a the list of your ratings");
                    Console.WriteLine("U: Update one of your restaurant ratings.");
                    Console.WriteLine("D: Delete a restaraunt rating from your list.");
                    Console.WriteLine("Q: Quit the program.");

                    Console.Write("\n\nEnter selection here : ");

                    userMenuSelect = Console.ReadLine();
                    //defining valid inputs for menu items
                    menuChoice =
                        (userMenuSelect == "O" || userMenuSelect == "o" ||
                        userMenuSelect == "S" || userMenuSelect == "s" ||
                        userMenuSelect == "C" || userMenuSelect == "c" ||
                        userMenuSelect == "R" || userMenuSelect == "r" ||
                        userMenuSelect == "U" || userMenuSelect == "u" ||
                        userMenuSelect == "D" || userMenuSelect == "d" ||
                        userMenuSelect == "Q" || userMenuSelect == "q");
                    if (!menuChoice)//force user to choose correct option
                    {
                        Console.WriteLine("The selection you made is invalid.\nPlease select from the available choices.\n\n\n");
                    }
                    // Console.ReadKey();
                } while (!menuChoice); //end of menu options

                if (userMenuSelect == "O" || userMenuSelect == "o")//defines opening file steps.
                {
                    using (StreamReader ratingsReader = File.OpenText(savedRatings))
                    {
                        string? openRatings = "";
                        var ratingRowCounter = 0;
                        var textCount = 0;
                        while (!ratingsReader.EndOfStream)
                        {
                            openRatings = Console.ReadLine();
                            restaurantReviews[ratingRowCounter, 0] = ratingsReader.ReadLine()!;
                            restaurantReviews[ratingRowCounter, 1] = ratingsReader.ReadLine()!;
                            textCount++;
                        }                        
                    }

                }
                if (userMenuSelect == "S" || userMenuSelect == "s")//writes
                {
                    using (FileStream thisIsTheFileStream = File.Create(savedRatings))
                    {
                        Console.WriteLine($"A file was created with the name {savedRatings}");
                    }
                    using (StreamWriter writeSavedRatings = new StreamWriter(savedRatings))
                        {
                            foreach (string completedRating in restaurantReviews)
                            {
                                writeSavedRatings.WriteLine(completedRating);
                            }
                            Console.WriteLine("And your ratings were successfully written to it.");
                        }
                    
                //end of Filestream work
                }
                if (userMenuSelect == "C" || userMenuSelect == "c")//STILL just working in the array
                {
                    Console.WriteLine("Great, you'd like to enter a restaurant rating!");
                    
                    string? restaurantName; 
                    string? restaurantRating;
                    string? addRatingExit;
                    bool exitRatingAction = false;
                    var ratingRowCounter = 0;

                    do//For loops to iterate through 2d array, and assign values entered by user.
                    {
                        Console.Write("Please, what is the name of the resuarant you'd like to review? : ");
                        restaurantName = Console.ReadLine();
                        restaurantReviews[ratingRowCounter, 0] = restaurantName ?? string.Empty;
                        Console.Write($"Awesome! And how many stars (0-5) would you give {restaurantName}? : ");
                        restaurantRating = Console.ReadLine();
                        restaurantReviews[ratingRowCounter, 1] = restaurantRating ?? string.Empty;
                        ratingRowCounter++;
                        do 
                        {
                            Console.WriteLine("Do you have another rating to enter (Y/N)?");
                        addRatingExit = Console.ReadLine();
                        exitRatingAction = 
                            (addRatingExit == "N" || addRatingExit == "n" ||
                            addRatingExit == "Y" || addRatingExit == "y");
                        if (!exitRatingAction)
                        {
                            Console.WriteLine("The selection you made is invalid.\nPlease select from the available choices.\n");
                        }
                        } while (!exitRatingAction);
                    } while (addRatingExit == "Y" || addRatingExit == "y");
                }
                if (userMenuSelect == "R" || userMenuSelect == "r")
                {

                }
                if (userMenuSelect == "D" || userMenuSelect == "d")
                {

                }
                else
                {
                    Console.WriteLine("\n\n   Thank you for using Ramsey's Restaurant Reviewer!  \n»»»»»»»»»»»»»»»»»»»»»»»»»»»«««««««««««««««««««««««««««\n                  Have a great day.                  \n\n");
                }
            } while (!(userMenuSelect=="Q") && !(userMenuSelect=="q"));//end main do loop
            Console.ReadKey();
        }//end main
    }//end class
}//end namespace