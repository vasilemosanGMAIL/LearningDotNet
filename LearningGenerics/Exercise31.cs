namespace LearningGenerics
{
    internal class Exercise31<T>
    {
        public T First { get; private set; }
        public T Second { get; private set; }

        public Exercise31(T first, T second)
        {
            First = first;
            Second = second;
        }
        
        public void ResetFirst()
        {
            First = default;
        }

        public void ResetSecond()
        {
            Second = default;
        }
    }
}
