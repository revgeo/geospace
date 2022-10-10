using System;

namespace ClassPractice
{
    class Delivery : Restaurant
    {
        private string? phoneNumber;//field - private
        public string? PhoneNumber//property - public
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        
        public Delivery() : base()
        {
            PhoneNumber = "Nothing to return";
        }
        public Delivery(string restaurantName, string restaurantRating, string restaurantPhoneNumber) : base(restaurantName, restaurantRating) //defined constructor
        {
            PhoneNumber = restaurantPhoneNumber;  
        }

        public new void RestaurantMotto()
        {
            Console.WriteLine("The customer is NEVER right IN MATTERS OF DELIVERY!");
        }
    }
}
