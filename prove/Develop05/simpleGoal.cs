using System.ComponentModel.DataAnnotations;

class SimpleGoal : Goal
{
    private bool _completed;

    public SimpleGoal(string name, string desc, int points)
        :base(name, desc, points)
    {
        _completed = false;
    }

    public override string GetGoalDetails()
    {
        return $"{_name}: {_desc} Points: {_points} Completed: {(_completed ? "[X]" : "[]")}";
    }

    public override string GetGoalDetailsForSave()
    {
        return $"SimpleGoal|{_name}|{_desc}|{_points}";
    }

    public virtual void IsCompleted()
    {
        _completed = true;
    }
    
}