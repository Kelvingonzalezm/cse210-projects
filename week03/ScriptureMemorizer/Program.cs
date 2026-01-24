// Creativity Requirement:
// Uses a library of scriptures and selects one at random.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<(Reference, string)> scriptures = new List<(Reference, string)>
        {
            (new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            (new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            (new Reference("Psalm", 23, 1), "The Lord is my shepherd; I shall not want.")
        };

        Random random = new Random();
        int index = random.Next(scriptures.Count);

        Reference reference = scriptures[index].Item1;
        string text = scriptures[index].Item2;

        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll the words are hidden. End of program.");
                break;
            }

            Console.WriteLine("\nPress ENTER to hide or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }
            scripture.HideRandomWords(3);

        }
    }
}