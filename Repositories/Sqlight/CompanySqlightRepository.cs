using BasicModels;
using Repositories.Interfaces;
using SqLiteDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Sqlight
{
    public class CompanySqlightRepository : ICompanyRepository
    {
        SqLiteAccess sqlightAccess;
        public CompanySqlightRepository()
        {
            sqlightAccess = new SqLiteAccess();
        }

        public Companies GetCompanies()
        {
            Companies companies = sqlightAccess.GetCompanies();
            foreach (ICompany company in companies)
            {
                company.Prices = sqlightAccess.GetPrices(company);
            }
            return companies;
        }

        public void RemoveCompany(ICompany company)
        {
            sqlightAccess.RemoveCompany(company);
            sqlightAccess.RemovePrice(company);
        }

        public void InsertCompany(ICompany company)
        {
            sqlightAccess.AddCompany(company);
        }
    }
}
