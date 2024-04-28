using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        // random number to guess
        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1,100);

        // Asking the user the magic number
        // Console.Write("What is the magic number? ");
        // string userInput = Console.ReadLine();
        // int magicNumber = int.Parse(userInput);

        // Asking the user the guess number
        Console.Write("What is your guess? ");
        int guessNumber = int.Parse(Console.ReadLine());

        // Variable of the loop
        bool quit = false;     // Boolean.FalseString;
        // Console.WriteLine(quit);
        string repeatGame = "";
        int sum = 0;

        while (quit != true)
        {   
            if (magicNumber > guessNumber)
            {
                Console.WriteLine("Higher");
                Console.Write("What is your guess? ");
                guessNumber = int.Parse(Console.ReadLine());
            }
            else if (magicNumber < guessNumber)
            {
                Console.WriteLine("Lower");
                Console.Write("What is your guess? ");
                guessNumber = int.Parse(Console.ReadLine());
            }
            else if (magicNumber == guessNumber)
            {
                Console.WriteLine("You guessed it!");
                Console.Write("Do you want to play again? ");
                repeatGame = Console.ReadLine();
                if (repeatGame == "yes")
                {
                    magicNumber = randomNumber.Next(1,100);
                    Console.Write("What is your guess? ");
                    guessNumber = int.Parse(Console.ReadLine());
                    sum = 0;
                }
                else
                {
                    quit = true;
                }

            }
            // counting loops  
                sum ++;
        }
        // Counting results
        Console.WriteLine($"You have tried {sum} times.");
        


    }
}