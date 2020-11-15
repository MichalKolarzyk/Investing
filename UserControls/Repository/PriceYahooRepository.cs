using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicModels;

namespace UserControls.Repository
{
    public class PriceYahooRepository : IPricesOutSource
    {
        public Prices GetPrices(Companies companies)
        {
            return YahooAccess.GetPrices(companies);
        }
    }
}
