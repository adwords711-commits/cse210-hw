public class BreathingActivity : Activity
{
    
    public BreathingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
        
    }
    private void HandleBreathing()
    {
        Console.WriteLine("Get Ready...");
        PauseWithSpinner();
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
        Console.WriteLine("Well Done!");
        PauseWithSpinner();
    }
    public void Run()
    {
        DisplayStartMessage();
        HandleBreathing();
        DisplayEndMessage();
    }
        
}