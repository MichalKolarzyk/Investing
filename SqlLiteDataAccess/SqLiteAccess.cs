using Dapper;
using BasicModels;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SqLiteDataAccess
{
    public class SqLiteAccess
    {
        public string ConnectionString { get; set; }

        public SqLiteAccess(string databasePath)
        {
            ConnectionString = $"Data Source={databasePath};Version=3;";
        }
        public SqLiteAccess()
        {
            //ConnectionString = @"Data Source=.\Database.db;Version=3;";
            ConnectionString = @"Data Source=C:\Users\micha\Source\Repos\Investing2\SqlLiteDataAccess\Database.db;Version=3;";
        }

        public Companies GetCompanies()
        {
            using (IDbConnection connection = new SQLiteConnection(ConnectionString))
            {
                IEnumerable<ICompany> listofCompanies = connection.Query<Company>($"SELECT * FROM Companies ORDER BY ID DESC").ToList();
                Companies companies = new Companies(listofCompanies);
                return companies;
            }
        }

        public Prices GetPrices(ICompany company)
        {
            using (IDbConnection connection = new SQLiteConnection(ConnectionString))
            {
                IEnumerable<IPrice> listOfPrices = connection.Query<Price>("SELECT * FROM Prices WHERE CompanyID = @ID ORDER BY Date ASC", company).ToList();
                Prices prices = new Prices(listOfPrices);
                return prices;
            }
        }

        public void AddCompany(ICompany company)
        {
            using (IDbConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Execute($"INSERT INTO Companies (ID, FullName) VALUES (@ID, @FullName)", company);
            }
        }

        public void RemoveCompany(ICompany company)
        {
            using (IDbConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Execute($"DELETE FROM Companies WHERE ID = @ID", company);
            }
        }

        public void AddPrices(Prices prices)
        {
            using (IDbConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Execute($"INSERT INTO  Prices(CompanyId, Value, TimeScale) VALUES(@CompanyId, @Value, @TimeScale)", prices);
            }
        }

        public void RemovePrice(ICompany company)
        {
            using (IDbConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Execute($"DELETE FROM Prices WHERE CompanyId = @ID", company);
            }
        }
    }
}
