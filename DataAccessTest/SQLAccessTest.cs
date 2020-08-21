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
            SQLAccess sqlAccess = Helper.GetTestSqlAccess();

            List<Price> prices = sqlAccess.GetPrices("KOS");

            Assert.IsNotNull(prices);
        }

        [TestMethod]
        public void InsertPrices()
        {
            SQLAccess sqlAccess = Helper.GetTestSqlAccess();
            List<Price> prices = new List<Price>();

            prices.Add(new Price() { CompanyId = "ASD", Date = DateTimeOffset.Now, TimeScale = TimeScale.OneMinute, Value = 1.34f });
            prices.Add(new Price() { CompanyId = "ASO", Date = DateTimeOffset.Now, TimeScale = TimeScale.OneMinute, Value = 21.52f });
            prices.Add(new Price() { CompanyId = "ASE", Date = DateTimeOffset.Now, TimeScale = TimeScale.OneMinute, Value = 11.12f });
            prices.Add(new Price() { CompanyId = "ASW", Date = DateTimeOffset.Now, TimeScale = TimeScale.OneMinute, Value = 132.42f });

            sqlAccess.InsertPrices(prices);
            Assert.IsNotNull(sqlAccess.GetPrices("ASW"));
        }
        [TestMethod]
        public void RemovePrices()
        {
            SQLAccess sqlAccess = Helper.GetTestSqlAccess();

            List<Price> pricesToInsert = new List<Price>();
            pricesToInsert.Add(new Price() { CompanyId = "KOS", Date = DateTimeOffset.Now, TimeScale = TimeScale.OneMinute, Value = 1.34f });
            pricesToInsert.Add(new Price() { CompanyId = "KOS", Date = DateTimeOffset.Now, TimeScale = TimeScale.OneMinute, Value = 1.34f });
            sqlAccess.InsertPrices(pricesToInsert);

            List<Price> pricesToDelete = new List<Price>();
            pricesToDelete = sqlAccess.GetPrices("KOS");
            sqlAccess.RemovePrices(pricesToDelete);

            Assert.IsTrue(sqlAccess.GetPrices("KOS").Count == 0);
        }
        [TestMethod]
        public void GetCompanies()
        {
            SQLAccess sqlAccess = Helper.GetTestSqlAccess();

            Assert.IsNotNull(sqlAccess.GetCompany("KOS"));
        }

        [TestMethod]
        public void RemoveCompanies()
        {
            SQLAccess sqlAccess = Helper.GetTestSqlAccess();

            sqlAccess.RemoveCompany(new Company() { ID = "KOS" });

            Assert.IsTrue(sqlAccess.GetCompany("KOS").Count == 0);
        }

        [TestMethod]
        public void InsertCompanies()
        {
            SQLAccess sqlAccess = Helper.GetTestSqlAccess();

            sqlAccess.RemoveCompany(new Company() { ID = "KOS" });
            sqlAccess.InsertCompany(new Company() { ID = "KOS", FullName = "TestName" });

            Assert.IsTrue(sqlAccess.GetCompany("KOS").Count == 1);
        }

        

    }
}
