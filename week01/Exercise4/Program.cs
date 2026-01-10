using System;
using System.Globalization;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project: List");

        List<int> numberList = new List<int>();
        int number = 1000000000;

        while (number != 0 )
        {
            Console.Write("Enter the list of numbers(positive or negative). Enter '0' to quit");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
              numberList.Add(number);  
            }           
        }
        
        //Working on the list
        int listLength = numberList.Count;
        int total = 0;
        int maximum = -1;
        int smallest = 10000000;
        float average = 0;

        foreach (int item in numberList)
        {
            total += item;
            average = total / listLength;

            if (item > maximum)
            {
                maximum = item;
            } 
        }

        //stretch challenge
        foreach(int numbers in numberList)
        {
            if (numbers > 0 && numbers < smallest)
            {
                smallest = numbers;
            }
        }


        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The Average is: {average}");
        Console.WriteLine($"The largest number is : {maximum}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        Console.WriteLine("The sorted list is : ");

        numberList.Sort();

        foreach (int num in numberList)
        {
            Console.WriteLine(num);
        }


    }
}