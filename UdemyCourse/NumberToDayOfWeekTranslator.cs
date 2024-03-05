using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCourse
{
    public static class NumberToDayOfWeekTranslator
    {
        public static string Translate(int number)
        {
            string dayName;

            switch (number)
            {
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                case 7:
                    dayName = "Sunday";
                    break;
                default:
                    dayName = "Invalid day of the week";
                    break;
            }

            return dayName;
        }
    }

    public static class StringsTransformator
    {
        public static string TransformSeparators(
            string input,
            string originalSeparator,
            string targetSeparator)
        {
            string[] initialResult = input.Split(originalSeparator);
            string final = string.Join(targetSeparator, initialResult);
            return final;
        }
    }
}
