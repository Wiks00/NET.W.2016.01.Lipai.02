﻿using System;
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
            if(string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2) || !char.IsLetter(str1,0) || !char.IsLetter(str2,0))
                throw new ArgumentException();

            var firstString = new SortedSet<char>(str1);
            var secondString = new SortedSet<char>(str2);     
            var resString = new SortedSet<char>(firstString.Union(secondString));

            return string.Join(string.Empty, resString);
        }
    }
}
