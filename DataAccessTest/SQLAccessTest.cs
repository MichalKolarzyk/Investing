using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccess;

namespace DataAccessTest
{
    [TestClass]
    public class SQLAccessTest
    {
        [TestMethod]
        public void GetPrices()
        {
            SQLAccess sqlAccess = new SQLAccess(Helper.GetConnectionString());
            List<Price> prices = sqlAccess.GetPrices("KOS");

            Assert.IsNotNull(prices);
        }

        [TestMethod]
        public void InsertPrices()
        {
            SQLAccess sqlAccess = new SQLAccess(Helper.GetConnectionString());
            List<Price> prices = new List<Price>();
            prices.Add(new Price() { CompanyId = "ASD", Date = DateTimeOffset.Now, TimeScale = TimeScale.OneMinute, Value = 1.34f });
            prices.Add(new Price() { CompanyId = "ASO", Date = DateTimeOffset.Now, TimeScale = TimeScale.OneMinute, Value = 21.52f });
            prices.Add(new Price() { CompanyId = "ASE", Date = DateTimeOffset.Now, TimeScale = TimeScale.OneMinute, Value = 11.12f });
            prices.Add(new Price() { CompanyId = "ASW", Date = DateTimeOffset.Now, TimeScale = TimeScale.OneMinute, Value = 132.42f });

            sqlAccess.InsertPrices(prices);
            Assert.IsNotNull(sqlAccess.GetPrices("ASW"));
        }
    }
}
