using System;

namespace VariablePractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------------Exercise 1

            //Name: Michael
            //Favorite Color: Blue
            //Favorite Animal: Walrus
            //Favorite Band: The Beatles

            Console.WriteLine("Hello - What is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}, What is your favorite color?");
            var colorName = Console.ReadLine();

            Console.WriteLine($"{colorName} is an awesome color.  What is your favorite animal?");
            var animalName = Console.ReadLine();

            Console.WriteLine($"I love the {animalName}. Who is your favorite band?");
            var bandName = Console.ReadLine();

            Console.WriteLine($"Last week {userName} went to the store and bought some {animalName}.");
            Console.WriteLine($"When I got home {userName} listened to some music by {bandName}");
            Console.WriteLine($"I was so {colorName} this morning that I took a {animalName} this afternoon");
            Console.WriteLine($"I wish {bandName} had a {animalName}, as I had a lot of {animalName} to do today");

            //This is all variable practice........

        }
    }
}
