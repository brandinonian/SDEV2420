using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GenericMinMax
{
    [TestClass]
    public class MinMaxTests
    {       
        [TestMethod]
        public void TestMinimum()
        {
            TestMinimumHelper<int>(new int[] { 77, 33, 99, 44, 11 }, 11);
            TestMinimumHelper<int>(new int[] { 444, 839, 222, 478, 999}, 222);
            TestMinimumHelper<double>(new double[] { 22.2, 55.5, 77.7, 11.1, 88.8 }, 11.1);
            TestMinimumHelper<double>(new double[] { 41.7, 87.3, 33.8, 12.3, 65.9 }, 12.3);
            TestMinimumHelper<string>(new string[] { "green", "blue", "red", "yellow", "white"}, "blue");
            TestMinimumHelper<string>(new string[] { "charlie", "zulu", "foxtrot", "sierra", "alpha"}, "alpha");
        }
        public void TestMinimumHelper<T>(T[] testArray, T expected) where T : IComparable<T>
        {
            var actual = Program.Minimum(testArray);
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void TestMaximum()
        {
            TestMaximumHelper<int>(new int[] { 77, 33, 99, 44, 11 }, 99);
            TestMaximumHelper<int>(new int[] { 444, 839, 222, 478, 999 }, 999);
            TestMaximumHelper<double>(new double[] { 22.2, 55.5, 77.7, 11.1, 88.8 }, 88.8);
            TestMaximumHelper<double>(new double[] { 41.7, 87.3, 33.8, 12.3, 65.9 }, 87.3);
            TestMaximumHelper<string>(new string[] { "green", "blue", "red", "yellow", "white" }, "yellow");
            TestMaximumHelper<string>(new string[] { "charlie", "zulu", "foxtrot", "sierra", "alpha" }, "zulu");
        }
        public void TestMaximumHelper<T>(T[] testArray, T expected) where T : IComparable<T>
        {
            var actual = Program.Maximum(testArray);
            Assert.AreEqual(expected, actual);
        }
    }
}
