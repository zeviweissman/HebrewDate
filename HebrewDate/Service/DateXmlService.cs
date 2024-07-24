using HebrewDate.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static HebrewDate.Configuration.AppConfiguration;
using static System.Windows.Forms.LinkLabel;
namespace HebrewDate.Service
{
    internal class DateXmlService
    {
        public static void CreateXmlIfNotExist()
        {
            if (!File.Exists(DatesPath))
            {
                XDocument document = new();
                XElement drinks = new("Queries");
                document.Add(drinks);
                document.Save(DatesPath);
            }
        }


        public static XElement DateRecordToXElement(DateRecord date) =>
            new("Query",
                new XElement("Day", date.Day),
                new XElement("DayMonth", date.DayMonth),
                new XElement("Month", date.Month),
                new XElement("Year", date.Year),
                new XElement("Result", date.Result));


        public static void AddQuery(DateRecord date)
        {
            XDocument document = XDocument.Load(DatesPath);
            XElement queries = document.Descendants("Queries").First();
            if (queries is XElement)
            {
                queries.Add(DateRecordToXElement(date));
                document.Save(DatesPath);
            }
        }




    }
}
