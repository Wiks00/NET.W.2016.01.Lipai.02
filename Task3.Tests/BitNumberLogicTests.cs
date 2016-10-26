using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using static Task3.BitNumberLogic;

namespace Task3.Tests
{
    [TestFixture]
    public class BitNumberLogicTests
    {
        [TestCase(8, 15, 0, 0, ExpectedResult = 9)]
        [TestCase(0, 15, 30, 30, ExpectedResult = 1073741824)]
        [TestCase(0, 15, 0, 30, ExpectedResult = 15)]
        [TestCase(15, -15, 0, 4, ExpectedResult = 31)]
        [TestCase(15, int.MaxValue, 3, 5, ExpectedResult = 63)]
        public int InsertBinaryNumber_InsertsFirstNumberInSecond(int firstNumber, int secondNumber, 
            int firstBit,int lastBit)
        {
            return InsertBinaryNumber(firstNumber, secondNumber, firstBit, lastBit);
        }

        [TestCase(1,1,31,1)]
        [TestCase(2,2,-1,1)]
        public void FindIndex_TestForArgumentOutOfRangeException(int firstNumber, int secondNumber, 
            int firstBit,int lastBit)
        {
            Assert.That(() => InsertBinaryNumber(firstNumber, secondNumber, firstBit, lastBit), Throws.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}
