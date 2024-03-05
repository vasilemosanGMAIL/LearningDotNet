using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCourse
{
    internal class Exercise24
    {
        public static string? Describe(object someObject)
        {
            if(someObject.GetType() == typeof(int)) return $"Int of value {someObject}";
            if (someObject.GetType() == typeof(double)) return $"Double of value {someObject}";
            if (someObject.GetType() == typeof(decimal)) return $"Decimal  of value {someObject}";
            else return null;
        }
    }
}
