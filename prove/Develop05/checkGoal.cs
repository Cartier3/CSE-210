using System.Data;

class CheckGoal : Goal
{
    private bool _completed;

    private int _bonusPoints;

    private int _total;

    private int _goalTimes;

    private int _currentTimesCount;

    private bool _bonusAdded;

    public CheckGoal(string name, string desc, int points, int bonusPoints, int goalTimes)
        :base(name, desc, points)
    {
        _completed = false;

        _total = 0;
        
        _bonusPoints = bonusPoints;

        _goalTimes = goalTimes;

        _currentTimesCount = 0;

        _bonusAdded = false;
    }

    public override string GetGoalDetails()
    {
        return $"{_name} - {_desc}  Points: {_points} Completed:({_currentTimesCount} / {_goalTimes} times) Bonus Points: {_bonusPoints}";
    }

     public override string GetGoalDetailsForSave()
    {
        return $"CheckGoal|{_name}|{_desc}|{_points}|{_bonusPoints}|{_goalTimes}";
    }

    public void RecordCompletion()
    {
        if (_currentTimesCount < _goalTimes)
        { 
            _currentTimesCount++;
        }

        else if (_currentTimesCount == _goalTimes)
        {
            IsCompleted();

            _bonusAdded = true; 
        
            GetTotal();

            Console.WriteLine($"\nCongratulations! You earned a bonus of {_bonusPoints} points for completing this goal!!!");
        }
    }

    public virtual void IsCompleted()
    {
        _completed = true;
    }  

    public int GetTotal()
    {
        if (_currentTimesCount == _goalTimes && !_bonusAdded)
        {
            _total = _points + _bonusPoints;
        }
        else
        {
            _total = _points;
        }

        return _total;
    }
}