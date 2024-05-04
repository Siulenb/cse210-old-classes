using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
       List<string> listOfPrompts = new List<string>
       {
        "What was the best part of my day? ",
        "Did something funny happen? ",
        "What was the impression from the Lord? ",
        "What miracles were you able to notice? ",
        "Did you learn something today? "
       };
       // Variable
       bool quit = false;
       List<Entry> entries = new List<Entry>();
    

        Console.WriteLine("Welcome to your journal program!");

        while (quit != true)
        {

            DisplayMessage();
            // if statement to trigger the option
            int optionNumber = SelectedNumber();
            if (optionNumber == 1)
            {
                PromptsCreation prompts1 = new PromptsCreation();
                prompts1._prompts = listOfPrompts;
                string randomPrompt = prompts1.GetRandomPrompt();
                Console.Write(randomPrompt);
                string userInput = Console.ReadLine();
                

                Entry entry1 = new Entry();
                entry1._date = GetDateTime();
                entry1._promptText = randomPrompt;
                entry1._entryText = userInput;
                entry1.Display();

                Journal journal0 = new Journal();
                journal0.AddEntry(entry1);

                // entries.Add(entry1);
                
            }
            else if (optionNumber == 2)
            {
                Journal journal1 = new Journal();
                journal1.DisplayAll();

            }
            else if (optionNumber == 3)
            {
                Journal journal3 = new Journal();
                journal3.LoadTheFile("ListOfEntries.txt");
                // LoadTheFile2("ListOfEntries.txt");

            }
            else if (optionNumber == 4)
            {
                Journal journal3 = new Journal();
                journal3.SaveTheFile("ListOfEntries.txt");
                // SaveTheFiles2(entries);
            }
            else if (optionNumber == 5)
            {
                quit = true;
            }


            
        }

    }   


    public static string GetDateTime()
    {
        DateTime todayDate = DateTime.Today;
        string date = todayDate.ToString("d");
        
        return date;
    }


    public static void DisplayMessage()
    {
        
        Console.WriteLine("Please select one of the following options:");
        Console.WriteLine("1. Write\r\n2. Display\r\n3. Load\r\n4. Save\r\n5. Quit");

    }

    public static int SelectedNumber()
    {
        Console.Write("What would you like to do? (type the number) ");
        int optionNumber = int.Parse(Console.ReadLine());

        return optionNumber;
    }


    public static void SaveTheFiles2(List<Entry> entries)
    {
        string file = "ListOfEntries.txt";
        using (StreamWriter outputFile = new StreamWriter (file))
        {
            foreach (Entry p in entries)
            {
                outputFile.WriteLine($"Date: {p._date} - Prompt: {p._promptText} {p._entryText}");
            }
                
        }
        Console.WriteLine("Information saved.");
    }

    public static void LoadTheFile2(string file)
    {
        
        if (!File.Exists(file))
        {
            Console.WriteLine($"File exists: {File.Exists(file)}");
        }
        else
        {
            string[] lines = File.ReadAllLines(file);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}