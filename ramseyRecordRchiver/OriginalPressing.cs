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
    class OriginalPressing : Album
    {
    //fields and properties
        private string? condition;   //field
        public string? Condition        //
        {                           //
            get { return condition; }   ////property
            set { condition = value; }  //
        }                           //
        
        public OriginalPressing () : base()
        {
        }
        public OriginalPressing(string albumTitle, string albumArtist, int albumYear, string albumGenre, double albumRating, string albumCondition) : base(albumTitle, albumArtist, albumYear, albumGenre, albumRating)  //defined Constructor
        {
            Title = albumTitle;
            Artist = albumArtist;
            Year = albumYear;
            Genre = albumGenre;
            Rating = albumRating;
            Condition = albumCondition;
        }

        public override string ToString()
        {
            return base.ToString + $"\nCondition : {Condition}";
        }
        // public override string ToString() 
        // {
        //     return ($"Album Name: {this.Title}\nAlbum Artist: {this.Artist}\nYear: {this.Year}\nGenre: {this.genre}\nRating: {this.rating}out of 5 Stars");
        // }
    }
}
