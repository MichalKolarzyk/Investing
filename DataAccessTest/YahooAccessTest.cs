using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccess;
using System.Threading.Tasks;

namespace DataAccessTest
{
    [TestClass]
    public class YahooAccessTest
    {
        [TestMethod]
        public void GetPrices()
        {
            SqlAccess sqlAccess = Helper.GetTestSqlAccess();

            Companies companies = new Companies
            {
                new Company("KOS"),
                new Company("BNTX"),
                new Company("PFE"),
                new Company("ANF")
            };

            Prices prices = YahooAccess.GetPrices(companies);
            sqlAccess.Insert(prices);
            sqlAccess.RemovePrices(DateTimeOffset.Now);

            Assert.IsTrue(true);
        }
    }
}
