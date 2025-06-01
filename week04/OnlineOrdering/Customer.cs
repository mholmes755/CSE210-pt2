public class Customer
{
    private string _firstName;
    private string _lastName;
    private Address _address;


    public Customer(string firstName, string lastName, Address address)
    {
        _firstName = firstName;
        _lastName = lastName;
        _address = address;
    }

        public string FirstName // getter and setter for product name
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    public string LastName // getter and setter for product name
    {
        get { return _lastName; }
        set { _lastName = value; }
    }

    public void IsUS()
    {
        bool isUs = _address.IsUSA();
    }

}