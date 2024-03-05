using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCourse
{
    internal class MedicalAppointment
    {
        private string _patientName;
        private DateTime _date;

        public MedicalAppointment(string patientName)
        {
            _patientName = patientName;
            _date = DateTime.Now.AddDays(7);
        }

        public MedicalAppointment(DateTime date) :
            this("Vasile")
        {
            _date = date;
        }

        public MedicalAppointment(string patientName, int daysFromNow)
        {
            _patientName = patientName;
            _date = DateTime.Now.AddDays(7);
        }

        public void Reschedule(DateTime date)
        {
            _date = date;
        }

        public void Reschedule(int month, int day)
        {
            _date = new DateTime(_date.Year, month, day);
        }


    }
}
