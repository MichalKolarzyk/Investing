using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace UserControls.Repository
{
    public interface ICompanyOutSource
    {
        ICompany GetCompany(string companyId);
    }
}
