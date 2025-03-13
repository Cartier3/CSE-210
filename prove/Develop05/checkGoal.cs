using System.Data;

class CheckGoal : Goal
{
    private int completed;

    private int total;

    private int finishPoint;

    public CheckGoal(string name, string desc, int points)
        :base(name, desc, points)
    {
        
    }

    public virtual void IsCompleted()
    {

    }

    public virtual void SetCompleted()
    {

    }

    public virtual void GetGoalPoint()
    {
        
    }


}