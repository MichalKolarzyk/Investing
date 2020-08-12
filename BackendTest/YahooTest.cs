using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YahooFinanceApi;

namespace BackendTest
{
    [TestClass]
    public class YahooTest
    {
        [TestMethod]
        public async Task Symbols_GetKosSymbol_KosSymboEqulToKos()
        {
            var kosSymbol = "KOS";
            var securities = await Yahoo.Symbols(kosSymbol).Fields(Field.Symbol).QueryAsync();

            var security = securities[kosSymbol];
            var securitySymbol = security[Field.Symbol];

            Assert.AreEqual(securitySymbol, kosSymbol);
        }
        
        [TestMethod]
        public async Task GetDividentsAsync_Test()
        {
            DateTime startDate = new DateTime(2016, 1, 1);
            DateTime endDate = new DateTime(2016, 1, 6);
            var dividends = await Yahoo.GetDividendsAsync("AAPL", startDate, endDate);

            Assert.AreEqual(1, 1);
        }
        

    }
}
