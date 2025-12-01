using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        int choice = 0;
        
        while (choice != 4)
        {
            program.ShowMenu();
            choice = program.GetUserChoice();
            program.StartActivity(choice);
            
        }
    }
    public void ShowMenu()
    {
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice from the menu: ");
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
            BreathingActivity activity = new BreathingActivity("Welcome to the Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 0 );
            activity.Run();
        }
        else if (choice == 2)
        {

            ReflectingActivity activity2 = new ReflectingActivity("Welcome to the Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilence. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0 );
            activity2.Run();   
        }
        else if (choice == 3)
        {
            ListingActivity activity3 = new ListingActivity("Welcome to the Listing Activity.", "THis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0 );
            activity3.Run();
        }
    }
        
}