using System;
public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _completionTarget;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _timesCompleted = 0;
        _completionTarget = target;
        _bonusPoints = bonus;
    }
    public override int RecordEvent()
    {
        _timesCompleted = _timesCompleted + 1;
        int earnedPoints = _points;
        if (_timesCompleted == _completionTarget)
        {
            earnedPoints += _bonusPoints;
        }
        return earnedPoints;   
    }
    public override bool IsComplete()
    {
        if (_timesCompleted >= _completionTarget)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override void DisplayGoal()
    {
        string status;
        if (_timesCompleted >= _completionTarget)
        {    
            status= "[X]";
        }
        else
        {
            status = "[ ]";
        }
        Console.WriteLine($"{status} {_name} ({_description} -- Currenlty completed: {_timesCompleted}/{_completionTarget}");
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_name}|{_description}|{_points}|{_timesCompleted}|{_completionTarget}|{_bonusPoints}";
    }    
}