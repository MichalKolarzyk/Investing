using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Companies
    {
        private List<Company> companyList { get; set; } = new List<Company>();
        public Companies() { }
        public Companies(List<Company> companies)
        {
            companyList = companies;
        }

        public void Add(Company company)
        {
            companyList.Add(company);
        }

        public void Remove(Company company)
        {
            companyList.Remove(company);
        }

        public int Count => companyList.Count;

        public string[] GetIds()
        {
            List<string> ids = new List<string>();
            foreach(Company company in companyList)
            {
                ids.Add(company.ID);
            }
            return ids.ToArray();
        }
        public List<Company> GetList()
        {
            return companyList;
        }
    }
}
