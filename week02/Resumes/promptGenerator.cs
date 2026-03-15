using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>()
    {
        "What was the best part of your day?",
        "What did you learn today?",
        "Who did you talk to today?",
        "What made you smile today?",
        "What are you grateful for today?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}
