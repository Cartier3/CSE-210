using System.ComponentModel.DataAnnotations;

class SimpleGoal : Goal
{
    private bool completed;

    public SimpleGoal(string name, string desc, int points)
        :base(name, desc, points)
    {
        completed = false;
    }

    public void Display()
    {
        Console.WriteLine("Your Simple Goals are:");
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