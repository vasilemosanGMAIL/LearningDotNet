namespace AdvancedC_Types;

class Attributes
{
    private Person validPerson = new Person("John", 1981);
    Dog invalidDog = new Dog("RRR");
    Validator validator = new();


}

internal class Dog
{
    [StringLenghtValidateAttribute(2, 10)]
    public string Name { get; } //length must be between 2 and 10
    public Dog(string name) => Name = name;
}

internal class Person
{
    [StringLenghtValidateAttribute(2, 25)]
    public string Name { get; } //length must be between 2 and 10
    public int YearOfBirth { get; }
    public Person(string name, int yearOfBirth)
    {
        YearOfBirth = yearOfBirth;
        Name = name;
    }
}

class StringLenghtValidateAttribute : Attribute //to create custom attribute we must create a class derived from Attribute class 
{
    public int Min { get; }
    public int Max { get; }

    public StringLenghtValidateAttribute(int min, int max)
    {
        Min = min; Max = max;
    }

}

class Validator
{
    public bool Validate(object obj)
    {
        //return obj != null ? true : false;
        var type = obj.GetType();
        var propertiesToValidate = type.GetProperties()
            .Where(property => Attribute.IsDefined(
                property, typeof(StringLenghtValidateAttribute)));

        foreach (var item in propertiesToValidate)
        {
            object? propertyValue = item.GetValue(obj);
            if(propertyValue is not string)
            {
                throw new InvalidOperationException(
                    $"Attribute {nameof(StringLenghtValidateAttribute)}" + 
                    $" can only be applied to string");
            }

            var value = (string)propertyValue;
            var attribute = (StringLenghtValidateAttribute)
                item.GetCustomAttributes(
                    typeof(StringLenghtValidateAttribute), true).First();
            if(value.Length < attribute.Min || value.Length > attribute.Max)
            {
                Console.WriteLine($"Property {item.Name} is invalid" + 
                    $"Value is {value}");
                return true;
            }
            
        }
        return false;
    }  
}