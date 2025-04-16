using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }
    public void Run()
    {
        DisplayStartingMessage();
        int breath = GetDuration();

        Console.WriteLine("Get ready to breathe in and out.");
        ShowSpinner(3);

        while (breath > 0)
        {
            Console.Clear();
            BreatheIn();
            ShowCountDown(3);
            
            Console.Clear();
            BreatheOut();
            ShowCountDown(5);
            
            breath -= 10;
        }

        ShowSpinner(3);
        DisplayEndingMessage();
    }
    private void BreatheIn()
    {
        int maxSpaces = 10;

        for (int i = 0; i <= maxSpaces; i++)
        {
            Console.SetCursorPosition(0, 0);
            Console.Write(new string(' ', i)); 
            Console.Write("Breathe in...");
            Thread.Sleep(150);
        }
    }
    private void BreatheOut()
    {
        int maxSpaces = 10; 

        for (int i = maxSpaces; i >= 0; i--)
        {
            Console.SetCursorPosition(0, 0);
            Console.Write(new string(' ', i));
            Console.Write("Breathe out...");
            Thread.Sleep(200);
        }
    }
}