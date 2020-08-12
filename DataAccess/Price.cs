using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public enum TimeScale
    {
        OneMinute = 10,
        OneHour = 20,
        OneWeek = 30,
        OneMonth = 40,
        OneYear = 50
    }

    public class Price
    {
        public string CompanyId { get; set; }
        public float Value { get; set; }
        public DateTimeOffset Date { get; set; }
        public TimeScale TimeScale { get; set; }

    }
}
