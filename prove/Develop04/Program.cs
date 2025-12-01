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
        program.StartActivity(choice);
    }
    public void ShowMenu()
    {
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine("Select a choice from the menu: ");
    }

    public int GetUserChoice()
    {
        string input = Console.ReadLine();
        int choice = int.Parse(input);
        return choice;
    }
    public void StartActivity(int choice)
    {
        if (choice == 1)
        {
            Console.Write("How long, in seconds would you like for your session? ");
            int duration = int.Parse(Console.ReadLine());

            BreathingActivity activity = new BreathingActivity("Welcome to the Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing. ", duration );
            activity.Run();
        }
        else if (choice == 2)
        {
            Console.Write("How long, in seconds would you like for your session? ");
            int duration = int.Parse(Console.ReadLine());

            ReflectingActivity activity2 = new ReflectingActivity("Welcome to the Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing. ", duration );
            activity2.Run();   
        }
        else if (choice == 3)
        {
            Console.Write("How long, in seconds would you like for your session? ");
            int duration = int.Parse(Console.ReadLine());

            ListingActivity activity3 = new ListingActivity("Welcome to the Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing. ", duration );
            activity3.Run();
        }
    }
        
}