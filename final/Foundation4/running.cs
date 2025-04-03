public class Running : Activity
{
    // Distance is exclusively tracked in the 'running' class. 
    
    private int _distance;
    
    public Running(int minutes, DateOnly date, int distance) : base(minutes, date)
    {
        _distance = distance;
    }

    // Each method in the child classes is overridden based on which variables need to be calculated or not. 

    public override double CalcDistance()
    {
        return _distance;
    }

    public override double CalcSpeed()
    {
        double _speed = _distance / GetMinutes() * 60;

        return _speed;
    }

    public override double CalcPace()
    {
        double _pace = GetMinutes() / _distance;

        return _pace;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{GetDate()} Running({GetMinutes()} minutes) - Distance: {CalcDistance()} miles, Speed: {CalcSpeed()} mph, Pace: {CalcPace()} min per mile");
    }

}