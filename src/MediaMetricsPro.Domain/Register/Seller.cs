namespace MediaMetricsPro.Domain.Register;

public class Seller
{
    public Seller(int id, string name, Address address)
    {
        Id = id;
        Name = name;
        Address = address;
        Status = Status.Active;
    }

    public long Id { get; private set; }
    public string Name { get; private set; }
    public Address Address { get; private set; }
    public Status Status { get; private set; }
}
