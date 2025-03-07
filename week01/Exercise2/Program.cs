using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage (eg. 85)? ");
        string userGradeInput = Console.ReadLine();

        int grade = int.Parse(userGradeInput);
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        int determiner = grade % 10;
        string sign = "";
        if (letter != "A" && determiner >= 7)
        {
            sign = "+";
        }
        else if (letter != "F" && determiner < 3)
        {
            sign = "-";
        }
        if (grade >= 70)
        {
            Console.WriteLine("Congrats, you passed! ");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass. ");
        }
        Console.WriteLine($"You got a(n) {letter}{sign}");
    }
}