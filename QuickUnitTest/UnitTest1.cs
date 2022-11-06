using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace QuickUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetCurrentDate()
        {
            Assert.AreEqual(DateTime.Now.Date, QuickDate.Calender.GetCurrentDate());
        }
    }
}
