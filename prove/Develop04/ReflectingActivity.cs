using System;
public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {

        _prompts = new List<string>();
        _questions = new List<string>();

        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }
    public string GetRandomPrompt()
    {
        Random ran = new Random();
        int index = ran.Next(_prompts.Count);
        return _prompts[index];
    }
    public string GetRandomQuestion()
    {
        Random ran = new Random();
        int index = ran.Next(_questions.Count);
        return _questions[index];
    }
    public void DisplayPrompt(string prompt)
    {
        Console.WriteLine(prompt);
    }
    public void DisplayQuestion(string question)
    {
        Console.WriteLine(question);
    }
    public void Run()
    {
        DisplayStartMessage();
        Console.WriteLine();
        
        Console.Write("How long, in seconds would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);
        Console.WriteLine();

        Console.WriteLine("Get Ready...");
        PauseWithSpinner();
        Console.WriteLine();

        string prompt = GetRandomPrompt();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press Enter to continue. ");
        Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.\nYou may beging in: ");
        PauseWithCountdown();
        Console.WriteLine();
        
        for (int i = 0; i < 3; i++)
        {   
            string question = GetRandomQuestion();
            Console.Write(question);
            PauseWithSpinner(15);
            Console.WriteLine();

        }
        DisplayEndMessage();
    }
}