using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SQLConfig
    {
        public string ConnectionString { get; set; }
        public string PricesTable { get; set; }

        public SQLConfig(string connectionString)
        {
            this.ConnectionString = connectionString;
            this.PricesTable = "Prices";
        }

    }
}
