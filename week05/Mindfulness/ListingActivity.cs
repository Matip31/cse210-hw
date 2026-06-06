public class ListingActivity : Activity
{
    private List<string> _prompts=new List<string>();
    private int _count;
    public ListingActivity():base("Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area")
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }
    public void GetRandomPrompt()
    {
        Random random=new Random();
        int i=random.Next(_prompts.Count);
        string prompt=_prompts[i];
        Console.WriteLine($" ---{prompt}--- ");
    }
    public List<string> GetListFromUser()
    {
        List<string> answers=new List<string>();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        DateTime startTime=DateTime.Now;
        DateTime endTime=startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            string a=Console.ReadLine();
            answers.Add(a);
            _count++;
        }
        return answers;
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get Ready");
        ShowSpinner(5);
        List<string> userAnswers=GetListFromUser();
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine("Well Done!!!");
        ShowSpinner(5);
        DisplayEndingMessage();
        ShowSpinner(5);
    }
}