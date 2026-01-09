using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage (e.g 50 )? ");
        string score = Console.ReadLine();
        int number = int.Parse(score);
        string letter = "";
        string sign = "";

        if (number >= 90)
        {
           
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";

        }
        else if (number >= 70)
        {
            letter = "C";
         
        }
        else if (number >= 60)
        {
            letter = "D";
            
        }
        else
        {
            letter = "F";
           
        }

        if (number %10 >= 7)
        {
            sign = "+";
        }
        else if (number % 10 < 3 )
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (letter == "A" && sign == "+")
        {
            sign = "";
        }

        if (letter == "F")
        {
            sign = "";
        }

        
            Console.WriteLine($"Your grade for this course is {letter} {sign}. ");


        if (number >= 70)
        {
            Console.WriteLine("Congratulations! you pass the course");
        }
        else
        {
            Console.WriteLine("Stay focus, YOu will get it next time");
        }


    }
}