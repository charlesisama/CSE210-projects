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

        //SIGN
    
        int lastDigit = number % 10;

        if (letter != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Special cases
        if (letter == "A" && number!=100 &&  lastDigit < 3)
        {
            sign = "-";  
        }

        if ((letter == "A" && lastDigit>3) || number==100)
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