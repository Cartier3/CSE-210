using System.ComponentModel.DataAnnotations;

class Event
{
    private string _title;

    private string _desc;

    private string _date;

    private string _time;
    
    private Address _address;

    public Event(string title, string desc, string date, string time, Address address)
    {
        _title = title;

        _desc = desc;

        _date = date;

        _time = time;

        _address = address;
    }

    // The common method which displays the standard details of each event with the shared attributes.
    public void DisplayStandardDetails()
    {
        Address _addy = GetAddress();

        Console.WriteLine("  ");
        Console.WriteLine("  ");
        Console.WriteLine($"\n*{_title}* : {_desc} | Date: {_date} | Time: {_time} | Address: {_addy.StringAddress()}");
    }

    // Getters which return the variables to keep the member variables private in the parent class. 
    public string GetTitle() 
    {
        return _title;
    }

    public string GetDesc() 
    {
        return _desc;
    }

    public string GetDate() 
    {
        return _date;
    }

    public string GetTime()
    {
        return _time;
    }

    public Address GetAddress()
    {
        return _address;
    }

}