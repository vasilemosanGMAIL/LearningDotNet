namespace Exercise27
{
    public interface INumericTransformation
    {
        int Transform(int input);
    }

    public class By1Incrementer : INumericTransformation
    {
        public int Transform(int input)
        {
            return input + 1;
        }
    }

    public class By2Multiplier : INumericTransformation
    {
        public int Transform(int input)
        {
            return input * 2;
        }
    }

    public class ToPowerOf2Raiser : INumericTransformation
    {
        public int Transform(int input)
        {
            return input * input;
        }
    }
 }
