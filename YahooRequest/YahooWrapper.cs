using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using YahooFinanceApi;
using DataAccess;

namespace YahooRequest
{
    public static class YahooWrapper
    {
        public static async Task<List<Price>> GetCurrentPrices(List<Company> companies)
        {
            var securities = await Yahoo.Symbols(companyId).Fields(Field.RegularMarketPrice).QueryAsync();

            var security = securities[companyId];
            return security[Field.RegularMarketPrice];
        }

    }
}
