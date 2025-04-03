using System.Diagnostics.Contracts;

public abstract class Activity
{
    private int _minutes;

    private DateOnly _date;

    public Activity(int minutes, DateOnly date)
    {
        _minutes = minutes;

        _date = date;
    }

    // Uses polymorphism to create abstract methods as placeholders for the child classes to use each one and customize them according to what calculations need to be made.

    public abstract double CalcDistance();

    public abstract double CalcSpeed();

    public abstract double CalcPace();

    public abstract void GetSummary();

    // Getters for the minutes and dates for each class instance.
    
    public double GetMinutes()
    {
        return _minutes;
    }

    public DateOnly GetDate()
    {
        return _date;
    }

}