namespace LearningGenerics
{
    internal class SimpleTuple<T1, T2>
    {
        public T1 Item1 { get; }
        public T2 Item2 { get; }

        public SimpleTuple(T1 item1, T2 item2)
        {
            Item1 = item1;
            Item2 = item2;
        }
    }
    // we can have same class name but with different parameters
    internal class SimpleTuple<T1, T2, T3>
    {
        public T1 Item1 { get; }
        public T2 Item2 { get; }
        public T3 Item3 { get; }

        public SimpleTuple(T1 item1, T2 item2, T3 item3)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
        }
    }
}
