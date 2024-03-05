namespace Exeptions
{
    public class Exercise28
    {
        public static int DivideNumbers(int a, int b)
        {
            try
            {
                if (b == 0)
                {

                    Console.WriteLine("Division by zero.");
                    return 0;
                }
                else
                {
                    Console.WriteLine($"{a}/{b} is: {a / b}");
                    return a / b;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return 0;
            }

            finally
            {
                Console.WriteLine("The DivideNumbers method ends.");
            }

        }
    }
}
