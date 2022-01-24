using System;
using System.Collections.Generic;


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




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var myBird = new Bird();

            myBird.Color = "blue";
            myBird.Fast = "40 miles per hour";
            myBird.Eagle = "american symbol";
            myBird.IsCanFly = true;
            myBird.Age = 4;
            myBird.LegCount = 2;

            var kingcobra = new Reptile()
            {
                IsAirBreathing = true,
                KindCobra = true,
                Color = "red",
                LegCount = 4,
                Age = 10,

            };

            //Animal myAnimals = new Animal() { myBird, kingcobra };
            var myAnimals = new List<Animal>()
             { myBird,kingcobra};

            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"animalsIsAlive");
                Console.WriteLine($"Age:{animal.Age} years old");
                Console.WriteLine($"It has {animal.LegCount}legs");
                Console.WriteLine($"It lives by {animal.LandSeaAir}");
                Console.WriteLine();
            }

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
