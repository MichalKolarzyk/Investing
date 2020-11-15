using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using BasicModels;

namespace DataAccess
{
    public class SqlAccess
    {
        private readonly string connectionString;

        public SqlAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Insert(Companies companies)
        {
            using (IDbConnection connection = GetConnection(connectionString))
            {
                string storedProcedure = $"dbo.Companies_Insert @ID, @FullName";
                connection.Execute(storedProcedure, companies);
            }
        }

        public void Insert(ICompany company)
        {
            Companies companies = new Companies();
            companies.Add(company);
            Insert(companies);
        }

        public Companies Get<ICompanyClass>() where ICompanyClass : ICompany, new()
        {
            using (IDbConnection connection = GetConnection(connectionString))
            {
                IEnumerable<ICompany> companies = (IEnumerable<ICompany>)connection.Query<ICompanyClass>("dbo.Companies_GetAll", "");
                Companies companyList = new Companies(companies);
                return companyList;
            }
        }
        public Companies Get<T>(string companyId) where T : ICompany, new()
        {
            using (IDbConnection connection = GetConnection(connectionString))
            {
                string storedProcedure = $"dbo.Companies_Get @ID";
                var storedProcedureArgs = new { ID = companyId };
                IEnumerable<ICompany> companies = (IEnumerable<ICompany>)connection.Query<T>(storedProcedure, storedProcedureArgs);
                Companies companyList = new Companies(companies);
                return companyList;
            }
        }

        public void Remove(Companies companies)
        {
            using (IDbConnection connection = GetConnection(connectionString))
            {
                string storedProcedure = $"dbo.Companies_Remove @ID";
                connection.Execute(storedProcedure, companies);
            }
        }

        public void Remove(ICompany company)
        {
            Companies companies = new Companies();
            companies.Add(company);
            Remove(companies);
        }


        public void Insert(Prices prices)
        {
            using (IDbConnection connection = GetConnection(connectionString))
            {
                string storedProcedure = $"dbo.Prices_Insert @CompanyID, @Value, @Date, @TimeScale";
                connection.Execute(storedProcedure, prices);
            }
        }

        public Prices Get<ICompanyClass>(ICompany company) where ICompanyClass : IPrice, new()
        {
            using(IDbConnection connection = GetConnection(connectionString))
            {
                string storedProcedure = $"dbo.Prices_GetByCompanyId @ID";
                IEnumerable<IPrice> prices = (IEnumerable<IPrice>)connection.Query<ICompanyClass>(storedProcedure, company);
                Prices pricesList = new Prices(prices);
                return pricesList;
            }
        }

        public Prices GetPrices(ICompany company)
        {
            using (IDbConnection connection = GetConnection(connectionString))
            {
                string storedProcedure = $"dbo.Prices_GetByCompanyId @ID";
                return (Prices)connection.Query<Company>(storedProcedure, company);
            }
        }

        public void RemovePrices(ICompany company)
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

        public void RemovePrices(ICompany company, DateTimeOffset dateTimeOffset)
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
