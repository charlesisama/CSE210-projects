using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project: My Number Game.");
        Random randomGen = new Random();
        int magicNumber = randomGen.Next(1, 101);

        
        int guessInt = -1;
         
        
        while (guessInt != magicNumber)
        {
            Console.Write("What is the guess.");
            guessInt = int.Parse(Console.ReadLine());

            if ( magicNumber < guessInt )
            {
                Console.WriteLine("Go lower");
            }
            else if (magicNumber > guessInt)
            {
                Console.WriteLine("Go higher");
            }
            else
            {
                Console.WriteLine("Congratulations you guessed it!");
            }
               
        }


    }
}