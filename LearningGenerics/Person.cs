namespace LearningGenerics
{
    internal class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int YearOfBirth { get; set; }

        public int CompareTo(Person other)
        {
            if (YearOfBirth < other.YearOfBirth) return 1;
            else if(YearOfBirth < other.YearOfBirth) return -1;
            return 0;
        }
    }
}
