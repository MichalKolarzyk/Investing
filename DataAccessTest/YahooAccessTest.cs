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
            SQLAccess sqlAccess = Helper.GetTestSqlAccess();

            Companies companies = new Companies();
            companies.Add(new Company("KOS"));
            companies.Add(new Company("BNTX"));
            companies.Add(new Company("PFE"));
            companies.Add(new Company("ANF"));

            List<Price> prices = YahooAccess.GetPrices(companies);
            sqlAccess.InsertPrices(prices);

            Assert.IsTrue(true);
        }
    }
}
