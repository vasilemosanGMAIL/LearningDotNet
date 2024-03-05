namespace AdvancedC_Types;

// Struct
struct Point : IEquatable<Point>
{
    public int X { get; set; }
    public int Y { get; set; }
    public Point(int x, int y)
    {
        X = x; Y = y;
    }

    //by default Equals use reflection that is why it makes sense to override to improve performance
    public override bool Equals(object? obj)//boxing happens here
    {
        return obj is Point point &&
            X == point.X
            && Y == point.Y;
    }

    public bool Equals(Point point)//boxing is not happening here
    //and runtime will pick this version of Equals
    {
        return X == point.X && Y == point.Y;
    }

    public override string ToString() => $"X: {X}, Y:{Y}";

    //without Operators overloading
    //public Point Add(Point point2) =>
    //    new Point(X + point2.X, Y + point2.Y);

    ///with Operators overloading
    public static Point operator +(Point a, Point b) =>
        new Point(a.X + b.X, a.Y + b.Y);

    public static implicit operator Point(Tuple<int, int> tuple) =>
        new Point(tuple.Item1, tuple.Item2);

    public override int GetHashCode()
    {
        return GetHashCode();
    }
}

struct FishyStruct
{
    public List<int> Number { get; init; }
}