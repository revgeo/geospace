// ok...  record collector

// Main menu:
// "what to do?: 
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
// 			Y > repeat Submenu - set counter to increase Class Album var name index - look into Lists
// 			N > mainmenu

// Default constructor
// 	return "no info" for each blank field"

// Use Switch statement for menu options
// As stated, use Methods for each menu option

using System;
using System.IO;
using System.Linq;

namespace recordCollector
{
    class Album
    {
    //fields and properties
        private string? title;   //field
        public string? Title        //
        {                           //
            get { return title; }   ////property
            set { title = value; }  //
        }                           //

        private string? artist;   
        public string? Artist        
        {                           
            get { return artist; }   
            set { artist = value; }  
        }

        private int year;  
        public int Year       
        {                           
            get { return year; }   
            set { year = value; }  
        }

        private string? genre;   
        public string? Genre        
        {                           
            get { return genre; }   
            set { genre = value; }  
        }

        private double rating;   
        public double Rating           
        {                           
            get { return rating; }  
            set { rating = value; } 
        }

        public Album ()
        {
        }
        public Album(string albumTitle, string albumArtist, int albumYear, string albumGenre, double albumRating)//defined Constructor
        {
            Title = albumTitle;
            Artist = albumArtist;
            Year = albumYear;
            Genre = albumGenre;
            Rating = albumRating;
        }

        public override string ToString()
        {
            return 
                $"\nTitle : {Title}"
                +$"\nArtist : {Artist}\n"
                +$"\nYear : {Year}"
                +$"\nGenre : {Genre}"
                +$"\nRating : {Rating}";
        }
        // public override string ToString() 
        // {
        //     return ($"Album Name: {this.Title}\nAlbum Artist: {this.Artist}\nYear: {this.Year}\nGenre: {this.genre}\nRating: {this.rating}out of 5 Stars");
        // }
    }
}
