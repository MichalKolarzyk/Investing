using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoUser;
using System.Collections.Generic;

namespace AutoUserTest
{
    [TestClass]
    public class TimerTest
    {
        private List<int> ints = new List<int>();
        
        private void addToInts()
        {
            ints.Add(1);
        }

        [TestMethod]
        public void TestMethod1()
        {
            SingleTask singleTask = new SingleTask(addToInts, 100);
            ints.Clear();
            singleTask.Start();

            Thread.Sleep(1000);

            singleTask.Stop();

            Assert.IsTrue(ints.Count == 9);
        }
    }
}
