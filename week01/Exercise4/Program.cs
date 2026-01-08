using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();

        Console.Write("Type a number (enter 0 to stop): ");
        int input = int.Parse(Console.ReadLine());

        while (input != 0)
        {
            numbers.Add(input);
            Console.Write("Type a number (enter 0 to stop): ");
            input = int.Parse(Console.ReadLine());
        }

        int total = 0;
        foreach (int num in numbers)
        {
            total += num;
        }

        double avg = (double)total / numbers.Count;

        int maxValue = numbers[0];
        foreach (int num in numbers)
        {
            if (num > maxValue)
            {
                maxValue = num;
            }
        }

        int minPositive = int.MaxValue;
        foreach (int num in numbers)
        {
            if (num > 0 && num < minPositive)
            {
                minPositive = num;
            }
        }

        numbers.Sort();

        Console.WriteLine($"Total sum: {total}");
        Console.WriteLine($"Average value: {avg}");
        Console.WriteLine($"Highest number entered: {maxValue}");

        if (minPositive == int.MaxValue)
        {
            Console.WriteLine("No positive numbers were entered.");
        }
        else
        {
            Console.WriteLine($"Smallest positive number is: {minPositive}");
        }

        Console.WriteLine("Sorted list: ");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}