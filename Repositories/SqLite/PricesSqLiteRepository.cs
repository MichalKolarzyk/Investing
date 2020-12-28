using BasicModels;
using Repositories.Interfaces;
using Repositories.SqLite.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.SqLite
{
    public class PricesSqLiteRepository : IPriceRepository
    {
        SqLiteAccess sqlightAccess;
        public PricesSqLiteRepository(string databasePath)
        {
            sqlightAccess = new SqLiteAccess(databasePath);
        }
        public Prices GetPrices(ICompany company)
        {
            return sqlightAccess.GetPrices(company);
        }

        public void InserPrices(Prices prices)
        {
            sqlightAccess.AddPrices(prices);
        }

        public void RemocePrices(ICompany company)
        {
            sqlightAccess.RemovePrice(company);
        }
    }
}
