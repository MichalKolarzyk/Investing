using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicModels;
using Repositories.Interfaces;

namespace Repositories.Yahoo
{
    public class CompanyYahooRepository : ICompanyOutSource
    {
        public ICompany GetCompany(string companyId)
        {
            ICompany company = YahooAccess.GetCompany(companyId).Result;
            return company;
        }
    }
}
