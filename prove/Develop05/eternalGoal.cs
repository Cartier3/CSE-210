class EternalGoal : Goal
{
    List<Goal> listE = new List<Goal>();

    public EternalGoal(string name, string desc, int points)
        :base(name, desc, points)
    {
        
    }

    public void Display()
    {
        Console.WriteLine("Your Eternal Goals are:");
        Console.WriteLine($"\nName: ");
        Console.WriteLine($"Description: ");
        Console.WriteLine($"Point Value: ");
    }

    public void GetRed()
    {

    }

    public void SetRed()
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