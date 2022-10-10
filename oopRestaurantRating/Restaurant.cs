using System;

namespace ClassPractice
{
    public class Restaurant
    {
        private string? name;//field - private
        public string? Name//property - public
        {
            get { return name; }
            set { name = value; }
        }
        
        private string rating;//field - private
        public string Rating//property - public
        {
            get { return rating; }
            set { rating = value; }
        }

        public Restaurant()//default constructor
        {
            Name = "You have not indicated a restaurant.\n";
            Rating = "You have not entered a rating.\n";
        }
        public Restaurant(string restaurantName, string restaurantRating)//parameterized constructor
        {
            name = restaurantName;
            rating = restaurantRating;
        }

        public void RestaurantMotto()
        {
            Console.WriteLine("The customer is always right IN MATTERS OF TASTE!");
        }
    }
}
