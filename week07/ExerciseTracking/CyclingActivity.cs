public class CyclingActivity : Activity
{
    private double _speed;
    public CyclingActivity(string date, double length, double speed) : base(date, length)
    {
        _speed=speed;
    }
    public override double GetDistance()
    {
        return (_speed*(_length/60.0));
    }
    public override double GetSpeed()
    {
        return _speed;
    }
}