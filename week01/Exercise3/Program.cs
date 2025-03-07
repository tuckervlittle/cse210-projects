using System;

class Program
{
    static void Main(string[] args)
    {
        string response;
        do
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);
            int guess;
            int tries = 0;

            do
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();
                guess = int.Parse(input);
                if (guess > 100)
                {
                    Console.WriteLine("The number is between 0 and 100. That guess won't be counted.");
                    tries -= 1;
                }
                else if (guess < 0)
                {
                    Console.WriteLine("The number is between 0 and 100. That guess won't be counted.");
                    tries -= 1;
                }
                else if (guess > number)
                {
                    Console.WriteLine("Your guess was too high.");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Your guess was too low.");
                }
                tries ++;
            } while (guess != number);
             Console.WriteLine($"Congrats, You guessed correctly! It took you {tries} tries!");
             Console.Write("Do you want to continue? ");
             response = Console.ReadLine();
        } while (response == "yes");
    }
}