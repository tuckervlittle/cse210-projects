public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public void Start()
    {
        bool exit = false;
        while (!exit)
        {
            DisplayPoints();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");

            Console.Write("What would you like to do? ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    CreateGoal();
                    break;
                case 2:
                    Console.Clear();
                    ListGoalDetails();
                    break;
                case 3:
                    Console.Clear();
                    RecordEvent();
                    break;
                case 4:
                    Console.Clear();
                    SaveGoals();
                    break;
                case 5:
                    Console.Clear();
                    LoadGoals();
                    break;
                case 6:
                    exit = true;
                    break;
            }
        }
    }
    public void DisplayPoints()
    {
        Console.WriteLine($"You have {_score} points.");
    }
    public void ListGoalNames()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine();
            Console.WriteLine("No goals available.");
            Console.WriteLine();
            return;
        }
        else
        {
            int i = 1;
            foreach (Goal goal in _goals)
            {
                Console.WriteLine($"{i}: {goal.GetGoalName()}");
                i++;
            }
        }
    }
    public void ListGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
            return;
        }
        else
        {
            int i = 1;
            foreach (Goal goal in _goals)
            {
                Console.WriteLine($"{i}: {goal.GetDetailString()}");
                i++;    
            }
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("What kind would you like to create?: ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter a short name for the goal: ");
        string shortName = Console.ReadLine();

        Console.Write("Enter a description of the goal: ");
        string description = Console.ReadLine();

        Console.Write("Enter the points for this goal: ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        switch (choice)
        {
            case 1:
                newGoal = new SimpleGoal(shortName, description, points);
                break;
            case 2:
                newGoal = new EternalGoal(shortName, description, points);
                break;
            case 3:
                Console.Write("Enter the target for this goal: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter the bonus points for completing the goal: ");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(shortName, description, points, target, bonus);
                break;
        }
        _goals.Add(newGoal);
        Console.WriteLine("Goal created successfully!");
    }

    public void RecordEvent()
    {
        ListGoalNames();
        if (_goals.Count == 0)
        {
            return;
        }
        Console.Write("Which goal did you accomplish? ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        int points = _goals[goalIndex].RecordEvent();
        _score += points;
        Console.WriteLine($"Congratulations! You have earned {points} points!");
        DisplayPoints();
    }
    public void SaveGoals()
    {
        string fileName = "goals.txt";
        string[]lines = new string[_goals.Count];

        int i = 0;
        foreach (Goal goal in _goals)
        {
            lines[i] = _goals[i].ToSaveString();
            i++;
        }

        File.WriteAllLines(fileName, lines);
        Console.WriteLine("Goals saved successfully!");
    }
    public void LoadGoals()
    {
        string fileName = "goals.txt";
        if (!File.Exists(fileName))
        {
            Console.WriteLine("No goals to load.");
            return;
        }
        string[] lines = File.ReadAllLines(fileName);
        _goals = new List<Goal>();
        _score = 0;

        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            string type = parts[0];
            string shortName = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            Goal newGoal = null;

            switch (type)
            {
                case "Simple Goal":
                    bool isComplete = bool.Parse(parts[4]);
                    newGoal = new SimpleGoal(shortName, description, points);
                    ((SimpleGoal)newGoal)._isComplete = isComplete;
                    if (isComplete)
                    {
                        _score += points;
                    }
                    break;
                case "Eternal Goal":
                    newGoal = new EternalGoal(shortName, description, points);
                    break;
                case "Checklist Goal":
                    int amountCompleted = int.Parse(parts[4]);
                    int target = int.Parse(parts[5]);
                    int bonus = int.Parse(parts[6]);
                    newGoal = new ChecklistGoal(shortName, description, points, target, bonus);
                    ((ChecklistGoal)newGoal).SetAmountCompleted(amountCompleted);
                    break;
            }
            _goals.Add(newGoal);
        }
        Console.WriteLine("Goals loaded successfully!");
    }
}