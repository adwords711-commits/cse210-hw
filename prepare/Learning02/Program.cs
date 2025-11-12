using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "Georgia Tech";
        job1._jobTitle = "Database Admin";
        job1._startYear = 2024;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._company = "Virginia Tech";
        job2._jobTitle = "Data Analyst";
        job2._startYear = 2020;
        job2._endYear = 2025;


        Resume myResume = new Resume();

        myResume._name = "Jorge Gonzales";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
        

    }
}