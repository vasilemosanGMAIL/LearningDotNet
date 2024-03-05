
namespace AdvancedC_Types
{
  public struct Time
    {
        private int Hour { get; init; }
        private int Minute { get; init; }
        public Time(int hour, int minute)
        {
            if (hour < 0 || hour > 23) throw new ArgumentOutOfRangeException("Hour out of range 0-23");
            else Hour = hour;

            if (minute < 0 || minute > 59) throw new ArgumentOutOfRangeException("Minute out of range 0-59");
            else Minute = minute;
        }

        public override string ToString()
        {
            return $"{Hour.ToString("00")}:{Minute.ToString("00")}";
        }
    }
}
