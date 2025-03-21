using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1: Write");
            Console.WriteLine("2: Display");
            Console.WriteLine("3: Load");
            Console.WriteLine("4: Save");
            Console.WriteLine("5: Quit");
            Console.Write("What would you like to do? ");
            string userInput = Console.ReadLine();
            int choice = int.Parse(userInput);
            
            if (choice == 1)
            {
                Console.Clear();
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write(">");

                string entryText = Console.ReadLine();
                Entry entry = new Entry(prompt, entryText);
                journal.AddEntry(entry);
            }
            else if (choice == 2)
            {
                Console.Clear();
                journal.DisplayAllEntries();
            }
            else if (choice == 3)
            {
                Console.Write("What is the name of the journal you are trying to load? ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }
            else if (choice == 4)
            {
                Console.Write("What would you like to name your journal? ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
            }
            else if (choice == 5)
            {
                Console.WriteLine("Goodbye");
                break;
            }
            else {
                Console.WriteLine("Invalid option. Try again!");
            }
        }
    }
}