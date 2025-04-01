class OutdoorGatherings : Event
{
    private string _type = "Outdoor Gathering";

    private string _weather;
    
    public OutdoorGatherings(string title, string desc, string date, string time, Address address, string weather) : base(title, desc, date, time, address)
    {   
        _weather = weather;
    }

    // Each class has their own unique methods which display the Full Details and the Short Description of each different type of event.
     public void DisplayOutdFullDetails()
    {
        Address _addy = GetAddress();
        
        Console.WriteLine($"\n*{GetTitle()}*({_type}): {GetDesc()} | Date: {GetDate()} | Time: {GetTime()} | Address: {_addy.StringAddress()}");
        Console.WriteLine($"\nWeather Statement: {_weather}");
    }

    public void DisplayOutdShortDesc()
    {
        Console.WriteLine($"\nEvent Type: {_type} | *{GetTitle()}* - Date: {GetDate()} ");
    }



}