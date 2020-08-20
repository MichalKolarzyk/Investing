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
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(sqlConfig.ConnectionString))
            {
                string storedProcedure = $"dbo.Companies_Insert @ID, @FullName, {sqlConfig.CompaniesTable}";
                connection.Execute(storedProcedure, company);
            }
        }

        public List<Company> GetCompany(string companyId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(sqlConfig.ConnectionString))
            {
                string storedProcedure = $"dbo.Companies_Get @ID, {sqlConfig.CompaniesTable}";
                var storedProcedureArgs = new { ID = companyId };
                List<Company> output = connection.Query<Company>(storedProcedure, storedProcedureArgs).ToList();
                return output;
            }
        }

        public void RemoveCompany(Company company)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(sqlConfig.ConnectionString))
            {
                connection.Execute($"dbo.Comapnies_Remove @CompanyId, {sqlConfig.CompaniesTable}", company);
            }
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
