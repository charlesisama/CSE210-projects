using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project: Functions.");
        
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);

    }

    //display function
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program");
    }

    //prompt username function
    static string PromptUserName ()
    {
        Console.WriteLine(" Please Enter Username");
        string prompt = Console.ReadLine();
        return prompt;
    }

    //prompt user number
    static int PromptUserNumber ()
    {
        Console.WriteLine("Please Enter your favourite Number");
        int prompt = int.Parse(Console.ReadLine());
        return prompt;
    }

    //Square number
    static int SquareNumber (int number)
    {
        int square = number * number;
        return square;
    }

    //display results
    static void DisplayResult (string username, int squaredNumber)
    {
        Console.WriteLine($"{username}, the square of your number is {squaredNumber}");
    }
}