using System;

public class Entry
{
    public string Date { get; private set; }
    public string Prompt { get; private set; }
    public string Text { get; private set; }
    public string Mood { get; private set; }

    public Entry(string date, string prompt, string text, string mood)
    {
        Date = date;
        Prompt = prompt;
        Text = text;
        Mood = mood;
    }

    public void Display()
    {
        Console.WriteLine($"[{Date}]");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Text}");
        Console.WriteLine($"Mood: {Mood}");
        Console.WriteLine("-----------------------");
    }
}
