using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        Fraction f=new Fraction();
        Console.WriteLine(f.GetFractionString());
        Fraction fr=new Fraction(5);
        Console.WriteLine(fr.GetFractionString());
        Fraction fra=new Fraction(3,4);
        Console.WriteLine(fra.GetFractionString());
        Console.WriteLine(fra.GetDecimalValue());
    }
}