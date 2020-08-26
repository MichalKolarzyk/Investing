using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Company
    {
        public List<Price> Prices { get; set; }
        public string ID { get; set; }
        public string FullName { get; set; }

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
    }
}
