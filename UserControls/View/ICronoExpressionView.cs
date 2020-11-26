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
        string StartHour { get; set; }
        string EndHour { get; set; }
        string StartDay { get; set; }
        string EndDay { get; set; }
        string Months { get; set; }
        string Days { get; set; }
        string Preview { get; set; }
    }
}
