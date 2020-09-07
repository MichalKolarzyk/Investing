using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CompaniesBuilder
    {
        ICompanies companies;
        CompaniesBuilder(ICompanies companies)
        {
            this.companies = companies;
        }
        public static CompaniesBuilder Create<T>() where T : ICompanies, new()
        {
            return new CompaniesBuilder(new T());
        }

        public CompaniesBuilder AddEnumeratorList(IEnumerable<ICompany> companies)
        {
            foreach (ICompany company in companies)
            {
                this.companies.Add(company);
            }
            return this;
        }

        public ICompanies Build()
        {
            return companies;
        }

    }
}
