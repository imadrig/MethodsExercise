using System;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)

        {
            string name = Name();

            string favoriteColor = FavoriteColor();

            string favoriteAnimal = FavoriteAnimal();

            string favoriteBand = FavoriteBand();

            Console.WriteLine($"My name is {name}.");
            Console.WriteLine($"I once met a {favoriteAnimal} in a {favoriteColor} shirt that loved listening to {favoriteBand}. It was a great day!");
        }

        static string Name()
        { 
        Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            return name;
        }

        static string FavoriteColor()
        {
            Console.WriteLine("What is your favorite color?");
            string favoriteColor = Console.ReadLine();
            return favoriteColor;
        }

        static string FavoriteAnimal()
        {
            Console.WriteLine("What is your favorite animal?");
            string favoriteAnimal = Console.ReadLine();
            return favoriteAnimal;
        }

        static string FavoriteBand()
        {
            Console.WriteLine("What is your favorite band?");
            string favoriteBand = Console.ReadLine();
            return favoriteBand;
        }





    }
}
