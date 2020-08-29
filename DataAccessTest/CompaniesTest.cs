using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccess;

namespace DataAccessTest
{
    [TestClass]
    public class CompaniesTest
    {
        [TestMethod]
        public void Add()
        {
            Companies companies = new Companies();
            companies.Add(new Company("KOS"));
            companies.Add(new Company("AWF"));
            companies.Add(new Company("AWW"));

            Assert.AreEqual(companies.Count, 3);
        }
        [TestMethod]
        public void ConvertIdsToArray()
        {
            Companies companies = new Companies();
            companies.Add(new Company("KOS"));
            companies.Add(new Company("AWF"));
            companies.Add(new Company("AWW"));

            string[] ids = {"KOS", "AWF", "AWW" };
            CollectionAssert.AreEqual(ids, companies.GetIds());
        }
    }
}
