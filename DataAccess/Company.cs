using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Company : ICompany
    {
        public Prices Prices { get; set; } = new Prices();
        public string ID { get; set; }
        public string FullName { get; set; }
        public static bool operator ==(Company c1, Company c2)
        {
            return c1.ID == c2.ID;
        }
        public static bool operator !=(Company c1, Company c2)
        {
            return c1.ID != c2.ID;
        }

        public Company() { }
        public Company(string id)
        {
            ID = id;
        }
        public Company(string id, string fullName)
        {
            ID = id;
            FullName = fullName;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(obj, null))
            {
                return false;
            }

            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
