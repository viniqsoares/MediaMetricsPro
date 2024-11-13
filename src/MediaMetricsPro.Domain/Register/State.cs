namespace MediaMetricsPro.Domain.Register;

public class State
{
    public State()
    {
    }

    public State(short id, string name, Country country) : base()
    {
        Id = id;
        Name = name;
        Country = country;
    }

    public short Id { get; private set; }
    public string Name { get; private set; }

    public Country Country { get; private set; }
}
