using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicModels;

namespace UserControls.Repository
{
    class CompanyYahooRepository : ICompanyOutSource
    {
        public ICompany GetCompany(string companyId)
        {
            ICompany company = YahooAccess.GetCompany(companyId).Result;
            return company;
        }
    }
}
