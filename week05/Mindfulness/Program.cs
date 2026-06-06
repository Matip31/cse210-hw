using System;

class Program
{
    static void Main(string[] args)
    {
         BreathingActivity breathing=new BreathingActivity();
         ListingActivity listing=new ListingActivity();
         ReflectingActivity reflecting=new ReflectingActivity();
         string input="";
        while (input != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            input=Console.ReadLine();
            if (input == "1")
            {
                breathing.Run();
            }
            else if (input == "2")
            {
                reflecting.Run();
            }
            else if (input == "3")
            {
                listing.Run();
            }
        }
    }
}