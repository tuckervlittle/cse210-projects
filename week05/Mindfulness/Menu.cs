using System;

public class Menu
{
    private string _userInput;

    public string GetUserInput()
    {
        return _userInput;
    }

    public string UserSelection()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Beathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Exit");
        Console.Write("Please select an option: ");

        _userInput = Console.ReadLine();
        return _userInput;
    }

    public string MenuActivities()
    {
        UserSelection();
        if (_userInput == "1")
        {
            BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 0);
            breathingActivity.Run();
            return "Breathing Activity";
        }
        else if (_userInput == "2")
        {
            ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on your thoughts and feelings. Take a moment to think about something meaningful to you.", 0);
            reflectingActivity.Run();
            return "Reflecting Activity";
        }
        else if (_userInput == "3")
        {
            ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you list things that you are grateful for. Take a moment to think about the things that bring you joy.", 0);
            listingActivity.Run();
            return "Listing Activity";
        }
        else if (_userInput == "4")
        {
            Console.WriteLine("Exiting the program. Thanks for participating!");
            return "Exit";
        }
        else
        {
            return "Invalid selection. Please try again.";
        }
    }
}