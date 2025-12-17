using System.Reflection;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
        {
            _speaker = speaker;
            _capacity = capacity;   
        }
    public new string FullDetails()
    {
        string details = base.GetDetails();
        details += $"\nSpeaker: {_speaker}\nCapacity: {_capacity}";
        return details;    
    }
    
}