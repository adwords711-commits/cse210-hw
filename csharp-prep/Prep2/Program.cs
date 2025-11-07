using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("Enter your grade percent here ");
        string letter = Console.ReadLine();
        int number = int.Parse(letter);

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is: {letter} ");

        if (number >= 70)
        {
            Console.WriteLine("you passed the course. Congratulations! ");
        }
        else
        {
            Console.WriteLine("You'll get it next time ");
        }
    }
}