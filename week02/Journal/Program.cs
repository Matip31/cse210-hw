using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Journal journal=new Journal();
        int answer;
        do
        {
           Console.WriteLine("Please select one of the following choices: ");
           Console.WriteLine("1. Write");
           Console.WriteLine("2. Display");
           Console.WriteLine("3. Load");
           Console.WriteLine("4. Save");
           Console.WriteLine("5. Quit");
           Console.Write("What would you like to do? ");
           answer=int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                PromptGen promptGen=new PromptGen();
                string prompt=promptGen.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write(">");
                string entryText=Console.ReadLine();
                DateTime theCurrentTime= DateTime.Now;
                string date=theCurrentTime.ToShortDateString();
                Entry entry=new Entry();
                entry._date=date;
                entry._promptText=prompt;
                entry._entryText=entryText;
                journal.AddEntry(entry);
            }
            else if (answer == 2)
            {
                journal.DisplayAll();
            }
            else if (answer == 3)
            {
                Console.Write("What is the filename? ");
                string filename=Console.ReadLine();
                journal.LoadFile(filename);
            }
            else if (answer == 4)
            {
                Console.Write("What is the filename? ");
                string filename=Console.ReadLine();
                journal.SaveToFile(filename);
            }

        }while(answer!=5);
    }
}