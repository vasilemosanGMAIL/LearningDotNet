using System.Text.Json;
using System.Text.Json.Serialization;

namespace AdvancedC_Types;

internal class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Advanced C # Types" + Environment.NewLine);

        Console.WriteLine("Structs: do not store reference types inside structs");
        var fishyStruct1 = new FishyStruct { Number = new List<int> { 1, 2, 3 } };
        var fishyStruct2 = fishyStruct1;

        fishyStruct2.Number.Clear();

        var point = new Point(10, 20);
        //point.X++;
        Console.WriteLine(point.X++);

        var exercise45 = new Time(7, 7);
        Console.WriteLine(exercise45.ToString());
        // test the overridden Equals method
        var john = new Person2(1, "John");
        var theSAmeJohn = new Person2(1, "John");
        var marie = new Person2(2, "Marie");
        Console.WriteLine("john.Equals(theSAmeJohn): " + john.Equals(theSAmeJohn));
        Console.WriteLine("john.Equals(marie): " + john.Equals(marie));

        var point1 = new Point(1, 5);
        var point2 = new Point(2, 4);
        //var added = point1.Add(point2);//without Operators overloading
        var added = point1 + point2;
        Console.WriteLine("Operators overloading: " + added);
        var tuple = Tuple.Create(10, 20);
        Point point3 = tuple;/* It won't compile without: public static implicit operator Point(Tuple<int, int> tuple) =>
        new Point(tuple.Item1, tuple.Item2); */
        Console.WriteLine(Environment.NewLine + "Hash Codes");

        var dictionary = new Dictionary<Person2, int>();
        var martin = new Person2(6, "Martin");
        dictionary[martin] = 5;
        var theSameMartin = new Person2(6, "Martin");
        Console.WriteLine(martin.GetHashCode());
        Console.WriteLine(theSameMartin.GetHashCode());//Hash codes aren't match as GetHashCode for reference types

        //var dictionary2 = new Dictionary<Point, int>();
        //var point4 = new Point(27, 1);
        //dictionary2[point4] = 30;
        //var point5 = new Point(27, 1);
        //Console.WriteLine(dictionary2[point5]);//dictionary consider them the same key
        //Console.WriteLine(point4.GetHashCode());
        //Console.WriteLine(point5.GetHashCode());//Hash codes aren't match for value types

        Console.WriteLine(Environment.NewLine + "Records:");
        var rectlangle = new Rectangle(10, 20);
        rectlangle.A = 30;

        Console.WriteLine(Environment.NewLine + "API:");
        var baseAddress = "https://datausa.io/api/";
        var requestUri = "data?drilldowns=Nation&measures=Population";
        IApiDataReader apiDataReader = new ApiDataReader();
        var json = await apiDataReader.Read(baseAddress, requestUri);
        var root = JsonSerializer.Deserialize<Root>(json);

        foreach ( var yearLyData in root.data)
        {
            await Console.Out.WriteLineAsync($"Year: {yearLyData.Year}, " +
                $"population: {yearLyData.Population}");
        }

        Console.ReadKey();
    }
}

public record WeatherData(decimal Temperature, int Humidity);//it is a reference type immutable

public record struct Rectangle(int A, int B);//value tape mutable by default. if we want to make it immutable readonly keyword needs to be added

// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
public record Annotations(
    [property: JsonPropertyName("source_name")] string source_name,
    [property: JsonPropertyName("source_description")] string source_description,
    [property: JsonPropertyName("dataset_name")] string dataset_name,
    [property: JsonPropertyName("dataset_link")] string dataset_link,
    [property: JsonPropertyName("table_id")] string table_id,
    [property: JsonPropertyName("topic")] string topic,
    [property: JsonPropertyName("subtopic")] string subtopic
);

public record Datum(
    [property: JsonPropertyName("ID Nation")] string IDNation,
    [property: JsonPropertyName("Nation")] string Nation,
    [property: JsonPropertyName("ID Year")] int IDYear,
    [property: JsonPropertyName("Year")] string Year,
    [property: JsonPropertyName("Population")] int Population,
    [property: JsonPropertyName("Slug Nation")] string SlugNation
);

public record Root(
    [property: JsonPropertyName("data")] IReadOnlyList<Datum> data,
    [property: JsonPropertyName("source")] IReadOnlyList<Source> source
);

public record Source(
    [property: JsonPropertyName("measures")] IReadOnlyList<string> measures,
    [property: JsonPropertyName("annotations")] Annotations annotations,
    [property: JsonPropertyName("name")] string name,
    [property: JsonPropertyName("substitutions")] IReadOnlyList<object> substitutions
);

