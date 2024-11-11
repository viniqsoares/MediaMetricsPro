namespace MediaMetricsPro.Domain.Register;

public class Country
{
    public Country()
    {
    }

    public Country(short id, string name) : base()
    {
        Id = id;
        Name = name;
    }

    public long Id { get; private set; }
    public string Name { get; private set; }
}