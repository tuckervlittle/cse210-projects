
// I have added 4 csv files, one for each topic of doctrinal mastery.
// The user can select a topic and the program will select a random doctrinal mastery to memorize.
// The user may also choose to continue after each doctrinal mastery.

using System;
using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            // Reference reference = new Reference("John", 3, 16);
            // Scripture scripture = new Scripture(reference, "For God so loved the world that He gave His only Son");
            // List<Reference> references = new List<Reference>();
            // List<Scripture> scriptures = new List<Scripture>();
            Console.Clear();
            Console.WriteLine("What topic do you want to study?");
            Console.WriteLine("1. Old Testament");
            Console.WriteLine("2. New Testament");
            Console.WriteLine("3. Book of Mormon");
            Console.WriteLine("4. Doctrine & Covenants");
            Console.WriteLine("5. Exit");
            Console.Write("> ");
            string userInput = Console.ReadLine();
            int choice;

            if (!int.TryParse(userInput, out choice) || choice < 1 || choice > 5)
            {
                Console.WriteLine("Invalid option. Please enter a number between 1 and 5.");
                continue;
            }
            else if (choice == 5)
            {
                Console.WriteLine("Exiting the program...");
                break;
            }

            string file = choice switch
            {
                1 => "ot.csv",
                2 => "nt.csv",
                3 => "bom.csv",
                4 => "dc.csv",
                _ => throw new InvalidOperationException("Invalid choice")
            };

            Scripture scripture = Scripture.GetScripture(file);

            if (scripture == null)
            {
                Console.WriteLine($"Failed to load scripture from {file}. Please check the file.");
                continue;
            }

            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter to hide words or type \"quit\" to exit.");

            while (!scripture.IsCompletelyHidden())
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    Console.Clear();
                    Console.WriteLine("Goodbye");
                    break;
                }
                scripture.HideRandomWords();
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("Press Enter to hide words or type \"quit\" to exit.");
            }
            Console.WriteLine();
            Console.WriteLine("Well done");

            Console.WriteLine("Do you want to study another topic? (y/n)");
            string playAgain = Console.ReadLine();
            if (playAgain.ToLower() != "y")
            {
                Console.WriteLine("Thank you for studying!");
                break;
            }
        }
    }
}