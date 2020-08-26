using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Companies
    {
        public List<Company> CompanyList { get; set; } = new List<Company>();
        public Companies() { }
        public Companies(List<Company> companies)
        {
            CompanyList = companies;
        }

        public void Add(Company company)
        {
            CompanyList.Add(company);
        }

        public void Remove(Company company)
        {
            CompanyList.Remove(company);
        }

        public int Count => CompanyList.Count;

        public string[] ConvertIdsToArray()
        {
            List<string> ids = new List<string>();
            foreach(Company company in CompanyList)
            {
                ids.Add(company.ID);
            }
            return ids.ToArray();
        }

    }
}
