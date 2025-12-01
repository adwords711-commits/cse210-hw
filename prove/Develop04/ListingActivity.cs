using System.ComponentModel;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _items;

    
    public ListingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
        _prompts = new List<string>();
        _items = new List<string>();

        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");  
    }
    public string GetRandomPrompt()
    {
        Random ran = new Random();
        int index = ran.Next(_prompts.Count);
        return _prompts[index];

    }
    public void DisplayPrompt(string prompt)
    {
        Console.WriteLine(prompt);
    }
    public void CountItems()
    {
        Console.WriteLine($"You listed {_items.Count} items ");
    }
    public void Run()
    {   
        DisplayStartMessage();
        string prompt = GetRandomPrompt();
        DisplayPrompt(prompt);
        PauseWithCountdown();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            _items.Add(item);
        }
        CountItems();
        DisplayEndMessage();    
    }
}