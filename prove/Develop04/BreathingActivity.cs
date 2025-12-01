public class BreathingActivity : Activity
{
    
    public BreathingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
        
    }
    private void HandleBreathing()
    {   
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            PauseWithCountdown();
            Console.WriteLine();
        
            Console.Write("Breathe out...");
            PauseWithCountdown();
            Console.WriteLine();

            Console.WriteLine();
        }
    }
    public void Run()
    {
        DisplayStartMessage();
        
        Console.Write("How long, in seconds would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);
        Console.WriteLine();
        Console.WriteLine("Get Ready...");
        PauseWithSpinner();
        Console.WriteLine();
        
        HandleBreathing();
        DisplayEndMessage();
    }
        
}