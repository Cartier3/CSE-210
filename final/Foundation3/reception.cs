class Reception : Event
{
    private string _type = "Reception";

    private string _email;

    public Reception(string title, string desc, string date, string time, Address address, string email) : base(title, desc, date, time, address)
    {   
        _email = email;
    }

    // Each class has their own unique methods which display the Full Details and the Short Description of each different type of event.
     public void DisplayRecFullDetails()
    {
        Address _addy = GetAddress();
        
        Console.WriteLine($"\n*{GetTitle()}*({_type}): {GetDesc()} | Date: {GetDate()} | Time: {GetTime()} | Address: {_addy.StringAddress()}");
        Console.WriteLine($"\nRSVP Email: {_email}");
    }

    public void DisplayRecShortDesc()
    {
        Console.WriteLine($"\nEvent Type: {_type} | *{GetTitle()}* - Date: {GetDate()} ");
    }



}