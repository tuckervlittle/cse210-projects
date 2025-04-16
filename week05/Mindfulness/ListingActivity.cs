using System;

public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who is someone that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "What are some things you are grateful for today?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }
    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        Console.WriteLine("Get ready to list your thoughts.");
        ShowSpinner(3);
        
        GetRandomPrompt();

        ShowCountDown(5);

        DateTime startTime = DateTime.Now;
        Console.WriteLine($"List as many items as you can in {duration} seconds.\n");
        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.Write($"> ");
            string userInput = Console.ReadLine();

            
            if (!string.IsNullOrEmpty(userInput))
            {
                _count++;
            }
        }
        Console.Write($"\nTime's up! You listed {_count} items.");

        ShowSpinner(3);
        DisplayEndingMessage();
    }
    public void GetRandomPrompt()
    {
        HashSet<int> _usedPrompts = new HashSet<int>();
        Random _random = new Random();
        if (_usedPrompts.Count == _prompts.Count)
        {
            _usedPrompts.Clear();
        }

        int i;
        do
        {
            i = _random.Next(_prompts.Count);
        } while (_usedPrompts.Contains(i));

        _usedPrompts.Add(i);
        Console.WriteLine($"\n--- Prompt ---\n{_prompts[i]}\n");
    }
}