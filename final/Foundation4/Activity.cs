public abstract class Activity
{
    private string _date;
    private int _lengthMinutes;
    
    public Activity(string date, int lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }
    public abstract float GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace();
    
    public virtual string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_lengthMinutes} min) ** Distance: {GetDistance():0.0}, Pace: {GetPace():0.00}";
    }
    public string Date => _date;
    public int lengthMinutes => _lengthMinutes;
}