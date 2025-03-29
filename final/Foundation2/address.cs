using System.Data.Common;
using System.Security.Authentication;

class Address
{
    private string _streetAd;

    private string _city;

    private string _stateProv;

    private string _country;

    private bool _ifUS;

    public Address(string streetAd, string city, string stateProv, string country)
    {
        _streetAd = streetAd;

        _city = city;

        _stateProv = stateProv;

        _country = country;
    }

    public string GetStreetAd()
    {
        return _streetAd;
    }

    public string GetCity()
    {
        return _city;
    }

    public string GetStateProv()
    {
        return _stateProv;
    }

    public string GetCountry()
    {
        return _country;
    }

    public string GetFullAddy()
    {
        return $"{_streetAd}, {_city}, {_stateProv}, {_country}";
    }

    public bool CheckIfUS()
    {   
        // This method sets the _ifUS method to true if the string entered in the constructor reads "US", if not it sets the statement to false. 
        if (_country == "US")
        {
            _ifUS = true;
        }
        else if (_country != "US")
        {
            _ifUS = false;
        }

        return _ifUS;
    }
}