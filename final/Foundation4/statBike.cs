public class StationaryBiking : Activity
{
    // Speed is exclusevily tracked within the 'Stationary Biking' Class. 
    private double _speed;
   
    public StationaryBiking(int minutes, DateOnly date, double speed) : base(minutes, date)
    {
        _speed = speed;
    }

    // Each method in the child classes is overridden based on which variables need to be calculated or not. 

    public override double CalcDistance()
    {
        double _distanceMil = _speed * GetMinutes() / 60;

        return _distanceMil;
    }

    public override double CalcSpeed()
    {
        return _speed;
    }

    public override double CalcPace()
    {
        double _pace = GetMinutes() / CalcDistance();

        return _pace;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{GetDate()} Stationary Biking({GetMinutes()} minutes) - Distance: {CalcDistance()} miles, Speed: {CalcSpeed()} mph, Pace: {CalcPace()} min per mile");
    }
}