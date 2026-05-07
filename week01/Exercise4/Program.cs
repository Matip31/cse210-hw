using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number;
        int sum=0;
        float average;
        int largest=-1;
        int count=0;
        do
        {
            Console.Write("Enter Number: ");
            number=int.Parse(Console.ReadLine());
            if (number != 0)
            {
                sum+=number;
                count++;
                if (number > largest)
                {
                    largest=number;
                }
            }

        }while (number!=0);
        Console.WriteLine($"The sum is {sum}");
        average=sum/count;
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {largest}");
    }
}