namespace AdvancedC_Types;

internal class Exercise46
{
    public string First { get; init; }
    public string Last { get; init; }

    public override bool Equals(object? obj)//boxing happens here
    {
        return obj is Exercise46 exercise &&
               First == exercise.First &&
               Last == exercise.Last;
    }

    public override string ToString() => $"{First} {Last}";

    //your code goes here

}
