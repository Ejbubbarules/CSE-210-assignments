public class EternalGoal : Goal
{
    public EternalGoal(string name, string desc, int points)
        : base(name, desc, points) {}

    public override int RecordEvent()
    {
        return _points;
    }

    public override bool IsComplete() => false;

    public override string GetStatus()
    {
        return $"[∞] {_name}";
    }

    public override string SaveString()
    {
        return $"EternalGoal|{_name}|{_description}|{_points}";
    }
}