using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class PricesBuilder
    {
        IPrices prices;
        PricesBuilder(IPrices prices) 
        {
            this.prices = prices;
        }
        public static PricesBuilder Create<T>() where T: IPrices, new()
        {
            return new PricesBuilder(new T());
        }

        public PricesBuilder AddEnumeratorList(IEnumerable<IPrice> prices)
        {
            foreach(IPrice price in prices)
            {
                this.prices.Add(price);
            }
            return this;
        }

        public IPrices Build()
        {
            return prices;
        }

    }
}
