using System;

class Program
{
    static void Main(string[] args)
    {
        ReflectingActivity reflecting = new ReflectingActivity(
            "Reflecting", "This activity will help you reflect on your life", 10);
        reflecting.Run();
    }
}