namespace AdvancedC_Types;

internal class Nullable
{
    void main()
    {
        string text = null;

        //below 2 lines represent the same
        int? numberOrNull = null;
        Nullable<bool> boolOrNull = null;

        if (numberOrNull.HasValue)
        {
            Console.WriteLine("not null");
        }
        #nullable enable
        string nullableString = null;
        Console.WriteLine(nullableString.Length);
    }


    static string FormatHousesData(IEnumerable<House> houses)
    {
        return string.Join("\n",
            houses.Select(house =>
            $"Owner is {house.OwnerName}, " +
            $"address is {house.Address.Number} " +
            $"{house.Address.Street}"));
    }

}

