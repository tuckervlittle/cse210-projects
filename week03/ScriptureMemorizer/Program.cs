using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that He gave His only Son");

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Press Enter to hide words or type \"quit\" to exit.");

        while (!scripture.IsCompletelyHidden())
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            scripture.HideRandomWords();
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter to hide words or type \"quit\" to exit.");
        }
        Console.WriteLine();
        Console.WriteLine("Well done");
    }
}