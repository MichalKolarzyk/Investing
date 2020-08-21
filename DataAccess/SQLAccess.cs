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
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                string storedProcedure = $"dbo.Companies_Insert @ID, @FullName";
                connection.Execute(storedProcedure, company);
            }
        }

        public List<Company> GetCompany(string companyId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                string storedProcedure = $"dbo.Companies_Get @ID";
                var storedProcedureArgs = new { ID = companyId };
                List<Company> output = connection.Query<Company>(storedProcedure, storedProcedureArgs).ToList();
                return output;
            }
        }

        public void RemoveCompany(Company company)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                connection.Execute($"dbo.Comapnies_Remove @CompanyId", company);
            }
        }

        public void InsertPrices(List<Price> prices)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                string storedProcedure = $"dbo.Prices_Insert @CompanyID, @Value, @Date, @TimeScale";
                connection.Execute(storedProcedure, prices);
            }
        }

        public List<Price> GetPrices(string companyId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                string storedProcedure = $"dbo.Prices_GetByCompanyId @CompanyId";
                var storedProcedureArgs = new { CompanyId = companyId};
                List<Price> output = connection.Query<Price>(storedProcedure, storedProcedureArgs).ToList();
                return output;
            }
        }

        public void RemovePrices(List<Price> prices)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                connection.Execute($"dbo.Prices_Remove @CompanyId, @Date", prices);
            }
        }
    }
}
