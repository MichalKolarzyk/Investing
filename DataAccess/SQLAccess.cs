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

        public void InsertCompanies(Companies companies)
        {
            using (IDbConnection connection = GetConnection(connectionString))
            {
                string storedProcedure = $"dbo.Companies_Insert @ID, @FullName";
                connection.Execute(storedProcedure, companies.GetList());
            }
        }

        public Companies GetCompanies()
        {
            using (IDbConnection connection = GetConnection(connectionString))
            {
                List<Company> companiesList = connection.Query<Company>("dbo.Companies_GetAll", "").ToList();
                Companies companies = new Companies(companiesList);
                return companies;
            }
        }
        public Companies GetCompanies(string companyId)
        {
            using (IDbConnection connection = GetConnection(connectionString))
            {
                string storedProcedure = $"dbo.Companies_Get @ID";
                var storedProcedureArgs = new { ID = companyId };
                List<Company> companiesList = connection.Query<Company>(storedProcedure, storedProcedureArgs).ToList();
                Companies companies = new Companies(companiesList);
                return companies;
            }
        }

        public void RemoveCompanies(Companies companies)
        {
            using (IDbConnection connection = GetConnection(connectionString))
            {
                string storedProcedure = $"dbo.Companies_Remove @ID";
                connection.Execute(storedProcedure, companies.GetList());
            }
        }

        public void InsertPrices(List<Price> prices)
        {
            using (IDbConnection connection = GetConnection(connectionString))
            {
                string storedProcedure = $"dbo.Prices_Insert @CompanyID, @Value, @Date, @TimeScale";
                connection.Execute(storedProcedure, prices);
            }
        }

        public List<Price> GetPrices(Company company)
        {
            using (IDbConnection connection = GetConnection(connectionString))
            {
                string storedProcedure = $"dbo.Prices_GetByCompanyId @ID";
                List<Price> output = connection.Query<Price>(storedProcedure, company).ToList();
                return output;
            }
        }

        public void RemovePrices(Company company)
        {
            using (IDbConnection connection = GetConnection(connectionString))
            {
                string storedProcedure = $"dbo.Prices_Remove @ID";
                connection.Execute(storedProcedure, company);
            }
        }

        public void RemovePrices(DateTimeOffset dateTimeOffset)
        {
            using (IDbConnection connection = GetConnection(connectionString))
            {
                string storedProcedure = $"dbo.Prices_RemoveByDate @Date";
                var storedProcedureArgs = new { Date = dateTimeOffset };
                connection.Execute(storedProcedure, storedProcedureArgs);
            }
        }

        public void RemovePrices(Company company, DateTimeOffset dateTimeOffset)
        {
            using (IDbConnection connection = GetConnection(connectionString))
            {
                string storedProcedure = $"dbo.Prices_RemoveByIdAndDate @ID, @Date";
                var storedProcedureArgs = new { ID = company.ID, Date = dateTimeOffset };
                connection.Execute(storedProcedure, storedProcedureArgs);
            }
        }

        private IDbConnection GetConnection(string connectionString)
        {
            return new System.Data.SqlClient.SqlConnection(connectionString);
        }
    }
}
