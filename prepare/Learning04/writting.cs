public class WrittingAssignment : Assignment
{
    private string __title;

    public WrittingAssignment(string name, string topic, string title) : base(name, topic)
    {
        __title = title;
    }
    public string GetWritingInformation()
    { 
        return $"{__title} by {_studentName}";
    }
}