using Flurl.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using YahooFinanceApi;

namespace DataAccess
{
    public static class YahooAccess
    {
        public static Prices GetPrices(Companies companies)
        {
            return getPrices(companies).Result;
        }

        private async static Task<Prices> getPrices(Companies companies)
        {
            Prices prices = new Prices();
            var securities = await Yahoo.Symbols(companies.GetIds()).Fields(Field.RegularMarketPrice).QueryAsync();
            foreach(Security security in securities.Values)
            {
                Company company = new Company(security.Symbol);
                Price price = new Price(company, (float)security.RegularMarketPrice);
                prices.Add(price);
            }
            return prices;
        }
    }
}
