using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControls.Model
{
    public class PricesSqlRepository : IPriceRepository
    {
        private SqlAccess sqlAccess { get; set; }
        public PricesSqlRepository(string connectionString)
        {
            sqlAccess = new SqlAccess(connectionString);
        }
        public Prices GetPrices(ICompany company)
        {
            return sqlAccess.GetPrices(company);
        }

        public void InserPrices(Prices prices)
        {
            sqlAccess.Insert(prices);
        }

        public void RemocePrices(ICompany company)
        {
            sqlAccess.RemovePrices(company);
        }
    }
}
