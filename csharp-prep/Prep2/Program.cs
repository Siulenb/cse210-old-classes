using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string yourGrade = " ";

        if (grade >= 90)
        {
            yourGrade = "A";
            // Console.WriteLine($"Congratulations! You have passed with {yourGrade}");
        }
        else if (grade >= 80)
        {
            yourGrade = "B";
            // Console.WriteLine($"Congratulations! You have passed with {yourGrade}");
        }
        else if (grade >= 70)
        {
            yourGrade = "C";
            // Console.WriteLine($"Congratulations! You have passed with {yourGrade}");
        }
        else if (grade >= 60)
        {
            yourGrade = "D";
            // Console.WriteLine($"Sorry, you can do it better next time: {yourGrade}");
        }
        else if (grade <= 60)
        {
            yourGrade = "F";
            // Console.WriteLine($"Sorry, you can do it better next time: {yourGrade}");
        }

        //Stretch 1
        string symbol = " ";
        int lastDigit;
        lastDigit = grade % 10;
        if (lastDigit >= 7)
        {
            symbol = "+";
        }
        else if (lastDigit < 3)
        {
            symbol = "-";
        }
        else
        {
            symbol = "";
        }

        if (grade >= 94 || grade < 60)
        {
            Console.WriteLine($"Your grade is: {yourGrade}");
        }
        else
        {
            Console.WriteLine($"Your grade is: {yourGrade}{symbol}");
        }
        

        if (grade >=70)
        {
            Console.WriteLine("Congratulations! You have passed.");
        }
        else
        {
            Console.WriteLine("Sorry, You can do it better next time.");
        }






    


    }
}