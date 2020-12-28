using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicModels;

namespace Repositories.Interfaces
{
    public interface IPriceRepository
    {
        Prices GetPrices(ICompany company);
        void InserPrices(Prices prices);
        void RemocePrices(ICompany company);
    }
}
