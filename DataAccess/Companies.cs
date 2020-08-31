using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Companies
    {
        public List<Company> List { get; set; } = new List<Company>();
        public Companies() { }
        public Companies(List<Company> companies)
        {
            List = companies;
        }

        public void Add(Company company)
        {
            List.Add(company);
        }

        public void Remove(Company company)
        {
            List.Remove(company);
        }

        public int Count => List.Count;

        public string[] GetIds()
        {
            List<string> ids = new List<string>();
            foreach(Company company in List)
            {
                ids.Add(company.ID);
            }
            return ids.ToArray();
        }
    }
}
