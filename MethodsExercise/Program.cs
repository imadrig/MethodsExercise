using System;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)

        {
            //Exercise 1

            string name = Name();

            string favoriteColor = FavoriteColor();

            string favoriteAnimal = FavoriteAnimal();

            string favoriteBand = FavoriteBand();

            Console.WriteLine($"My name is {name}.");
            Console.WriteLine($"I once met a {favoriteAnimal} in a {favoriteColor} shirt that loved listening to {favoriteBand}. It was a great day!" +
                Environment.NewLine +
                Environment.NewLine);

            //Exercise 2

            int sum = Add(5,10);

            int difference = Subtract(25,13);

            int product = Multiply(3,6);

            int quotient = Divide(100,50);

            int remainder = Modulus(100,3);

            Console.WriteLine($"The results are: {sum}, {difference}, {product}, {quotient}, and {remainder}."); 
        }

        //Exercise 1 Methods
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

        //Exercise 2 Methods


        public static int Add (int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
           return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public static int Modulus(int num1, int num2)
        {
            return num1 % num2; 
        }

    }
}
