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
                int right = checked (array.Skip(index + 1).Aggregate((current, next) => current + next));
                int left = checked (array.Reverse().Skip(array.Length - index).Aggregate((current, next) => current + next));
                if (left == right)
                    return index + 1;
            }

            return null; 
        }

    }
}
