using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        string userChoice = "";

        while (userChoice != "5")
        {
            DisplayMenu();
            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    CreateEntry(myJournal, promptGen);
                    break;

                case "2":
                    myJournal.ShowJournal();
                    break;

                case "3":
                    Console.Write("File name to save: ");
                    myJournal.Save(Console.ReadLine());
                    break;

                case "4":
                    Console.Write("File name to load: ");
                    myJournal.Load(Console.ReadLine());
                    break;

                case "5":
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Please choose a valid option.");
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine();
        Console.WriteLine("=== Journal Menu ===");
        Console.WriteLine("1 - New Entry");
        Console.WriteLine("2 - Display Journal");
        Console.WriteLine("3 - Save Journal");
        Console.WriteLine("4 - Load Journal");
        Console.WriteLine("5 - Exit");
        Console.Write("Select an option: ");
    }

    static void CreateEntry(Journal journal, PromptGenerator generator)
    {
        string prompt = generator.GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write("> ");
        string response = Console.ReadLine();

        // Additional feature: now we also store how the user is feeling today 
        Console.Write("How do you feel today? ");
        string mood = Console.ReadLine();

        string date = DateTime.Now.ToString("yyyy-MM-dd");
        Entry newEntry = new Entry(date, prompt, response, mood); //using the new Mood property
        journal.AddEntry(newEntry);
    }
}