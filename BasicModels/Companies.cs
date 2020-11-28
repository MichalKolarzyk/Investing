using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicModels
{
    public class Companies : IList<ICompany>
    {
        public List<ICompany> ListOfCompanies { get; set; } = new List<ICompany>();
        public Companies() { }
        public Companies(List<ICompany> companies)
        {
            ListOfCompanies = companies;
        }

        public Companies(IEnumerable companies)
        {
            foreach(ICompany company in companies)
            {
                ListOfCompanies.Add(company);
            }
        }

        public int Count => ListOfCompanies.Count;

        public bool IsReadOnly => false;

        public ICompany this[int index] { get => ListOfCompanies[index]; set=> ListOfCompanies[index]=value; }

        public string[] GetIds()
        {
            List<string> ids = new List<string>();
            foreach(Company company in ListOfCompanies)
            {
                ids.Add(company.ID);
            }
            return ids.ToArray();
        }

        public int IndexOf(ICompany item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, ICompany item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public void Add(ICompany item)
        {
            ListOfCompanies.Add(item);
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(ICompany item)
        {
            return ListOfCompanies.Contains(item);
        }

        public void CopyTo(ICompany[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(ICompany item)
        {
            return ListOfCompanies.Remove(item);
        }

        public IEnumerator<ICompany> GetEnumerator()
        {
            return ListOfCompanies.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ListOfCompanies.GetEnumerator();
        }
    }
}
