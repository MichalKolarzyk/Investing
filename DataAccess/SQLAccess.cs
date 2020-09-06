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

        public void Insert(ICompanies companies)
        {
            using (IDbConnection connection = GetConnection(connectionString))
            {
                string storedProcedure = $"dbo.Companies_Insert @ID, @FullName";
                connection.Execute(storedProcedure, companies);
            }
        }

        public void Insert(Company company)
        {
            ICompanies companies = new Companies();
            companies.Add(company);
            Insert(companies);
        }

        public ICompanies Get()
        {
            using (IDbConnection connection = GetConnection(connectionString))
            {
                ICompanies companies = new Companies(connection.Query<ICompany>("dbo.Companies_GetAll", "").ToList());
                return companies;
            }
        }
        public ICompanies Get(string companyId)
        {
            using (IDbConnection connection = GetConnection(connectionString))
            {
                string storedProcedure = $"dbo.Companies_Get @ID";
                var storedProcedureArgs = new { ID = companyId };
                ICompanies companies = new Companies(connection.Query<ICompany>(storedProcedure, storedProcedureArgs).ToList());
                return companies;
            }
        }

        public void Remove(ICompanies companies)
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


        public void Insert(IPrices prices)
        {
            using (IDbConnection connection = GetConnection(connectionString))
            {
                string storedProcedure = $"dbo.Prices_Insert @CompanyID, @Value, @Date, @TimeScale";
                connection.Execute(storedProcedure, prices);
            }
        }

        public IPrices Get<T>(ICompany company) where T : IPrice, new()
        {
            using (IDbConnection connection = GetConnection(connectionString))
            {
                string storedProcedure = $"dbo.Prices_GetByCompanyId @ID";
                IEnumerable<IPrice> prices = (IEnumerable<IPrice>)connection.Query<T>(storedProcedure, company);
                IPrices pricesList = PricesBuilder.Create<Prices>()
                    .AddEnumeratorList(prices)
                    .Build();

                return pricesList;
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
