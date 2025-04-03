public class Swimming : Activity
{
    // Laps are used in the calculations for the 'swimming' class. 
    private double _laps;

    public Swimming(int minutes, DateOnly date, double laps) : base(minutes, date)
    {
        _laps = laps;
    }

    // Each method in the child classes is overridden based on which variables need to be calculated or not. 

    public override double CalcDistance()
    {
        double _distanceMil = _laps * 50 / 1000 * 0.62;

        return _distanceMil;
    }

    public override double CalcSpeed()
    {
        double distance = CalcDistance();
        
        double minutes = GetMinutes();
        
        double _speed = distance / minutes * 60;

        return _speed;
    }

    public override double CalcPace()
    {
        double _pace = 60 / CalcSpeed();

        return _pace;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{GetDate()} Swimming({GetMinutes()} minutes) - Distance: {CalcDistance()} miles, Speed: {CalcSpeed()} mph, Pace: {CalcPace()} min per mile");
    }
}