using System;
using System.Collections.Generic;

public class PromptsCreation
{
    public List<string> _prompts;

    public string GetRandomPrompt()
    {
        
        Random randomQuestions = new Random();
        string randomPrompts = _prompts[randomQuestions.Next(_prompts.Count)];

        return randomPrompts;
    }

}