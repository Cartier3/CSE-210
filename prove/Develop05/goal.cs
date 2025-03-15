using System.ComponentModel;

class Goal
{
    protected string _name;

    protected string _desc;

    protected int _points;

    public Goal(string name, string desc, int points)
    {
        _name = name;

        _desc = desc;

        _points = points;
    }

    public virtual string GetGoalDetails()
    {
        return $"{_name}: {_desc} Points: {_points} points";
    }

    public virtual string GetGoalDetailsForSave()
    {
        return $"SimpleGoal|{_name}|{_desc}|{_points}";
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDesc()
    {
        return _desc;
    }

    public int GetPoints()
    {
        Console.WriteLine($"\nCongratulations! You have earned {_points} points!!");
        
        return _points;
    }

}