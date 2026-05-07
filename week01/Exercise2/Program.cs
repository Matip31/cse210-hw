using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int percentage= int.Parse(Console.ReadLine());
        string grade;
        bool pass=false;
        if (percentage >= 90)
        {
            grade="A";
            pass=true;
        }
        else if (percentage >= 80)
        {
            grade="B";
            pass=true;
        }
        else if (percentage >= 70)
        {
            grade="C";
            pass=true;
        }
        else if (percentage >= 60)
        {
            grade="D";
        }
        else
        {
            grade="F";
        }
        Console.WriteLine($"Your grade is {grade}");
        if (pass)
        {
            Console.WriteLine("Congratulations! You have passed.");
        }
        else
        {
            Console.WriteLine("Oh sorry, you have not passed. Try better next time!");
        }
        

    }
}