namespace AdvancedC_Types;

internal class Person2
{
    public int Id { get; init; }
    public string Name { get; init; }

    public Person2(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public override bool Equals(object? obj)
    {
        return obj is Person2 other && Id == other.Id;
    }
}
