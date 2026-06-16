public abstract class Activity
{
    private string _date;
    protected double _length;
    public Activity(string date, double length)
    {
        _date=date;
        _length=length;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public double GetPace()
    {
        return (_length/GetDistance());
    }
    public string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_length}- Distance {GetDistance():F1}km, Speed {GetSpeed():F1}kph, Pace:{GetPace():F1}min per km)";
    }


}