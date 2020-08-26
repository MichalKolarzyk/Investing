using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YahooFinanceApi;

namespace DataAccess
{
    public static class YahooAccess
    {
        public async static Task<List<Price>> GetPrices(Companies companies)
        {
            var kosSymbol = "KOS";
            var securities = await Yahoo.Symbols(companies.ConvertIdsToArray()).Fields(Field.RegularMarketPrice).QueryAsync();

            var security = securities[kosSymbol];
            var securitySymbol = security[Field.RegularMarketPrice];

            return new List<Price>();
        }
    }
}
