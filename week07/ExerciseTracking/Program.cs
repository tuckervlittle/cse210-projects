using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(DateTime.Now, 30, 3),
            new Cycling(DateTime.Now, 45, 25),
            new Swimming(DateTime.Now, 15, 5)
        };
        Console.Clear();
        Console.WriteLine("--------------------");
        Console.WriteLine("| Your Activities: |");
        Console.WriteLine("--------------------");
        Console.WriteLine();
        foreach (Activity activity in activities)
        {
            Console.WriteLine("**********************************");
            Console.WriteLine(activity.GetSummary());
        }
            Console.WriteLine("**********************************");
    }
}