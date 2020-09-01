using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoUser;
using System.Threading;
using System.Collections.Generic;

namespace AutoUserTest
{
    [TestClass]
    public class ScheduleTest
    {
        [TestMethod]
        public void Schedule()
        {
            List<int> listA = new List<int>();
            List<int> listB = new List<int>();
            List<int> listC = new List<int>();

            Schedule schedule = new Schedule();
            schedule.Add(new SingleTask(() => listA.Add(1), 100));
            schedule.Add(new SingleTask(() => listB.Add(2), 100));
            schedule.Add(new SingleTask(() => listC.Add(3), 100));

            schedule.Start();

            Thread.Sleep(1000);
            schedule.Stop();

            Assert.IsTrue(listA.Count >= 9 && listB.Count >= 9 && listC.Count >= 9);
        }
    }
}
