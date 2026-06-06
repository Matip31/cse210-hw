public class BreathingActivity : Activity
{
    public BreathingActivity():base("Breathing Activity","This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing")
    {
        
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get Ready");
        ShowSpinner(5);
        DateTime startTime=DateTime.Now;
        DateTime endTime=startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe In...");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Now Breathe Out...");
            ShowCountDown(6);
            Console.WriteLine();
        }
        Console.WriteLine("Well Done!");
        ShowSpinner(5);
        DisplayEndingMessage();
        ShowSpinner(5);
    }

}