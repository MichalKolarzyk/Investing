using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicModels;

namespace Repositories.Interfaces
{
    public interface IPricesOutSource
    {
        Prices GetPrices(Companies companies);
    }
}
