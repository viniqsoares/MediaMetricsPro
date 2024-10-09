namespace MediaMetricsPro.Domain.Register;

public class Seller
{
    public Seller(string name, Address address)
    {
        Name = name;
        Address = address;
        Status = Status.Active;
    }

    public long Id { get; set; }
    public string Name { get; set; }
    public Address Address { get; set; }
    public Status Status { get; set; }
}
