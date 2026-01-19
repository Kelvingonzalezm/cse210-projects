using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction first = new Fraction();
        ShowFraction(first);

        Fraction second = new Fraction(5);
        ShowFraction(second);

        Fraction third = new Fraction(3, 4);
        ShowFraction(third);

        Fraction fourth = new Fraction(1, 3);
        ShowFraction(fourth);

    }

    static void ShowFraction(Fraction fraction)
    {
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());
    }
}