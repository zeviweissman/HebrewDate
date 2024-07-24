using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HebrewDate.Configuration
{
    internal class AppConfiguration
    {
        public static string DatesPath = Path.Combine(Directory.GetCurrentDirectory(), "Dates.xml");

    }
}
