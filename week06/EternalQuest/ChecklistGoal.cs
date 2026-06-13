public class ChecklistGoal : Goal
{
    private int _amountCompleted=0;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name,string description, int points,int target,int bonus) : base(name, description, points)
    {
        _target=target;
        _bonus=bonus;
    }
    public override void RecordEvent()
    {
        _amountCompleted++;
        if (IsComplete())
        {
            Console.WriteLine($"Congratulations! You have earned {_points+_bonus} points!");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
        }
    }
    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public int GetBonus()
    {
        return _bonus;
    }
    public void SetAmountCompleted(int amount)
    {
        _amountCompleted=amount;
    }
    public override string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[x] {_shortName} ({_description}) -- Currently Completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {_shortName} ({_description}) -- Currently Completed: {_amountCompleted}/{_target}";
        }
    }
    public override string GetStringRepresentation()
    {
        return $"checklist,{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }
}