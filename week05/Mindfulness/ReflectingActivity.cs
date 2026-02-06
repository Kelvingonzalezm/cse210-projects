using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity helps you think deeply about experiences where you demostrated courage, persistence, or personal growth.";

        _prompts = new List<string>()
        {
            "Recall a moment when you overcame a personal challenge.",
            "Think about a time when you showed kindness without expecting anything in return.",
            "Remember an experience where you stayed strong during a difficult situation.",
            "Think of a moment when you helped improve someone else's day."
        };

        _questions = new List<string>()
        {
            "What stands out most to you about this experience?",
            "What thoughts or emotions did you notice at the time?",
            "What strengths did you rely on during this moment?",
            "How did this experience impact you afterward?",
            "What did this situation teach you about yourself?",
            "How might this experience guide future decisions?",
            "What would you do similarly or differently next time?",
            "Why is this memory important to you today?"
        };
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine();
        Console.WriteLine("Reflect on the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine();
        Console.WriteLine("Press Enter when you are ready to continue.");
        Console.ReadLine();
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();

        int timePassed = 0;

        while (timePassed < _duration)
        {
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(5);
            Console.WriteLine();

            timePassed += 5;
        }

        DisplayEndingMessage();
    }
}