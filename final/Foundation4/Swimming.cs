
public class Swimming : Activity
{
    private int _laps;
    public Swimming(string date, int lengthMinutes, int laps)
        : base(date, lengthMinutes)
    {
        _laps = laps;
    }
    public override float GetDistance() => _laps * 50 / 100f;
    public override float GetSpeed() => (GetDistance() / lengthMinutes) * 60;
    public override float GetPace() => lengthMinutes / GetDistance();
}