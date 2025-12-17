public class Cycling : Activity
{
    private float _speed;
    public Cycling(string date, int lengthMinutes, float speed)
        : base(date, lengthMinutes)
    {
        _speed = speed;
    }
    public override float GetDistance() => (_speed * lengthMinutes) / 60;
    public override float GetSpeed() => _speed;
    public override float GetPace() => 60 / _speed;
}