using BasicModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YahooFinanceApi;

namespace Repositories.Yahoo.Api
{
    internal static class YahooAccess
    {
        public static Prices GetPrices(Companies companies)
        {
            return GetPricesAsync(companies).Result;
        }

        private async static Task<Prices> GetPricesAsync(Companies companies)
        {
            Prices prices = new Prices();
            if (companies.Count == 0)
            {
                return prices;
            }
            var securities = await YahooFinanceApi.Yahoo.Symbols(companies.GetIds()).Fields(Field.RegularMarketPrice).QueryAsync();
            foreach (Security security in securities.Values)
            {
                Company company = new Company(security.Symbol);
                Price price = new Price(company, (float)security.RegularMarketPrice);
                prices.Add(price);
            }
            return prices;
        }

        public async static Task<ICompany> GetCompany(string companyId)
        {
            var securities = await YahooFinanceApi.Yahoo.Symbols(companyId).Fields(Field.ShortName).QueryAsync();
            ICompany company = new Company
            {
                ID = securities[companyId].Symbol,
                FullName = securities[companyId].ShortName
            };
            return company;
        }
    }
}
