using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicModels;

namespace UserControls.Repository
{
    public class CompanySqlRepository : ICompanyRepository
    {
        private SqlAccess sqlAccess { get; set; }
        public CompanySqlRepository(string connectionString)
        {
            sqlAccess = new SqlAccess(connectionString);
        }
        public Companies GetCompanies()
        {
            Companies companies = sqlAccess.Get<Company>();
            foreach(ICompany company in companies)
            {
                company.Prices = sqlAccess.Get<Price>(company);
            }
            return companies;
        }

        public ICompany GetCompany(string companyId)
        {
            ICompany company = sqlAccess.Get<Company>(companyId).FirstOrDefault();
            company.Prices = sqlAccess.Get<Price>(company);
            return company;

        }

        public void SetCompany(ICompany company)
        {
            sqlAccess.Insert(company);
        }

        public void RemoveCompany(ICompany company)
        {
            sqlAccess.Remove(company);
        }
    }
}
