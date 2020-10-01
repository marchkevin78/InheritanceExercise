using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class

            var myBird = new Bird();
            myBird.WingColor = "blue";
            myBird.CanFly = true;
            myBird.WillMigrate = true;
            myBird.BeakLength = 3.5;

            Console.WriteLine($"My bird has {myBird.WingColor} colored wings.\n" +
                $"If you are wondering if my bird is able to fly and/or will migrate, the answers are {myBird.CanFly} and {myBird.WillMigrate}!\n" +
                $"The length of my bird's beak is {myBird.BeakLength} inches.\n");


            var lizard = new Reptile()
            {
                IsColdBlooded = true,
                IsScaly = true,
                Habitat = "swamp",
                CanGrowTail = true
            };

            Console.WriteLine($"Our lizard's habitat is in the {lizard.Habitat}.\n" +
                $"You are probably wondering a few other attributes about our lizard. \n" +
                $"Is our lizard cold blooded? {lizard.IsColdBlooded}\n" +
                $"Is our lizard scaly? {lizard.IsScaly}\n" +
                $"Can our lizard grow a tail? {lizard.CanGrowTail}\n"
                );


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
