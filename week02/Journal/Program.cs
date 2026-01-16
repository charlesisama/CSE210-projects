using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator randomPrompt = new PromptGenerator();
        Journal newJournal = new Journal();

        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("\nWelcome to the Journal Program!");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                Entry newEntry = new Entry();
                string prompt = randomPrompt.GetRandomPrompt();

                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                newEntry._promptText = prompt;
                newEntry._entryText = response;

                newJournal.AddEntry(newEntry);
            }
            else if (choice == "2")
            {
                newJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();
                newJournal.LoadFromFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();
                newJournal.SaveToFile(filename);
            }
        }

        Console.WriteLine("Have a great day!");
    }
}
