using System;
using System.Collections.Generic;
using System.IO;


public class Journal
{

    public List<Entry> _entries;


    
    public void AddEntry(Entry newEntry)
    {
        
        _entries.Add(newEntry);
        
    }

    public void DisplayAll()
    {
        foreach (Entry line in _entries)
        {
            Console.WriteLine(line);
        }
    }

    public void LoadTheFile(string file)
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

    public void SaveTheFile(string file)
    {   
        file = "ListOfEntries.txt";

        using (StreamWriter outputFile = new StreamWriter (file))
        {   
            
            foreach (Entry info in _entries)
            {
                outputFile.WriteLine(info);
            }
            
            
            
        }
        
    }

}