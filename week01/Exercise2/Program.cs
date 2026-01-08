using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your percentage score: ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);

        string letter = "";
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string sign = "";
        int lastDigit = percentage % 10;
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if ((letter == "A" && sign == "+") || letter == "F")
        {
            sign = "";
        }
        Console.WriteLine($"Your final letter grade is {letter}{sign}");

        if (percentage >= 70)
        {
            Console.WriteLine("Well done! You have successfully passed the course.");
        }
        else
        {
            Console.WriteLine("Keep trying! You can do better next time.");
        }
    }
}