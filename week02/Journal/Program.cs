using System;
using System.IO;


class Program
{
    static void Main(string[] args)
    {

        //list of prompts
        List<string> prompts = new List<string>();
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");


        Console.WriteLine("Welcome to the Journal Program!");

        Console.WriteLine("Hi dear, Please select one of the following");

        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        Console.Write("what would you like to do? Enter a number(1-5). ");
        string choice = Console.ReadLine();

        //while loop for user's choice
        while (choice != "5")
        {
            //write a new entry
            if (choice == "1")
            {
                
            }
            //Display current entries
            if (choice == "2")
            {
                
            }
            //load enties from a file
            if (choice == "3")
            {
                
            }
            //save entries to file
            if (choice == "4")
            {
                
            }

        }

        Console.WriteLine("Do have a great day!");

    }
}