public class CyclingActivity : Activity
{
    private double _distance; 
    private double _speed; 

    public CyclingActivity(DateTime date, int duration, double distance)
        : base(date, duration)
    {
        _distance = distance;
        _speed = (distance / (duration / 60.0)); 
    }

    public override double GetSpeed() => _speed;
    public override double GetPace() => _duration / _distance; 
    public override double GetDistance() => _distance; 
}
