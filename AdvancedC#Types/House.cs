namespace AdvancedC_Types;

internal class House
{
    public string OwnerName { get; }
    public Address Address { get; }
    public House(string ownerName, Address address)
    {
        if(ownerName == null) throw new ArgumentNullException(nameof(ownerName));

        if (address == null) throw new ArgumentNullException(nameof(address));

        OwnerName = ownerName;
        Address = address;
    }
}

class Address
{
    public string Street { get; }
    public string Number { get; }

    public Address(string street, string number)
    {
        if (street == null) throw new ArgumentNullException(nameof(street));

        if (number == null) throw new ArgumentNullException(nameof(number));

        Street = street;
        Number = number;
    }
}