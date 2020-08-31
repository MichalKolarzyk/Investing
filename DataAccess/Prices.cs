using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Prices
    {
        public List<Price> List { get; set; } = new List<Price>();
        public int Count => List.Count;

        public Prices() { }
        public Prices(List<Price> prices)
        {
            List = prices;
        }

        public void Add(Price price)
        {
            List.Add(price);
        }
    }
}
