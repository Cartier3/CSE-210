class Lecture : Event
{
    private string _type = "Lecture";

    private string _speaker;

    private int _capacity;

    public Lecture(string title, string desc, string date, string time, Address address, string speaker, int capacity) : base(title, desc, date, time, address)
    {   
        _speaker = speaker;

        _capacity = capacity;
    }

    // Each class has their own unique methods which display the Full Details and the Short Description of each different type of event. 
     public void DisplayLecFullDetails()
    {
        Address _addy = GetAddress();
        
        Console.WriteLine($"\n*{GetTitle()}*({_type}): {GetDesc()} | Date:{GetDate()} | Time: {GetTime()} | Address: {_addy.StringAddress()}");
        Console.WriteLine($"\nSpeaker: {_speaker} | Capacity: {_capacity}");
    }

    public void DisplayLecShortDesc()
    {
        Console.WriteLine($"\nEvent Type: {_type} | *{GetTitle()}* - Date: {GetDate()} ");
    }

}