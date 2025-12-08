using System;
//*** Showing Creativity ***
// To make the program engaging and fun, I added a motivational message everytime the user
// completes a goal. The messages are randomly selected from an array. The creativty code with a ramdom selection feature
// is implemented in the GoalManager class inside the RecordGoalEnent() method.

GoalManager manager = new GoalManager();
int choice = 0;
while (choice != 6)
{
    Console.WriteLine($"You have {manager.TotalScore} points.");
    Console.WriteLine();
    Console.WriteLine("Menu options: ");
    Console.WriteLine("1. Create New Goal");
    Console.WriteLine("2. List Goals");
    Console.WriteLine("3. Save Goals");
    Console.WriteLine("4. Load Goals");
    Console.WriteLine("5. Record Event");
    Console.WriteLine("6. Quit");
    Console.Write("Select a choice from the menu:");

    choice = int.Parse(Console.ReadLine());

    if (choice == 1)
    {
        Console.WriteLine();
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine();

        Console.Write("Whihc type of goal would you like to create? ");
        int goalType = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (goalType == 1)
        {
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            manager.AddGoal(simpleGoal);
        }
        else if (goalType == 2)
        {
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            manager.AddGoal(eternalGoal);
        }
        else if (goalType == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            manager.AddGoal(checklistGoal);
        }
    }
    else if (choice == 2)
    {
        Console.WriteLine();
        Console.WriteLine("The goals are: ");
        manager.ListGoals();
        Console.WriteLine();
    }
    else if (choice == 3)
    {
        manager.SaveGoals();
    }
    else if (choice == 4)
    {
        manager.LoadGoals();
    }
    else if (choice == 5)
    {
        manager.RecordGoalEvent();
    }
}
