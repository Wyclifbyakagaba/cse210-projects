using System;

public class PromptGenerator
{
    private string[] _prompts =
    {
        "What made you happy today?",
        "Describe a challenge you faced.",
        "Write about a memorable moment.",
        "What are you grateful for today?",
        "What is a goal you want to achieve?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Length);
        return _prompts[index];
    }
}