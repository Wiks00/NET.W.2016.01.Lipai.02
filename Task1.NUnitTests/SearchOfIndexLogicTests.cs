using System;
using System.Collections.Generic;
using System.Diagnostics;
using NUnit.Framework;
using static Task1.SearchOfIndexLogic;

namespace Task1.NUnitTests
{
    [TestFixture]
    public class SearchOfIndexLogicTests
    {

        [TestCase(new[] {1, 2, 8, 1, 1, 1 },ExpectedResult = 3 )]
        [TestCase(new[] {6, 4, 2, 3, 1 }, ExpectedResult = 2)]
        [TestCase(new[] {int.MaxValue - 1, 1, 0, int.MaxValue }, ExpectedResult = 3)]
        [TestCase(new[] {12, 3, 7, 3, 1 }, ExpectedResult = null)]
        public int? FindIndex_SearchIndexWhereSumOfBothSideAreEqual(int[] array)
        {
            return FindIndex(array);
        }

        [TestCase(new[] {1 ,2 })]
        [TestCase(null)]
        public void FindIndex_TestForArgumentException(int[] array)
        {
            Assert.That(() => FindIndex(array), Throws.TypeOf<ArgumentException>());
        }

    }
}
