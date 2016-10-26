using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class SearchOfIndexLogic
    {

        /// <summary>
        /// Сreates an array of length on the entered parameters
        /// </summary>
        /// <param name="length">Length of created array</param>
        /// <returns>int array</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static int[] CreateArray(int length)
        {
            if(0 > length || length > 1000)
                throw new ArgumentOutOfRangeException(length.ToString());

            Random rdm = new Random();

            int[] mass = new int[length];

            for (var i = 0; i < length; i++)
            {
                mass[i] = rdm.Next(int.MinValue, int.MaxValue);
            }

            Array.Sort(mass);

            return mass;
        }

        /// <summary>
        /// Search for index where sum of both part equals
        /// </summary>
        /// <param name="array">array where will be search</param>
        /// <returns>int index if it exsist or null</returns>
        /// <exception cref="ArgumentException"></exception>
        public static int? FindIndex(int[] array)
        {
            if(array == null || array.Length < 3)
                throw new ArgumentException();

            for (int index = 1; index < array.Length - 1; index++)
            {
                int right = array.Skip(index + 1).Aggregate((current, next) => current + next);
                int left = array.Reverse().Skip(array.Length - index).Aggregate((current, next) => current + next);
                if (left == right)
                    return index + 1;
            }

            return null; 
        }

    }
}
