namespace Exeptions
{
    public class Exercise29
    {
        public static int GetMaxValue(List<int> numbers)
        {
            try
            {
                return numbers.Max();
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException("The numbers list cannot be null.", ex);
            }

            catch(InvalidOperationException ex)
            {
                Console.WriteLine("The numbers list cannot be empty.");
                throw;
            }

        }
    }
}
