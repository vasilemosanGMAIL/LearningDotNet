namespace LearningGenerics
{
    internal class SortedList<T> where T : IComparable<T>
    {
        public IEnumerable<T> Items { get; }

        public SortedList(IEnumerable<T> items)
        {
            var asList = items.ToList();
            asList.Sort();
            Items = asList;
        }
    }

    public class FullName : IComparable<FullName>
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }

        public override string ToString() => $"{FirstName} {LastName}";


        public int CompareTo(FullName other)
        {
            var lastNameCompareResult = LastName.CompareTo(other.LastName);
            if (lastNameCompareResult != 0) return lastNameCompareResult;
            else return FirstName.CompareTo(other.FirstName);
        }
    }
}
