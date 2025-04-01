class Address
{
    private string _streetAd;

    private string _city;

    private string _stateProv;

    private string _country;


    public Address(string streetAd, string city, string stateProv, string country)
    {
        _streetAd = streetAd;

        _city = city;

        _stateProv = stateProv;

        _country = country;
    }

    public string StringAddress()
    {
        return $"{_streetAd} {_city}, {_stateProv}, {_country}";
    }


}