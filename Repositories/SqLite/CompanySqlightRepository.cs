using BasicModels;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.SqLite.Api;

namespace Repositories.SqLite
{
    public class CompanySqlightRepository : ICompanyRepository
    {
        private SqLiteAccess _sqlightAccess { get; set; }
        public CompanySqlightRepository(string databasePath)
        {
            _sqlightAccess = new SqLiteAccess(databasePath);
        }

        public Companies GetCompanies()
        {
            Companies companies = _sqlightAccess.GetCompanies();
            foreach (ICompany company in companies)
            {
                company.Prices = _sqlightAccess.GetPrices(company);
            }
            return companies;
        }

        public void RemoveCompany(ICompany company)
        {
            _sqlightAccess.RemoveCompany(company);
            _sqlightAccess.RemovePrice(company);
        }

        public void InsertCompany(ICompany company)
        {
            _sqlightAccess.AddCompany(company);
        }
    }
}
