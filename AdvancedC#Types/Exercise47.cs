namespace Coding.Exercise
{
    public struct Time
    {
        public int Hour { get; }
        public int Minute { get; }

        public Time(int hour, int minute)
        {
            if (hour < 0 || hour > 23)
            {
                throw new ArgumentOutOfRangeException(
                    "Hour is out of range of 0-23");
            }
            if (minute < 0 || minute > 59)
            {
                throw new ArgumentOutOfRangeException(
                    "Minute is out of range of 0-59");
            }
            Hour = hour;
            Minute = minute;
        }

        public override string ToString() =>
            $"{Hour.ToString("00")}:{Minute.ToString("00")}";

        public static bool operator ==(Time t1, Time t2)
        {
            return t1.Hour == t2.Hour && t1.Minute == t2.Minute;
        }

        public static bool operator !=(Time t1, Time t2)
        {
            return !(t1 == t2);
        }

        public static Time operator +(Time t1, Time t2)
        {
            int totalMinutes = t1.Hour * 60 + t1.Minute + t2.Hour * 60 + t2.Minute;
            int newHour = totalMinutes / 60 % 24; // Trim to valid hour (0-23)
            int newMinute = totalMinutes % 60; // Trim to valid minute (0-59)
            return new Time(newHour, newMinute);
        }
    }
}
