using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class DataAccessManager
    {
        public static void GetData(string connectionString)
        {
            SqlAccess sqlAccess = new SqlAccess(connectionString);
            Companies companies = sqlAccess.Get<Company>();
            Prices prices = YahooAccess.GetPrices(companies);
            sqlAccess.Insert(prices);
        }
        public static void Add(Companies companies, string connectionString)
        {
            SqlAccess sqlAccess = new SqlAccess(connectionString);
            sqlAccess.Insert(companies);
        }
    }
}
