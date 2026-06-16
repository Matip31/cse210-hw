public class SwimmingActivity : Activity
{
    private int _laps;
    public SwimmingActivity(string date, double length, int laps) : base(date, length)
    {
        _laps=laps;
    }
    public override double GetDistance()
    {
        return _laps*50/1000.0;
    }
    public override double GetSpeed()
    {
        return (GetDistance()/_length)*60;
    }
}