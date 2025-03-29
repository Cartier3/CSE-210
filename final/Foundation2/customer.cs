class Customer
{
    private int _id;
    private string _name;

    // Calls an instance of the Address class so that it can fit into the customer class constructor!
    private Address _address;

    public Customer(int id, string name, Address address)
    {
        _id = id;

        _name = name;

        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public string GetStringCust()
    {
        return $"{_id}- {_name} || {_address}";
    }

}