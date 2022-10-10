// ok...  record collector

// Main menu:
// "what to do?: done
// "Enter new album info?"
// "Update album info?"
// "Save album collection?"
// "Load album collection?"
// "Exit"

// 	Y: Submenu
// 		Gather
// 		{
// 			Album title		|
// 			Album Artist	|
// 			Year			|
// 			Genre			|Separate each as method? to be called for both create and update
// 			Rating		    |
// 			Note?			|
// 		}
// 		>"Do you have another album to enter?
// 			Y > repeat Submenu - set counter to increase Class Album var name index?
// 			N > mainmenu

// Default constructor
// 	return "no info" for each blank field"

// Use switch statement for menu options
// As stated, use Methods for each menu option

using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;


namespace recordCollector
{
    class Program
    {
        static void Main(String[]args)
        {
            bool menuChoice;
            int userMenuSelect;
            List<Album> myAlbums = new List<Album>();

            Console.WriteLine("\n     Hello, and welcome to Ramsey's Record 'Rchiver!    \n»»»»»»»»»»»»»»»»»»»»»»»»»»»»««««««««««««««««««««««««««««\n   Please make a selection from the following choices   \n");
            
            do
            {
                do
                {
                    menuChoice = false;

                    Console.WriteLine("1. Enter an album into the 'Rchive");
                    Console.WriteLine("2. Update album info");
                    Console.WriteLine("3. Save your album info");
                    Console.WriteLine("4. Load your curent 'Rchive");
                    Console.WriteLine("5. Exit the 'Rchiver");
                //Collect selection   
                    Console.Write("\n\nEnter selection here : ");

                    userMenuSelect = Convert.ToInt16(Console.ReadLine());
                    menuChoice = 
                        (userMenuSelect == 1 || 
                        userMenuSelect == 2 || 
                        userMenuSelect == 3 || 
                        userMenuSelect == 4 || 
                        userMenuSelect == 5);
                    if (!menuChoice)//force user to choose correct option
                    {
                        Console.WriteLine("\nThe selection you made is invalid.\nPlease select from the available choices.\n");
                    }
                } while (!menuChoice);
                    switch (userMenuSelect)
                    {
                        case 1:
                            string? albumExit;
                            var enterAnother = false;
                            do
                            {
                                Menu1();
                                do 
                                {
                                    Console.WriteLine("Do you have another album to enter (Y/N)?");
                                    albumExit = Console.ReadLine();
                                    enterAnother = 
                                        (albumExit == "N" || albumExit == "n" ||
                                        albumExit == "Y" || albumExit == "y");
                                    if (!enterAnother)
                                    {
                                        Console.WriteLine("The selection you made is invalid.\nPlease select from the available choices.\n");
                                    }
                                } while (!enterAnother);
                            } while (albumExit == "Y" || albumExit == "y");
                            Console.WriteLine("Wrok! ONE MORE TIME!");
                            break;
                        case 2:
                        case 3:
                        case 4:
                            // try
                            // {
                                foreach (var Album in myAlbums)
                                {
                                    Console.WriteLine(Album.ToString);
                                    
                                }
                            // }
                            // catch (Exception)
                            // {
                            //     Console.WriteLine("\n     »»»»»»»«««««««     \nNo album info to display.\n     »»»»»»»«««««««     \n");
                            // }
                            break;
                        case 5:
                            default: Console.WriteLine("\nThanks using Ramsey's Record 'Rchiver. Wrok On!\n");
                            break;
                    }
            
                // Console.ReadKey();
            } while (userMenuSelect !=5 );//end main do loop
        }//end Main

        static void Menu1()
        {
            List<Album> myAlbums = new List<Album>();
            Console.Write("What is the name of the album? : ");
            var albumName = Console.ReadLine();
            Console.Write($"Who recorded the album {albumName}? : ");
            var albumArtist = Console.ReadLine();
            Console.Write($"In what year did the album {albumName} release? : ");
            var albumYear = Convert.ToInt16(Console.ReadLine());
            Console.Write($"In what genre is the album {albumName}? : ");
            var albumGenre = Console.ReadLine();
            Console.Write($"Finally: How many stars, out of 5, would you rate {albumName}? : ");
            var albumRating = Convert.ToDouble(Console.ReadLine());
            Album newAlbum = new Album(albumName, albumArtist, albumYear, albumGenre, albumRating);
            myAlbums.Add(newAlbum);            
        }

    }//end class
}//end namespace
