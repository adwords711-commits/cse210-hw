using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Swimming("12/15/2025", 20, 40),
            new Running("12/17/2025",35, 7.0f),
            new Cycling("12/20/2025", 60, 10.0f),
        };
        Console.WriteLine();
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
        Console.WriteLine();

        
    }
}