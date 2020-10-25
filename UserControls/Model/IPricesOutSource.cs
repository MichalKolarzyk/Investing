using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControls.Model
{
    public interface IPricesOutSource
    {
        Prices GetPrices(Companies companies);
    }
}
