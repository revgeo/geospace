using System;

namespace ClassPractice
{
    class DineIn : Restaurant
    {
        private string? hours;//field - private
        public string? Hours//property - public
        {
            get { return hours; }
            set { hours = value; }
        }
        
        public DineIn() : base()
        {
            Hours = "Nothing to return";
        }
        public DineIn(string restaurantName, string restaurantRating, string restaurantHours) : base(restaurantName, restaurantRating) //defined constructor
        {
            Hours = restaurantHours;  
        }
        public new void RestaurantMotto()
        {
            Console.WriteLine("The customer is NEVER right!");
        }
    }
}