namespace AdvancedC_Types;

internal class ObjectToTextConverter
{
    public string Convert(object obj)
    {
        Type type = obj.GetType();
        var properties = type
        .GetProperties()
        .Where(p => p.Name != "EqualityContract");

        return String.Join(
           ",", properties
           .Select(property => $"{property.Name} is {property.GetValue(obj)}"));
    }
}

public record Pet(string Name, Type PetType, float Weight);
public record Housee(string Address, double Area, int Floors);
