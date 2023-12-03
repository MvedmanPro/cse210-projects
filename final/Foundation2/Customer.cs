public class Customer
{
    private string _name;
    private Address address;

    public Customer(string name, Address address)
    {
        this._name = name;
        this.address = address;
    }

    public string GetName()
    {
        return this._name;
    }

    public void SetName(string name)
    {
        this._name = name;
    }

    public Address GetAddress()
    {
        return this.address;
    }

    public void SetAddress(Address address)
    {
        this.address = address;
    }

    public bool LivesInUSA()
    {
        return this.address.IsInUSA();
    }
}