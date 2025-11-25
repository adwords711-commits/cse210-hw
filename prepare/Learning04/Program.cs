using System;

class Program
{
    static void Main(string[] args)
    {

        MathAssignment myMathAssigment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        
        Console.WriteLine(myMathAssigment.GetSummary());
        Console.WriteLine(myMathAssigment.GetHomeworkList());

        WrittingAssignment myWrittingAssignment = new WrittingAssignment("Mary Waters", " European History", "The Causes of World War II");
        Console.WriteLine(myWrittingAssignment.GetSummary());
        Console.WriteLine(myWrittingAssignment.GetWritingInformation());
        
    }
}