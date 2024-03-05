namespace NETUndeTheHood
{
    internal class Exercise42
    {
        public static void FastForwardToSummer(ref DateTime dateTime)
        {
            var firstDayOfSummer = new DateTime(dateTime.Year, 6, 1);
            if (dateTime < firstDayOfSummer) dateTime = firstDayOfSummer;
        }
        /*Implement the FastForwardToSummer method, which takes a DateTime object and potentially modifies it (but the method does not return anything!).
        If this date is after the first day of summer of its year, then it should not be modified.
        If it is before the first day of the summer of its year, it shall be modified so it represents the first day of the summer of its year.*/
    }
}
