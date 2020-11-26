using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using BasicModels;

namespace Repositories.Interfaces 
{
    public interface ICompanyOutSource
    {
        ICompany GetCompany(string companyId);
    }
}
