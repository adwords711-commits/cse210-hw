public class Running : Activity
{
    private float _distance;
    public Running(string date, int lengthMinutes, float distance)
        : base(date, lengthMinutes)
    {
        _distance = distance;
    }
    public override float GetDistance() => _distance;
    public override float GetSpeed() => (_distance / lengthMinutes) * 60;
    public override float GetPace() => lengthMinutes / _distance;
    
}