using System.Numerics;

namespace LearningGenerics
{
    public static class Calculator
    {
        public static T Square<T>(T input) where T : INumber<T>
            => input * input;
    }
}
