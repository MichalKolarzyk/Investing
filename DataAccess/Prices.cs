using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Prices : IPrices
    {
        List<IPrice> listOfPrices { get; set; } = new List<IPrice>();

        public bool IsReadOnly => throw new NotImplementedException();

        public int Count => listOfPrices.Count;

        public IPrice this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Prices() { }
        public Prices(List<IPrice> prices)
        {
            listOfPrices = prices;
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
    }
}
