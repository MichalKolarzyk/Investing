using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicModels;
using Repositories.Interfaces;
using Repositories.Yahoo.Api;

namespace Repositories.Yahoo
{
    public class PriceYahooRepository : IPricesOutSource
    {
        public Prices GetPrices(Companies companies)
        {
            return YahooAccess.GetPrices(companies);
        }
    }
}
