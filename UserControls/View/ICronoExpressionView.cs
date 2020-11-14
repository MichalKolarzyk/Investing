using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControls.View
{
    public interface ICronoExpressionView
    {
        string Seconds { get; set; }
        string Minutes { get; set; }
        string Days { get; set; }
        string Hours { get; set; }
        string Months { get; set; }
        string WeekDays { get; set; }
    }
}
