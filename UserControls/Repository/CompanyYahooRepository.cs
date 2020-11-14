using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControls.Repository
{
    class CompanyYahooRepository : ICompanyOutSource
    {
        public ICompany GetCompany(string companyId)
        {
            return YahooAccess.GetCompany(companyId).Result;
        }
    }
}
