using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace DataAccess
{
    public class SQLAccess
    {
        private SQLConfig sqlConfig;

        public SQLAccess(SQLConfig sqlConfig)
        {
            this.sqlConfig = sqlConfig;
        }

        public void InsertCompany(Company company)
        {
            throw new NotImplementedException();
        }

        public Company GetCompany(string companyId)
        {
            throw new NotImplementedException();
        }

        public void RemoveCompany(Company company)
        {
            throw new NotImplementedException();
        }

        public void InsertPrices(List<Price> prices)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(sqlConfig.ConnectionString))
            {
                string storedProcedure = $"dbo.Prices_Insert @CompanyID, @Value, @Date, @TimeScale, {sqlConfig.PricesTable}";
                connection.Execute(storedProcedure, prices);
            }
        }

        public List<Price> GetPrices(string companyId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(sqlConfig.ConnectionString))
            {
                string storedProcedure = $"dbo.Prices_GetByCompanyId @CompanyId, {sqlConfig.PricesTable}";
                var storedProcedureArgs = new { CompanyId = companyId};
                List<Price> output = connection.Query<Price>(storedProcedure, storedProcedureArgs).ToList();
                return output;
            }
        }

        public void RemovePrices(List<Price> prices)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(sqlConfig.ConnectionString))
            {
                connection.Execute($"dbo.Prices_Remove @CompanyId, @Date, {sqlConfig.PricesTable}", prices);
            }
        }
    }
}
