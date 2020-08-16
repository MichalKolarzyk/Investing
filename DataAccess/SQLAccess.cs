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
        private string connectionString;

        public SQLAccess(string connectionString)
        {
            this.connectionString = connectionString;
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
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(this.connectionString))
            {
                connection.Execute("dbo.Prices_Insert @CompanyID, @Value, @Date, @TimeScale", prices);
            }
        }

        public List<Price> GetPrices(string companyId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(this.connectionString))
            {
                var sqlInput = new { CompanyID = companyId, TableName = "Prices_Test" };
                List<Price> output = connection.Query<Price>("dbo.Prices_GetByCompanyId @CompanyID, @TableName", sqlInput).ToList();
                return output;
            }
        }

        public void RemovePrices(List<Price> prices)
        {
            throw new NotImplementedException();
        }
    }
}
