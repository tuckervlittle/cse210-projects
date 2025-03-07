using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        do
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);
            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);
        
        int largest = numbers[0];
        int closeZero = numbers[0];
        int sum = 0;
        foreach (int i in numbers)
        {
            sum += i;
            if (i > largest)
            {
                largest = i;
            }
            if (closeZero < 0 || i > 0 && i < closeZero)
            {
                closeZero = i;
            }
        }
        float average = ((float)sum) / numbers.Count;
        numbers.Sort();
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest is: {largest}");
        Console.WriteLine($"The smallest positive number is: {closeZero}");
        Console.WriteLine("The sorted list:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}