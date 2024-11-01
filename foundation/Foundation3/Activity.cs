public abstract class Activity
{
    private DateTime _date;
    public int _duration; 

    protected Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public virtual double GetDistance() => 0.0; 
    public virtual double GetSpeed() => 0.0; 
    public virtual double GetPace() => 0.0; 

    public string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetType().Name} ({_duration} min): Distance: {GetDistance():F2}, Speed: {GetSpeed():F2}, Pace: {GetPace():F2}";
    }
}
