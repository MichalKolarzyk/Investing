using Repositories.Sql.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicModels;
using Repositories.Interfaces;

namespace Repositories.Sql
{
    public class CompanySqlRepository : ICompanyRepository
    {
        private SqlAccess _sqlAccess { get; set; }
        public CompanySqlRepository(string connectionString)
        {
            _sqlAccess = new SqlAccess(connectionString);
        }
        public Companies GetCompanies()
        {
            Companies companies = _sqlAccess.Get<Company>();
            foreach(ICompany company in companies)
            {
                company.Prices = _sqlAccess.Get<Price>(company);
            }
            return companies;
        }
        public void InsertCompany(ICompany company)
        {
            _sqlAccess.Insert(company);
        }

        public void RemoveCompany(ICompany company)
        {
            _sqlAccess.Remove(company);
        }
    }
}
