using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DateClass
{
    [TestClass]
    public class DateTests
    {
        [DataRow(6, 10, 1996, "6/10/1996")]
        [DataRow(99, 99, 9999, "1/1/2001")]
        [DataRow(2, 5, 9999, "2/5/2001")]
        [DataRow(99, 16, 2000, "1/16/2000")]
        [DataRow(2, 29, 2019, "2/1/2019")] // not a leap year
        [DataRow(2, 29, 2020, "2/29/2020")] // leap year
        [DataRow(6, 31, 2009, "6/1/2009")] // 30 day month
        [DataRow(9, 99, 2099, "9/1/2099")]
        [DataRow(8, 4, 18, "8/4/2018")]
        [DataRow(5, 25, 120, "5/25/2001")]
        [DataTestMethod]
        public void TestDateObject(int month, int day, int year, string result)
        {
            Date actual = new Date(month, day, year);
            Assert.AreEqual(result, actual.ToString());
        }
        [DataRow(1, 15, 2010, 5, "1/20/2010")]
        [DataRow(1, 28, 2020, 5, "2/2/2020")]
        [DataRow(6, 28, 2000, 5, "7/3/2000")]
        [DataRow(2, 26, 2020, 5, "3/2/2020")] // leap year
        [DataRow(2, 26, 2021, 5, "3/3/2021")] // non leap year
        [DataRow(12, 28, 2004, 5, "1/2/2005")]
        [DataTestMethod]
        public void TestIncrementDay(int month, int day, int year, int numDays, string result)
        {
            Date actual = new Date(month, day, year);
            for (int i = 0; i < numDays; i++)
            {
                actual.IncrementDay();
            }
            Assert.AreEqual(result, actual.ToString());
        }
    }
}
