public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(DateTime date, int duration, int laps) 
        : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance() => (_laps * 50.0 / 1000.0 * 0.62); 
    public override double GetSpeed() => (GetDistance() / (_duration / 60.0)); 
    public override double GetPace() => (_duration / GetDistance()); 
}
