using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            int points = _goals[goalIndex].RecordEvent();
            _score += points;
            Console.WriteLine($"You earned {points} points!");
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetails()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Total Score: {_score}");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.Serialize());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];

            Goal goal = null;
            switch (type)
            {
                case "SimpleGoal":
                    goal = new SimpleGoal(parts[1], int.Parse(parts[2]), bool.Parse(parts[3]));
                    break;
                case "EternalGoal":
                    goal = new EternalGoal(parts[1], int.Parse(parts[2]));
                    break;
                case "ChecklistGoal":
                    goal = new ChecklistGoal(parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                    break;
            }

            if (goal != null)
            {
                _goals.Add(goal);
            }
        }
    }

    public void Run()
    {
        string choice;
        do
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("0. Exit");
            Console.Write("Select an option: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoalMenu();
                    break;
                case "2":
                    DisplayGoals();
                    break;
                case "3":
                    Console.Write("Enter goal number to record: ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    RecordEvent(index);
                    break;
                case "4":
                    DisplayScore();
                    break;
                case "5":
                    SaveGoals("goals.txt");
                    break;
                case "6":
                    LoadGoals("goals.txt");
                    break;
            }
        } while (choice != "0");
    }

    private void CreateGoalMenu()
    {
        Console.WriteLine("Select Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        string option = Console.ReadLine();

        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        switch (option)
        {
            case "1":
                AddGoal(new SimpleGoal(name, points, false));
                break;
            case "2":
                AddGoal(new EternalGoal(name, points));
                break;
            case "3":
                Console.Write("Target count: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Bonus points: ");
                int bonus = int.Parse(Console.ReadLine());

                AddGoal(new ChecklistGoal(name, points, 0, target, bonus));
                break;
        }
    }
}
