using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _promptOptions;
    private Random _random;

    public PromptGenerator()
    {
        _random = new Random();
        _promptOptions = new List<string>
        {
            "What made me smile today?",
            "What challenge did I overcome today?",
            "Who helped me today and how?",
            "What emotion stood out the most today?",
            "What is one thing I learned today?"
        };
    }

    public string GetRandomPrompt()
    {
        int number = _random.Next(0, _promptOptions.Count);
        return _promptOptions[number];
    }
}