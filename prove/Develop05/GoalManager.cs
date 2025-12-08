using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
public class GoalManager
{
    private List<Goal> _goals;
    private int _totalScore;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalScore = 0;

    }
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);

    }
    public void ListGoals()
    {
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.Write(index + ". ");
            goal.DisplayGoal();
            index = index + 1;
        }
    }
    
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_totalScore);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved!");    
    }
    public void LoadGoals()
    {
        Console.Write("Ener filename to load: ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        _totalScore = int.Parse(lines[0]);
        _goals.Clear();
        
        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split('|');
            string goalType = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            if (goalType == "SimpleGoal")
            {
                bool isComplete = bool.Parse(parts[4]);
                SimpleGoal goal = new SimpleGoal(name, description, points);
                if (isComplete) goal.RecordEvent();
                _goals.Add(goal);
            }

            else if (goalType == "EternalGoal")
            {
                EternalGoal goal = new EternalGoal(name, description, points);
                _goals.Add(goal);        
            }
            else if (goalType == "ChecklistGoal")
            {
                int timesCompleted = int.Parse(parts[4]);
                int completionTarget = int.Parse(parts[5]);
                int bonusPoints = int.Parse(parts[6]);
                ChecklistGoal goal = new ChecklistGoal(name, description, points, completionTarget, bonusPoints);
                for (int j = 0; j < timesCompleted; j++)
                {
                    goal.RecordEvent();
                }
                _goals.Add(goal);
            }    
    }
        Console.WriteLine("Goals loaded successfully! ");
    }
    public void RecordGoalEvent()
        {
            Console.WriteLine("The goals are:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].Name}");
            }
            Console.Write("Which goal did you accomplish? ");
            int choice = int.Parse(Console.ReadLine());

            int goalIndex = choice -1;

            int pointsEarned = _goals[goalIndex].RecordEvent();
            _totalScore += pointsEarned;

            Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
        }
    public int TotalScore
    {
        get { return _totalScore; }
    }
}    
                

