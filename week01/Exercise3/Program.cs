using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator= new Random();
        int number=randomGenerator.Next(1,100);
        int guess;
        do
        {
            Console.Write("Take your guess ");
        
        guess=int.Parse(Console.ReadLine());
        if (guess == number)
        {
            Console.WriteLine("Congrats! You guessed it!");

        }
        else if (guess > number)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("Higher");
        }
        } while(guess!=number);
        

    }
}