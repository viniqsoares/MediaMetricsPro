namespace MediaMetricsPro.Domain.Register;

public class Address
{
    public Address()
    {
    }

    public Address(long id, string street, string number, string district, string city, State state) : base()
    {
        Id = id;
        Street = street;
        Number = number;
        District = district;
        City = city;
        State = state;
    }

    public long Id { get; private set; }
    public string Street { get; private set; }
    public string Number { get; private set; }
    public string District { get; private set; }
    public string City { get; private set; }
    public State State { get; private set; }
}
