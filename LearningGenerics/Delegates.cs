namespace LearningGenerics
{
    public class Delegates
    {

        delegate string ProcessString(string str);
        delegate void Print(string str);

        public static void Run()
        {
            ProcessString processString1 = TrimTo5Letters;
            ProcessString processString2 = ToUpper;

            Console.WriteLine(processString1("Hellllllllooo"));

            Print print1 = text => Console.WriteLine(text.ToUpper());
            Print print2 = text => Console.WriteLine(text.ToLower());
            Print multicast = print1 + print2;

            Print print4 = text => Console.WriteLine(text.Substring(0, 3));
            multicast += print4;
            multicast("Crocodile");
        }

        static string TrimTo5Letters(string str)
        {
            return str.Substring(0, Math.Min(str.Length, 5));
        }

        static string ToUpper(string str)
        {
            return str.ToUpper();
        }

    }
}
