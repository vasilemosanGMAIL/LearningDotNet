namespace AdvancedC_Types;

public record Person4(string FirstName, string LastName, int Age);
//Person 4 represents the same thing as below Person3 class with immutable properties 
public class Person3
{
    public string FirstName { get; }
    public string LastName { get; }
    public int Age { get; }

    public Person3(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    // Optional: Override Equals, GetHashCode, and ToString methods for value-based equality
    public override bool Equals(object obj)
    {
        if (obj is Person3 otherPerson)
        {
            return FirstName == otherPerson.FirstName &&
                   LastName == otherPerson.LastName &&
                   Age == otherPerson.Age;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(FirstName, LastName, Age);
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}, Age {Age}";
    }
}

internal class Record
{
}
