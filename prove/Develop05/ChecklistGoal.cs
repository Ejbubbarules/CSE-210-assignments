public class ChecklistGoal : Goal
{
    private int _target;
    private int _current;
    private int _bonus;

    public ChecklistGoal(string name, string desc, int points, int target, int bonus, int current = 0)
        : base(name, desc, points)
    {
        _target = target;
        _bonus = bonus;
        _current = current;
    }

    public override int RecordEvent()
    {
        if (_current < _target)
        {
            _current++;

            if (_current == _target)
                return _points + _bonus;

            return _points;
        }
        return 0;
    }

    public override bool IsComplete() => _current >= _target;

    public override string GetStatus()
    {
        return $"[{(_current >= _target ? "X" : " ")}] {_name} ({_current}/{_target})";
    }

    public override string SaveString()
    {
        return $"ChecklistGoal|{_name}|{_description}|{_points}|{_current}|{_target}|{_bonus}";
    }
}