using System;
using System.Collections.Generic;
using System.IO;

class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private Random _random = new Random();
    private List<string> _encouragementMessages = new List<string>
    {
        "Great job! Keep it up!",
        "You're doing amazing!",
        "Every step counts!",
        "You're on the right track!",
        "Keep pushing forward!",
        "Fantastic progress!",
        "Believe in yourself!",
        "You are unstoppable!"
    };

    public void CreateGoal()
    {
        Console.WriteLine("Select the type of goal to create:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choose an option: ");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points for completion: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = choice switch
        {
            "1" => new SimpleGoal(name, description, points),
            "2" => new EternalGoal(name, description, points),
            "3" => CreateChecklistGoal(name, description, points),
            _ => throw new InvalidOperationException("Invalid goal type.")
        };

        _goals.Add(goal);
        Console.WriteLine("Goal created successfully.");
    }

    private ChecklistGoal CreateChecklistGoal(string name, string description, int points)
    {
        Console.Write("Enter target times for completion: ");
        int target = int.Parse(Console.ReadLine());
        Console.Write("Enter bonus points upon completion: ");
        int bonus = int.Parse(Console.ReadLine());

        return new ChecklistGoal(name, description, points, target, bonus);
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("\nGoals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
        Console.WriteLine($"Total Score: {_score}");
    }

    public void RecordEvent()
    {
        Console.WriteLine("Select a goal to record an event:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }

        Console.Write("Enter goal number: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal goal = _goals[goalIndex];
            int pointsEarned = goal.RecordEvent();
            _score += pointsEarned;

            if (pointsEarned > 0)
            {
                
                DisplayEncouragementMessage();
            }

            Console.WriteLine("Event recorded successfully.");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }

    private void DisplayEncouragementMessage()
    {
        int randomIndex = _random.Next(_encouragementMessages.Count);
        Console.WriteLine(_encouragementMessages[randomIndex]);
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals(string filename)
    {
        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                _score = int.Parse(reader.ReadLine());
                _goals.Clear();

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    string goalType = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    Goal goal = goalType switch
                    {
                        "SimpleGoal" => new SimpleGoal(name, description, points, bool.Parse(parts[4])),
                        "EternalGoal" => new EternalGoal(name, description, points),
                        "ChecklistGoal" => new ChecklistGoal(name, description, points, int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[4])),
                        _ => throw new InvalidOperationException("Unknown goal type.")
                    };

                    _goals.Add(goal);
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
