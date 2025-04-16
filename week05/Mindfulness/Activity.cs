using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}!\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("How many seconds would you like to do this activity for? ");
        int duration = int.Parse(Console.ReadLine());
        _duration = duration;
        Console.WriteLine($"\nThis activity will last for {_duration} seconds.\n");
        ShowSpinner(3);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\nCongratulations!");
        Thread.Sleep(5000);
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}.\n");
        ShowSpinner(3);
        Menu menu = new Menu();
        menu.MenuActivities();
    }
    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        string[] spinner = { "|", "/", "-", "\\" };
        int index = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[index]);
            Console.Write("\b");
            index = (index + 1) % spinner.Length;
            Thread.Sleep(500);
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + "\b");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }
}