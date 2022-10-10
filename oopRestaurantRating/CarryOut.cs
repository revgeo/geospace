using System;

namespace ClassPractice
{
    class CarryOut : Restaurant
    {
        private string? address;//field - private
        public string? Address//property - public
        {
            get { return address; }
            set { address = value; }
        }
        
        public CarryOut() : base()
        {
            Address = "Nothing to return";
        }
        public CarryOut(string restaurantName, string restaurantRating, string restaurantaddress) : base(restaurantName, restaurantRating) //defined constructor
        {
            Address = restaurantaddress;  
        }

        public new void RestaurantMotto()
        {
            Console.WriteLine("The customer is NEVER right IN MATTERS OF CARRYOUT!");
        }

        public override string ToString()
        {
            return Address;
        }
    }
}
