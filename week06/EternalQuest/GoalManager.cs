public class GoalManager
{
    private List<Goal> _goals=new List<Goal>();
    private int _score=0;
    public void Start()
    {
        string input="";
        do
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            input=Console.ReadLine();
            Console.WriteLine();
            if (input == "1")
            {
                CreateGoal();
            }
            else if (input == "2")
            {
                ListGoalDetails();
            }
            else if (input == "3")
            {
                SaveGoals();
            }
            else if (input == "4")
            {
                LoadGoals();
            }
            else if (input == "5")
            {
                RecordEvent();
            }
            
        }while(input!="6");
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points!");
        Console.WriteLine();
    }
    public void ListGoalNames()
    {
        Console.WriteLine("The goals are: ");
        int counter=1;
        _goals.ForEach(goal =>
        {
            Console.WriteLine($"{counter}. {goal.GetName()}");
            counter++;
        });
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are: ");
        int counter=1;
        _goals.ForEach(goal =>
        {
            Console.WriteLine($" {counter}. {goal.GetDetailsString()}");
            counter++;
        });
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string type=Console.ReadLine();
        Console.WriteLine();
        Console.Write("What is the name of your goal? ");
        string name=Console.ReadLine();
        Console.WriteLine();
        Console.Write("What is a short description of it? ");
        string description=Console.ReadLine();
        Console.WriteLine();
        Console.Write("What is the ammount of points associated with this goal? ");
        int points=int.Parse(Console.ReadLine());
        Console.WriteLine();
        if (type == "1")
        {
            SimpleGoal sgoal=new SimpleGoal(name,description,points);
            _goals.Add(sgoal);
        }
        else if (type == "2")
        {
            EternalGoal egoal=new EternalGoal(name,description,points);
            _goals.Add(egoal);
        }
        else if (type == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target=int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus=int.Parse(Console.ReadLine());
            ChecklistGoal cgoal=new ChecklistGoal(name,description,points,target,bonus);
            _goals.Add(cgoal);
        }
    }
    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int index=int.Parse(Console.ReadLine());
        _goals[index-1].RecordEvent();
        _score+=_goals[index-1].GetPoints();
        if(_goals[index-1] is ChecklistGoal checklist)
        {
            if (checklist.IsComplete())
            {
                _score+=checklist.GetBonus();
            }
        }
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename=Console.ReadLine();
        using(StreamWriter outputFile=new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach(Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename=Console.ReadLine();
        string[] lines=System.IO.File.ReadAllLines(filename);
        _score=int.Parse(lines[0]);
        for(int i=1;i<lines.Length;i++)
        {
            string[] parts=lines[i].Split(',');
            if (parts[0] == "simple")
            {
                SimpleGoal sgoal=new SimpleGoal(parts[1],parts[2],int.Parse(parts[3]));
                sgoal.SetCompletion(bool.Parse(parts[4]));
                _goals.Add(sgoal);
            }
            else if (parts[0] == "eternal")
            {
                EternalGoal egoal=new EternalGoal(parts[1],parts[2],int.Parse(parts[3]));
                _goals.Add(egoal);
            }
            else if (parts[0] == "checklist")
            {
                ChecklistGoal cgoal=new ChecklistGoal(parts[1],parts[2],int.Parse(parts[3]),int.Parse(parts[5]),int.Parse(parts[6]));
                cgoal.SetAmountCompleted(int.Parse(parts[4]));
                _goals.Add(cgoal);
            }
        }
    }
}