namespace MediaMetricsPro.Domain.Register;

public class Address
{
    public Address(long id, string street, int number, string district, string city, State state, Country country)
    {
        Id = id;
        Street = street;
        Number = number;
        District = district;
        City = city;
        State = state;
        Country = country;
    }

    public long Id { get; set; }
    public string Street { get; set; }
    public int Number { get; set; }
    public string District { get; set; }
    public string City { get; set; }
    public required State State { get; set; }
    public required Country Country { get; set; }
}
