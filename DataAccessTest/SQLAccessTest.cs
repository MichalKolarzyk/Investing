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

            IPrices prices = sqlAccess.Get<Price>(new Company("KOS"));

            Assert.IsNotNull(prices);
        }

        [TestMethod]
        public void InsertPrices()
        {
            SQLAccess sqlAccess = Helper.GetTestSqlAccess();
            IPrices prices = new Prices();

            prices.Add(new Price() { CompanyId = "ASD", Date = DateTimeOffset.Now, TimeScale = TimeScale.OneMinute, Value = 1.34f });
            prices.Add(new Price() { CompanyId = "ASO", Date = DateTimeOffset.Now, TimeScale = TimeScale.OneMinute, Value = 21.52f });
            prices.Add(new Price() { CompanyId = "ASE", Date = DateTimeOffset.Now, TimeScale = TimeScale.OneMinute, Value = 11.12f });
            prices.Add(new Price() { CompanyId = "ASW", Date = DateTimeOffset.Now, TimeScale = TimeScale.OneMinute, Value = 132.42f });
            sqlAccess.Insert(prices);

            IPrices returnedPrices = sqlAccess.Get<Price>(new Company("ASW"));

            sqlAccess.RemovePrices(DateTimeOffset.Now);
            Assert.IsNotNull(returnedPrices);
        }
        [TestMethod]
        public void RemovePrices()
        {
            SQLAccess sqlAccess = Helper.GetTestSqlAccess();

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
            SQLAccess sqlAccess = Helper.GetTestSqlAccess();

            Assert.IsNotNull(sqlAccess.Get("KOS"));
        }

        [TestMethod]
        public void RemoveCompanies()
        {
            SQLAccess sqlAccess = Helper.GetTestSqlAccess();
            Companies companies = new Companies();
            companies.Add(new Company() { ID = "KOS" });

            sqlAccess.Remove(companies);

            Assert.IsTrue(sqlAccess.Get("KOS").Count == 0);
        }

        [TestMethod]
        public void InsertCompanies()
        {
            SQLAccess sqlAccess = Helper.GetTestSqlAccess();
            ICompanies companies = new Companies();
            companies.Add(new Company() { ID = "WAS" });
            companies.Add(new Company() { ID = "KOS", FullName = "TestName" });

            sqlAccess.Insert(companies);
            ICompanies returnedCompanies = sqlAccess.Get("KOS");

            sqlAccess.RemovePrices(DateTimeOffset.Now);

            Assert.IsTrue(returnedCompanies.Count == 1);
        }
        [TestMethod]
        public void InsertCompany_AddTwoSameID()
        {
            SQLAccess sqlAccess = Helper.GetTestSqlAccess();
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
            SQLAccess sqlAccess = Helper.GetTestSqlAccess();
            ICompanies companies = new Companies();

            companies.Add(new Company("WA1"));
            companies.Add(new Company("WA2"));
            companies.Add(new Company("WA3"));
            companies.Add(new Company("WA4"));

            sqlAccess.Insert(companies);
            ICompanies returnedCompanies = sqlAccess.Get();
            Assert.IsTrue(returnedCompanies.Count >= 4);
        }

        [TestMethod]
        public void GetAllCompanies_RemoveAllCompanies()
        {
            SQLAccess sqlAccess = Helper.GetTestSqlAccess();

            ICompanies companies = sqlAccess.Get();
            sqlAccess.Remove(companies);

            ICompanies returnedCompanies = sqlAccess.Get();
            Assert.AreEqual(returnedCompanies.Count, 0);
        }

        [TestMethod]
        public void RemovePrices_ByIDAndDate()
        {
            SQLAccess sqlAccess = Helper.GetTestSqlAccess();

            Company company = new Company("ASD");
            Prices pricesToInsert = new Prices();

            pricesToInsert.Add(new Price(company, 2.19f));
            sqlAccess.Insert(pricesToInsert);

            sqlAccess.RemovePrices(company, DateTimeOffset.Now);

            IPrices prices = sqlAccess.Get<Price>(company);

            Assert.IsTrue(prices.Count == 0);
        }

        [TestMethod]
        public void RemovePrices_ByDate()
        {
            SQLAccess sqlAccess = Helper.GetTestSqlAccess();

            sqlAccess.RemovePrices(DateTimeOffset.Now);

            Assert.IsTrue(true);
        }

    }
}
