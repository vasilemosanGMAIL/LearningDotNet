using static LearningLINQ.Program;

namespace LearningLINQ
{
    internal class Exercise41
    {
        public static double CalculateAverageDurationInMilliseconds(IEnumerable<TimeSpan> timeSpans)
        {
            if (!timeSpans.Any())
            {
                throw new ArgumentException("The collection cannot be empty.");
            }

            return timeSpans.Select(ts => ts.TotalMilliseconds).Average();
        }
    }
}
