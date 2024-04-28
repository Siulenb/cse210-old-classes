using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Declare the list of numbers
        List<int> numbers = new List<int>();

        // Variables
        bool quit = false;
        // int enterNumber = 0;
        int count = 0;
        int largestNumber = 0;
        int smallestNumber = 99999999;
        int total = 0;
        // int sumNumber = 0;

        // Intro message
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (quit != true)
        {
            Console.Write("Enter number: ");
            int enterNumber = int.Parse(Console.ReadLine());

            if (largestNumber < enterNumber)
            {
                largestNumber = enterNumber;
            }
            if (smallestNumber > enterNumber && enterNumber > 0)
            {
                smallestNumber = enterNumber;
            }
            if (enterNumber != 0)
            {
                numbers.Add(enterNumber);
            }
            else if (enterNumber == 0)
            {
                quit = true;
                count--;
            }
            count++; // count the list numbers.count;
        }
        // looping to sum
        foreach (int sumNumber in numbers)
        {
            total += sumNumber;
        }

        // The average number
        float average = ((float)total) / count;

        // Results
        Console.WriteLine($"The total sum of the list is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest number is: {smallestNumber}");

    }
}