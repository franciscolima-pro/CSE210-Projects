class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public bool ifInUsa()
    {
        return _country.ToUpper() == "USA";
    }
    public string getAddress()
    {
        return $"Address: {_street},{_city} / {_state}-{_country}";
    }
}
