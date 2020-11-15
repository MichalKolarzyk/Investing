using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicModels
{
    public interface IPrice
    {
        string CompanyId { get; set; }
        float Value { get; set; }
        DateTimeOffset Date { get; set; }
        TimeScale TimeScale { get; set; }
    }
}
