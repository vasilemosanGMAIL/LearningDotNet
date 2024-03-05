﻿namespace LearningLINQ
{
    internal class Exercise40
    {
        public static IEnumerable<DateTime> GetFridaysOfYear(int year, IEnumerable<DateTime> dates) =>
            dates.Where(date=>date.Year ==year &&
            date.DayOfWeek ==DayOfWeek.Friday).Distinct();
    }
}
/*Implement the GetFridaysOfYear method, which given a collection of dates and a number representing the year,
 * returns a collection of all dates from this collection that are Fridays (without duplicates).
For example, for the following dates and year 2023:
24.03.2023 (Friday)
24.03.2023 (Friday) -> will be excluded as duplicate
25.03.2023 (Saturday) -> will be excluded as not a Friday
31.03.2023 (Friday)
08.03.2024 (Friday) -> will be excluded because it's not from the given year

The result shall be:
24.03.2023 (Friday)
31.03.2023 (Friday)

Tip: The DateTime object has a DayOfWeek property of the DayOfWeek enum type.

Implement using query synthax
        public static IEnumerable<DateTime> GetFridaysOfYear(int year, IEnumerable<DateTime> dates) 
        {
            List<DateTime> fridays = (from date in dates.Distinct()
                                      where date.DayOfWeek == DayOfWeek.Friday && date.Year == year
                                      select date).ToList();

            return fridays;
        }
 */