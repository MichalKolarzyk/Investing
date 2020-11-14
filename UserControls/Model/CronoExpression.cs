using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControls.Model
{
    public class CronoExpression
    {
        public string Seconds { get; set; }
        public string Minutes { get; set; }
        public string Days { get; set; }
        public string Hours { get; set; }
        public string Months { get; set; }
        public string WeekDays { get; set; }

        public override string ToString()
        {
            string output = string.Empty;
            output += Seconds;
            output += " ";
            output += Minutes;
            output += " ";
            output += Days;
            output += " ";
            output += Hours;
            output += " ";
            output += Months;
            output += " ";
            output += WeekDays;
            return output;
        }
    }
}
