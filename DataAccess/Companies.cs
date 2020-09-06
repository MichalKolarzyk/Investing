using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Companies : ICompanies
    {
        public List<ICompany> ListOfCompanies { get; set; } = new List<ICompany>();
        public Companies() { }
        public Companies(List<ICompany> companies)
        {
            ListOfCompanies = companies;
        }

        public int Count => ListOfCompanies.Count;

        public bool IsReadOnly => false;

        public ICompany this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
