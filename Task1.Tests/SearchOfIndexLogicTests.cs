using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Task1.SearchOfIndexLogic;

namespace Task1.Tests
{
    [TestClass]
    public class SearchOfIndexLogicTests
    {
        [TestMethod]
        public void FindIndex_SearchIndexWhereSumOfBothSideAreEqual_Return3()
        {
            int[] array = { int.MaxValue - 1, 1, 0, int.MaxValue };

            int? result = FindIndex(array);

            int? expected = 3;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void FindIndex_SearchIndexWhereSumOfBothSideAreEqual_Return2()
        {
            int[] array = { 6, 4, 2, 3, 1 };

            int? result = FindIndex(array);

            int? expected = 2;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void FindIndex_SearchIndexWhereSumOfBothSideAreEqual_ReturnNull()
        {
            int[] array = { 12, 3, 7, 3, 1 };

            int? result = FindIndex(array);

            int? expected = null;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FindIndex_TestForArgumentException_ReturnArgumentException()
        {
            int[] array = { 1, 2 };

            FindIndex(array);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FindIndex_TestForArgumentExceptionVariation2_ReturnArgumentException()
        {
            int[] array = null;

            FindIndex(array);
        }
    }
}
