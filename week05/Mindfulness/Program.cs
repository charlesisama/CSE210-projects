using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");


        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");

        string choice = Console.ReadLine();

        while (choice != "4")
        {
            if (choice == 1)
            {
                
            }
            if (choice == 2)
            {
                
            }
            if (choice == 3)
            {
                
            }
            else
            {
                Console.WriteLine("Thank you for using the mindfulness program");
            }
        }

    }
}