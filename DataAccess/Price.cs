using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{

    public class Price : IPrice
    {
        public string CompanyId { get; set; }
        public float Value { get; set; }
        public DateTimeOffset Date { get; set; }
        public TimeScale TimeScale { get; set; }

        public Price() { }

        public Price(Company company, float value)
        {
            CompanyId = company.ID;
            Value = value;
            Date = DateTimeOffset.Now;
            TimeScale = TimeScale.OneMinute;
        }

    }
}
