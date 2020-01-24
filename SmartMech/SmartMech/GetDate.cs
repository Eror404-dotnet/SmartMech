using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMech
{
    class GetDate
    {
        public static string DateNow()
        {
            string dt =DateTime.Now.ToLongDateString();
            return dt;
        }

        public static string DayWeekNow()
        {
            string dayWeek;
            string LdayWeek;
            dayWeek = DateTime.Now.DayOfWeek.ToString();
            
            if (dayWeek == "Monday")
                LdayWeek = "Понедельник";
            else if (dayWeek == "Tuesday")
                LdayWeek = "Вторник";
            else if (dayWeek == "Wednesday")
                LdayWeek = "Среда";
            else if (dayWeek == "Thursday")
                LdayWeek = "Четверг";
            else if (dayWeek == "Friday")
                LdayWeek = "Пятница";
            else if (dayWeek == "Saturday")
                LdayWeek = "Суббота";
            else
                LdayWeek = "Воскресенье";
            return LdayWeek;

        }
    }
}
