using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Console.WriteLine("=============================");
        Assignment a1 = new Assignment ("Charles Isama", "Calculus");
        Console.WriteLine(a1.GetSummary());


        Console.WriteLine("=============================");
        MathAssignment a2 = new MathAssignment("Toluwalope", "Trigonometry", "5.3", "1-4");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());


        Console.WriteLine("=============================");
        WrittingAssignment a3 = new WrittingAssignment ("Toluwalope Charles", "Friendship", "Eternal Frienship");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());

    }
}