using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class StringLogic
    {
        /// <summary>
        /// Сoncatenate and sorts string, excluding recurring characters
        /// </summary>
        /// <param name="str1">first string</param>
        /// <param name="str2">second string</param>
        /// <returns>Concatenated sorted string</returns>
        /// <exception cref="NullReferenceException"></exception>
        public static string СoncatenatingStrings(string str1, string str2)
        {
            if(ReferenceEquals(str1,null) || ReferenceEquals(str2,null))
                throw new NullReferenceException();

            List<char> firstString = str1.ToCharArray().ToList();
            List<char> secondString = str2.ToCharArray().ToList();

            List<char> resString = firstString.Union(secondString).ToList();

            resString.Sort();

            var result = new StringBuilder();
            char prev = ' ';

            foreach (var letter in resString)
            {
                if(prev == letter) continue;
                result.Append(letter);
                prev = letter;
            }

            return result.ToString();
        }
    }
}
