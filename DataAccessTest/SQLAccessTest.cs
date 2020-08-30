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

            List<Price> prices = sqlAccess.GetPrices(new Company("KOS"));

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

            Assert.IsNotNull(sqlAccess.GetPrices(new Company("ASW")));
        }
        [TestMethod]
        public void RemovePrices()
        {
            SQLAccess sqlAccess = Helper.GetTestSqlAccess();

            List<Price> pricesToInsert = new List<Price>();
            pricesToInsert.Add(new Price() { CompanyId = "KOS", Date = DateTimeOffset.Now, TimeScale = TimeScale.OneMinute, Value = 1.34f });
            pricesToInsert.Add(new Price() { CompanyId = "KOS", Date = DateTimeOffset.Now, TimeScale = TimeScale.OneMinute, Value = 1.34f });
            sqlAccess.InsertPrices(pricesToInsert);

            Company company = new Company("KOS");
            sqlAccess.RemovePrices(company);

            Assert.IsTrue(sqlAccess.GetPrices(company).Count == 0);
        }
        [TestMethod]
        public void GetCompanies()
        {
            SQLAccess sqlAccess = Helper.GetTestSqlAccess();

            Assert.IsNotNull(sqlAccess.GetCompanies("KOS"));
        }

        [TestMethod]
        public void RemoveCompanies()
        {
            SQLAccess sqlAccess = Helper.GetTestSqlAccess();
            Companies companies = new Companies();
            companies.Add(new Company() { ID = "KOS" });

            sqlAccess.RemoveCompanies(companies);

            Assert.IsTrue(sqlAccess.GetCompanies("KOS").Count == 0);
        }

        [TestMethod]
        public void InsertCompanies()
        {
            SQLAccess sqlAccess = Helper.GetTestSqlAccess();
            Companies companies = new Companies();
            companies.Add(new Company() { ID = "WAS" });
            companies.Add(new Company() { ID = "KOS", FullName = "TestName" });

            sqlAccess.InsertCompanies(companies);

            Assert.IsTrue(sqlAccess.GetCompanies("KOS").Count == 1);
        }
        [TestMethod]
        public void InsertCompany_AddTwoSameID()
        {
            SQLAccess sqlAccess = Helper.GetTestSqlAccess();
            Companies companies = new Companies();
            companies.Add(new Company() { ID = "KOS", FullName = "TestName" });
            companies.Add(new Company() { ID = "KOS", FullName = "SECONDNAME" });

            sqlAccess.InsertCompanies(companies);

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetAllCompanies()
        {
            SQLAccess sqlAccess = Helper.GetTestSqlAccess();
            Companies companies = new Companies();

            companies.Add(new Company("WA1"));
            companies.Add(new Company("WA2"));
            companies.Add(new Company("WA3"));
            companies.Add(new Company("WA4"));

            sqlAccess.InsertCompanies(companies);
            Companies returnedCompanies = sqlAccess.GetCompanies();
            Assert.IsTrue(returnedCompanies.Count >= 4);
        }

        [TestMethod]
        public void GetAllCompanies_RemoveAllCompanies()
        {
            SQLAccess sqlAccess = Helper.GetTestSqlAccess();

            Companies companies = sqlAccess.GetCompanies();
            sqlAccess.RemoveCompanies(companies);

            Companies returnedCompanies = sqlAccess.GetCompanies();
            Assert.AreEqual(returnedCompanies.Count, 0);
        }

        [TestMethod]
        public void RemovePrices_ByIDAndDate()
        {
            SQLAccess sqlAccess = Helper.GetTestSqlAccess();

            Company company = new Company("ASD");
            List<Price> pricesToInsert = new List<Price>();

            pricesToInsert.Add(new Price(company, 2.19f));
            sqlAccess.InsertPrices(pricesToInsert);

            sqlAccess.RemovePrices(company, DateTimeOffset.Now);

            List<Price> prices = sqlAccess.GetPrices(company);

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
