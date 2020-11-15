using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicModels
{
    public class Company : ICompany
    {
        public Prices Prices { get; set; } = new Prices();
        public string ID { get; set; }
        public string FullName { get; set; }
        public Company() { }
        public Company(string id)
        {
            ID = id;
        }
    }
}
