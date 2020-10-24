using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Prices : IList<IPrice>
    {
        List<IPrice> listOfPrices { get; set; } = new List<IPrice>();
        public bool IsReadOnly => throw new NotImplementedException();

        public int Count => listOfPrices.Count;

        public IPrice this[int index] { get=>listOfPrices[index]; set => listOfPrices[index] = value; }

        public Prices() { }
        public Prices(List<IPrice> prices)
        {
            listOfPrices = prices;
        }
        public Prices(IEnumerable prices)
        {
            foreach(IPrice price in prices)
            {
                listOfPrices.Add(price);
            }
        }

        public void Add(IPrice price)
        {
            listOfPrices.Add(price);
        }

        public int IndexOf(IPrice item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, IPrice item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(IPrice item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(IPrice[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(IPrice item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<IPrice> GetEnumerator()
        {
            return listOfPrices.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return listOfPrices.GetEnumerator();
        }

        public List<float> GetPricesValues()
        {
            List<float> pricesValues = new List<float>();
            foreach(IPrice price in listOfPrices)
            {
                pricesValues.Add(price.Value);
            }
            return pricesValues;
        }
    }
}
