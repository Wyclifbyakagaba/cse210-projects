using System;

public class PromptGenerator
{
    private string[] _prompts = new string[]
    {
        "What made you happy today?",
        "Describe a challenge you overcame.",
        "What did you learn today?",
        "What are you grateful for?",
        "Write about someone who helped you."
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Length);
        return _prompts[index];
    }
}