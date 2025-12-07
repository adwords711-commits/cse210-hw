using System;
public class SimpleGoal : Goal
{
    private bool isComplete;
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        isComplete = false;
    }
    public override int RecordEvent()
    {
        isComplete = true;
        return _points;
    }
    public override bool IsComplete()
    {
        return isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_name}|{_description}|{_points}|{isComplete}";
    }    
    public override void DisplayGoal()
    {
        string status;
        if (isComplete)
        {
            status = "[X]";
        }
        else
        {
            status = "[ ]";
        }
        Console.WriteLine($"{status} {_name} ({_description})");
    }
}