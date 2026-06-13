public class SimpleGoal : Goal
{
    private bool _isComplete=false;
    public SimpleGoal(string name,string description, int points) : base(name, description, points)
    {
    }
    public override void RecordEvent()
    {
        _isComplete=true;
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"simple,{_shortName},{_description},{_points},{_isComplete}";
    }
    public void SetCompletion(bool completion)
    {
        _isComplete=completion;
    }
}