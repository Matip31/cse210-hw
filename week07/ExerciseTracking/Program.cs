using System;

class Program
{
    static void Main(string[] args)
    {
        RunningActivity running=new RunningActivity("16 June 2026",25,5.0);
        CyclingActivity cycling=new CyclingActivity("16 June 2026",35,15.5);
        SwimmingActivity swimming=new SwimmingActivity("16 June 2026",20,7);
        List<Activity> activities=new List<Activity>();
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);
        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary()); 
        }
    }
}