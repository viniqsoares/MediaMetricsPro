namespace MediaMetricsPro.Domain.Register;

public class Address
{
    public Address(Guid id, string street, string number, string district, string city, State state)
    {
        Id = id;
        Street = street;
        Number = number;
        District = district;
        City = city;
        State = state;
    }

    public Guid Id { get; private set; }
    public string Street { get; private set; }
    public string Number { get; private set; }
    public string District { get; private set; }
    public string City { get; private set; }
    public State State { get; private set; }
}
