public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

// Constructor to initialize the address fields
    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }
    public string StreetAddress
    {
        get { return _streetAddress; }
        set { _streetAddress = value; }
    }

    public string City
    {
        get { return _city; }
        set { _city = value; }
    }

    public string StateOrProvince
    {
        get { return _stateOrProvince; }
        set { _stateOrProvince = value; }
    }

    public string Country
    {
        get { return _country; }
        set { _country = value; }
    }

    public bool IsUSA()
    {
        return _country.Trim().ToUpper() == "USA" || _country.Trim().ToUpper() == "UNITED STATES" || _country.Trim().ToUpper() == "UNITED STATES OF AMERICA";
    }
    public void DisplayAddress()
    {
        Console.WriteLine($"{_streetAddress}, {_city}, {_stateOrProvince}, {_country}");
    }

    // method to return if US address or foreign

    // method to return to display the address in a string format with new lines where appropriate
}