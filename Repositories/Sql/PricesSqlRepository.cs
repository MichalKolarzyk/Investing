using Repositories.Sql.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicModels;
using Repositories.Interfaces;

namespace Repositories.Sql
{
    public class PricesSqlRepository : IPriceRepository
    {
        private SqlAccess _sqlAccess { get; set; }
        public PricesSqlRepository(string connectionString)
        {
            _sqlAccess = new SqlAccess(connectionString);
        }
        public Prices GetPrices(ICompany company)
        {
            return _sqlAccess.GetPrices(company);
        }

        public void InserPrices(Prices prices)
        {
            _sqlAccess.Insert(prices);
        }

        public void RemocePrices(ICompany company)
        {
            _sqlAccess.RemovePrices(company);
        }
    }
}
