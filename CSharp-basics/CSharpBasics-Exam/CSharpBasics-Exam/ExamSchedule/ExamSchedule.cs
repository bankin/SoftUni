using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSchedule
{
    class ExamSchedule
    {
        static void Main(string[] args)
        {
            int startHour = int.Parse(Console.ReadLine());
            int startMinutes = int.Parse(Console.ReadLine());
            string startPartOfDay = Console.ReadLine();

            int examHourDuration = int.Parse(Console.ReadLine());
            int examMinDuration = int.Parse(Console.ReadLine());
            int hourOfStart = startPartOfDay == "AM" ? startHour : startHour + 12;
            hourOfStart = hourOfStart == 24 ? 0 : hourOfStart;
            DateTime examStart = new DateTime(2014, 04, 12, hourOfStart, startMinutes, 0);

            //Console.WriteLine(examStart);

            examStart = examStart.AddHours(examHourDuration);
            examStart = examStart.AddMinutes(examMinDuration);

            //Console.WriteLine(examStart);
            
            int hour = (examStart.Hour > 12 ? examStart.Hour - 12 : examStart.Hour);
            int mins = examStart.Minute;
            Console.WriteLine((hour < 10 && hour > 0 ? "0" : "") + (hour == 0 ? 12 : hour) + ":" + (mins < 10 ? "0" : "") + mins + ":" + examStart.ToString("tt"));
        }
    }
}
