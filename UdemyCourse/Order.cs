using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UdemyCourse
{
    public class Order
    {
        public string Item {get;}
        private DateTime _date;
        public DateTime Date
        {
            get { return _date; }
            set
            {
                if (value.Year == DateTime.Now.Year)
                {
                    _date = value;
                }
            }
        }

        public Order(string item, DateTime date)
        {
            Item = item;
            Date = date;
        }
    }
}
