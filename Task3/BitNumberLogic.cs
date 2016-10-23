using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public static class BitNumberLogic
    {
        /// <summary>
        /// Method inserts first in second number from prefBit to nextBit. 
        /// </summary>
        /// <param name="firstNumber">the insert number</param>
        /// <param name="secondNumber">the variable number</param>
        /// <param name="firstBit">start number of bit</param>
        /// <param name="lastBit">end number of bit</param>
        /// <returns>the inserted number</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static int InsertBinaryNumber(int firstNumber, int secondNumber, int firstBit, int lastBit)
        {
            if (firstBit < 0 || firstBit > 30 || lastBit > 30 || lastBit < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            int n = (int)Math.Pow(2, lastBit - firstBit + 1) - 1;
            secondNumber &= n;
            secondNumber <<= firstBit;
            return firstNumber | secondNumber;
        }

    }
}
