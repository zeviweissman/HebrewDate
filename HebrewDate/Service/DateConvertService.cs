using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HebrewDate.Service
{
    internal class DateConvertService
    {
        static List<string> monthsList = ["תשרי", "מרחשון", "כסלו", "טבת", "שבט", "אדר", "אדר הראשון", "אדר השני", "ניסן", "אייר", "סיון", "תמוז", "אב", "אלול", "תשרי"];
        static List<string> days = ["באחד", "בשני", "בשלישי ", "ברביעי", "בחמישי", "בששי"];
        static List<string> dayMonths = ["יום אחד", "שני ימים", "שלשה ימים", "ארבעה ימים", "חמישה ימים", "ששה ימים", "שבעה ימים", "שמונה ימים", "תשעה ימים", "עשרה ימים", "אחד עשר יום", "שנים עשר יום", "שלשה עשר יום", "ארבעה עשר יום", "חמשה עשר יום", "ששה עשר יום", "שבעה עשר יום", "שמונה עשר יום", "תשעה עשר יום", "עשרים יום", "אחד ועשרים יום", "שנים ועשרים יום", "שלשה ועשרים יום", "ארבעה ועשרים יום", "חמשה ועשרים יום", "ששה ועשרים יום", "שבעה ועשרים יום", "שמונה ועשרים יום", "תשעה ועשרים יום"];
        static List<string> years = ["שמנים וארבע", "שמנים וחמש", "שמנים ושש", "שמנים ושבע", "שמנים ושמונה", "שמנים ותשע", "תשעים", "תשעים ואחת", "תשעים ושתיים", "תשעים ושלוש"];

        public static string ConvertDay(int day) => 
            days[day]+" בשבת ";
        
        
        public static string ConvertDayMonth(int dayMonth, int imonth)
        {
            if (dayMonth == 29)
            {
                return ConvertDayMonth30(imonth);
            }
                return dayMonths[dayMonth] + $" לירח {monthsList[imonth]}";          
        }
        
        public static string ConvertYear(int year) =>      
             " שנת חמשת אלפים ו" + years[year] + " לבריאת העולם";
        


        public static string ConvertToResult(int day, int dayMonth,int month, int year)
        {
            string resDay = ConvertDay(day);
            string resDayMonth = ConvertDayMonth(dayMonth, month);          
            string resYear = ConvertYear(year);
            return resDay + resDayMonth  + resYear;
        }

        public static string ConvertDayMonth30(int imonth)
        {
            if (imonth == 5)
            {
                return $"יום שלושים לחודש {monthsList[5]} שהוא ראש חודש {monthsList[8]} ";

            }

            return $"יום שלושים לחודש {monthsList[imonth]} שהוא ראש חודש {monthsList[imonth+1]} ";
        }
    }
}
