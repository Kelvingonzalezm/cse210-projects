using System;

class Program
{
    static void Main(string[] args)
    {
        ShowGreeting();
        Console.WriteLine();

        string personName = GetUserName();

        int favoriteNum = GetUserNumber();

        int squaredValue = CalculateSquare(favoriteNum);

        ShowSquareResult(personName, squaredValue);
    }

    static void ShowGreeting()
    {
        Console.WriteLine("Hello! Welcome to this app!");
    }

    static string GetUserName()
    {
        Console.Write("Enter your name: ");
        string user = Console.ReadLine();
        return user;
    }

    static int GetUserNumber()
    {
        Console.Write("Enter your favorite number: ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }

    static int CalculateSquare(int num)
    {
        return num * num;
    }

    static void ShowSquareResult(string user, int square)
    {
        Console.WriteLine($"{user}, the square of your number is {square}");
    }
}