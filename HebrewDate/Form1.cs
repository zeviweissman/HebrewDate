using HebrewDate.Model;
using static HebrewDate.Service.DateConvertService;
using static HebrewDate.Service.DateXmlService;

namespace HebrewDate
{
    public partial class Form1 : Form
    {
        List<string> daysList = ["ראשון", "שני", "שלישי", "רביעי", "חמישי", "ששי"];
        List<int> dayMonthsList = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30];
        List<string> monthsList = ["תשרי", "מרחשון", "כסלו", "טבת", "שבט", "אדר", "אדר הראשון", "אדר השני", "ניסן", "אייר", "סיון", "תמוז", "אב", "אלול"];
        List<string> yearsList = ["תשפ\"ד", "תשפ\"ה", "תשפ\"ו", "תשפ\"ז", "תשפ\"ח", "תשפ\"ט", "תש\"ץ", "תשצ\"א", "תשצ\"ב", "תשצ\"ג"];

        public Form1()
        {
            InitializeComponent();
            CreateXmlIfNotExist();
            UpdateComboBoxs();
        }


        private void UpdateComboBoxs()
        {
            DaysCMBX.DataSource = daysList;
            DayMonthsCMBX.DataSource = dayMonthsList;
            MonthsCMBX.DataSource = monthsList;
            YearsCMBX.DataSource = yearsList;
        }

        private void GetHebrewDateBTN_Click(object sender, EventArgs e)
        {
            string day = DaysCMBX.Text;           
            string dayMonth = DayMonthsCMBX.Text;
            string month = MonthsCMBX.Text;
            string year = YearsCMBX.Text;
            int iday = DaysCMBX.SelectedIndex;
            int idayMonths = DayMonthsCMBX.SelectedIndex;
            int imonth = MonthsCMBX.SelectedIndex;
            int iyear = YearsCMBX.SelectedIndex;
            string result = ConvertToResult(iday, idayMonths, imonth, iyear);

            DateRecord date = new(day, dayMonth, month, year, result);
            LogResults.Text = date.Result;
            AddQuery(date);

        }
    }
}
