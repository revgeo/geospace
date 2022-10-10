using System;

namespace ClassPractice
{
    class Program
    {
        static void Main (string[]args)
        {
            Restaurant cockys = new Restaurant ("Cocky's", "5");
            Console.WriteLine($"I gave {cockys.Name} a {cockys.Rating} out of 5 stars!");
            cockys.RestaurantMotto();

            CarryOut vincenzos = new CarryOut ("Vincenzos", "5", "535 W Harvest Dr.");
            Console.WriteLine($"I gave {vincenzos.Name} a {vincenzos.Rating} out of 5 stars! {vincenzos.Name}'s address is {vincenzos.Address}");
            vincenzos.RestaurantMotto();
            Console.WriteLine(vincenzos);

            // Delivery lasMargaritas = new Delivery ("LasMargaritas", "5", "402.421.7070");
            // Console.WriteLine($"I gave {lasMargaritas.Name} a {lasMargaritas.Rating} out of 5 stars! {lasMargaritas.Name}'s phone number is {lasMargaritas.PhoneNumber}");
            // lasMargaritas.RestaurantMotto();

            // DineIn dLeons = new DineIn ("D'Leons", "5", "24 Hours");
            // Console.WriteLine($"I gave {dLeons.Name} a {dLeons.Rating} out of 5 stars! {dLeons.Name} is open {dLeons.Hours}.");
            // dLeons.RestaurantMotto();

            CarryOut cBerrys = new CarryOut ();
            cBerrys.RestaurantMotto();

        }//end main
    }//end program    
}//
