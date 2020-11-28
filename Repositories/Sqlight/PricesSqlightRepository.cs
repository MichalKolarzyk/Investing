using BasicModels;
using Repositories.Interfaces;
using SqLiteDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Sqlight
{
    public class PricesSqlightRepository : IPriceRepository
    {
        SqLiteAccess sqlightAccess;
        public PricesSqlightRepository()
        {
            sqlightAccess = new SqLiteAccess();
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
