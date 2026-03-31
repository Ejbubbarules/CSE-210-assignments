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

    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
    }

    public void RecordEvent()
    {
        DisplayGoals();
        Console.Write("Select goal: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        int points = _goals[index].RecordEvent();
        _score += points;

        Console.WriteLine($"You earned {points} points!");
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Score: {_score}");
    }

    public void Save(string filename)
    {
        List<string> lines = new List<string>();
        lines.Add(_score.ToString());

        foreach (Goal g in _goals)
        {
            lines.Add(g.SaveString());
        }

        File.WriteAllLines(filename, lines);
    }

    public void Load(string filename)
    {
        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");

            if (parts[0] == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3]),
                    bool.Parse(parts[4])
                ));
            }
            else if (parts[0] == "EternalGoal")
            {
                _goals.Add(new EternalGoal(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3])
                ));
            }
            else if (parts[0] == "ChecklistGoal")
            {
                _goals.Add(new ChecklistGoal(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3]),
                    int.Parse(parts[5]),
                    int.Parse(parts[6]),
                    int.Parse(parts[4])
                ));
            }
        }
    }
}