namespace AdvancedC_Types;

internal class Exercise44
{
    [MustBeLargerThan(100)] // Applies to Value property
    public int Value { get; }
}

[AttributeUsage(AttributeTargets.Property)]
internal class MustBeLargerThan : Attribute //to create custom attribute we must create a class derived from Attribute class 
{
    public int Min { get; }

    public MustBeLargerThan(int min)
    {
        Min = min;
    }

}