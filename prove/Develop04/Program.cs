using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.ShowMenu();
        int choice = program.GetUserChoice();
        Console.WriteLine("You chose: " + choice);
    }
    public void ShowMenu()
    {
        Console.WriteLine("Choose an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
    }

    public int GetUserChoice()
    {
        Console.Write("Enter your choice (1-4): ");
        string input = Console.ReadLine();
        int choice = int.Parse(input);
        return choice;
    }
        
}