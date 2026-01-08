using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the secret number: ");
        int magicNumber = int.Parse(Console.ReadLine());

        Console.Write("Try to guess the number: ");
        int guess = int.Parse(Console.ReadLine());

        while (guess != magicNumber)
        {
            if (guess < magicNumber)
            {
                Console.WriteLine("Too low, try again!");
            }
            else
            {
                Console.WriteLine("Too High, try again!");
            }
            Console.Write("Try to guess the number: ");
            guess = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("Congratulations! You got it!");
    }
}