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
            SqlAccess sqlAccess = Helper.GetTestSqlAccess();

            Prices prices = sqlAccess.Get<Price>(new Company("KOS"));

            Assert.IsNotNull(prices);
        }

        [TestMethod]
        public void InsertPrices()
        {
            SqlAccess sqlAccess = Helper.GetTestSqlAccess();
            Prices prices = new Prices();

            prices.Add(new Price() { CompanyId = "ASD", Date = DateTimeOffset.Now, TimeScale = TimeScale.OneMinute, Value = 1.34f });
            prices.Add(new Price() { CompanyId = "ASO", Date = DateTimeOffset.Now, TimeScale = TimeScale.OneMinute, Value = 21.52f });
            prices.Add(new Price() { CompanyId = "ASE", Date = DateTimeOffset.Now, TimeScale = TimeScale.OneMinute, Value = 11.12f });
            prices.Add(new Price() { CompanyId = "ASW", Date = DateTimeOffset.Now, TimeScale = TimeScale.OneMinute, Value = 132.42f });
            sqlAccess.Insert(prices);

            Prices returnedPrices = sqlAccess.Get<Price>(new Company("ASW"));

            sqlAccess.RemovePrices(DateTimeOffset.Now);
            Assert.IsNotNull(returnedPrices);
        }
        [TestMethod]
        public void RemovePrices()
        {
            SqlAccess sqlAccess = Helper.GetTestSqlAccess();

            Prices pricesToInsert = new Prices();
            pricesToInsert.Add(new Price() { CompanyId = "KOS", Date = DateTimeOffset.Now, TimeScale = TimeScale.OneMinute, Value = 1.34f });
            pricesToInsert.Add(new Price() { CompanyId = "KOS", Date = DateTimeOffset.Now, TimeScale = TimeScale.OneMinute, Value = 1.34f });
            sqlAccess.Insert(pricesToInsert);

            Company company = new Company("KOS");
            sqlAccess.RemovePrices(company);

            Assert.IsTrue(sqlAccess.Get<Price>(company).Count == 0);
        }
        [TestMethod]
        public void GetCompanies()
        {
            SqlAccess sqlAccess = Helper.GetTestSqlAccess();

            Assert.IsNotNull(sqlAccess.Get<Company>("KOS"));
        }

        [TestMethod]
        public void RemoveCompanies()
        {
            SqlAccess sqlAccess = Helper.GetTestSqlAccess();
            Companies companies = new Companies();
            companies.Add(new Company() { ID = "KOS" });

            sqlAccess.Remove(companies);

            Assert.IsTrue(sqlAccess.Get<Company>("KOS").Count == 0);
        }

        [TestMethod]
        public void InsertCompanies()
        {
            SqlAccess sqlAccess = Helper.GetTestSqlAccess();
            Companies companies = new Companies();
            companies.Add(new Company() { ID = "WAS" });
            companies.Add(new Company() { ID = "KOS", FullName = "TestName" });

            sqlAccess.Insert(companies);
            Companies returnedCompanies = sqlAccess.Get<Company>("KOS");

            sqlAccess.RemovePrices(DateTimeOffset.Now);

            Assert.IsTrue(returnedCompanies.Count == 1);
        }
        [TestMethod]
        public void InsertCompany_AddTwoSameID()
        {
            SqlAccess sqlAccess = Helper.GetTestSqlAccess();
            Companies companies = new Companies();
            companies.Add(new Company() { ID = "KOS", FullName = "TestName" });
            companies.Add(new Company() { ID = "KOS", FullName = "SECONDNAME" });

            sqlAccess.Insert(companies);
            sqlAccess.RemovePrices(DateTimeOffset.Now);

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetAllCompanies()
        {
            SqlAccess sqlAccess = Helper.GetTestSqlAccess();
            Companies companies = new Companies();

            companies.Add(new Company("WA1"));
            companies.Add(new Company("WA2"));
            companies.Add(new Company("WA3"));
            companies.Add(new Company("WA4"));

            sqlAccess.Insert(companies);
            Companies returnedCompanies = sqlAccess.Get<Company>();
            Assert.IsTrue(returnedCompanies.Count >= 4);
        }

        [TestMethod]
        public void GetAllCompanies_RemoveAllCompanies()
        {
            SqlAccess sqlAccess = Helper.GetTestSqlAccess();

            Companies companies = sqlAccess.Get<Company>();
            sqlAccess.Remove(companies);

            Companies returnedCompanies = sqlAccess.Get<Company>();
            Assert.AreEqual(returnedCompanies.Count, 0);
        }

        [TestMethod]
        public void RemovePrices_ByIDAndDate()
        {
            SqlAccess sqlAccess = Helper.GetTestSqlAccess();

            Company company = new Company("ASD");
            Prices pricesToInsert = new Prices();

            pricesToInsert.Add(new Price(company, 2.19f));
            sqlAccess.Insert(pricesToInsert);

            sqlAccess.RemovePrices(company, DateTimeOffset.Now);

            Prices prices = sqlAccess.Get<Price>(company);

            Assert.IsTrue(prices.Count == 0);
        }

        [TestMethod]
        public void RemovePrices_ByDate()
        {
            SqlAccess sqlAccess = Helper.GetTestSqlAccess();

            sqlAccess.RemovePrices(DateTimeOffset.Now);

            Assert.IsTrue(true);
        }

    }
}
