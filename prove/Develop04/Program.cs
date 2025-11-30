using System;

class Program
{
    static void Main(string[] args)
    {
        //ReflectingActivity reflecting = new ReflectingActivity(
        //    "Reflecting", "This activity will help you reflect on your life", 10);
        //reflecting.Run();
        BreathingActivity breathing = new BreathingActivity("Welcome to the Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind, and focus in your breathing.", 25);
        breathing.Run();
    }
}