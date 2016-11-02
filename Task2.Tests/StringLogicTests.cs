using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using NUnit.Framework;
using static Task2.StringLogic;

namespace Task2.Tests
{
    [TestFixture]
    public class StringLogicTests
    {

        [Test, TestCaseSource(nameof(GetXmlData))]
        public void СoncatenatingStrings_СoncatenateAndSortTwoStringsExcludingRecurringCharacters(string string1,string string2,string expectedResult)
        {
            var result = СoncatenatingStrings(string1, string2);

            Assert.AreEqual(result, expectedResult);
        }

        [TestCase("fff",null)]
        [TestCase("","fff")]
        [TestCase("742n", "fff")]
        public void СoncatenatingStrings_TestForArgumentException(string string1, string string2)
        {
            Assert.That(() => СoncatenatingStrings(string1, string2), Throws.TypeOf<ArgumentException>());
        }

        private static IEnumerable<string[]> GetXmlData()
        {
            var xml = new XmlDocument();
            xml.Load(Directory.GetCurrentDirectory() + @"\Data.xml");
            foreach (XmlNode node in xml.SelectNodes("TestCases"))
            {
                foreach (XmlNode child in node.ChildNodes)
                {
                    string string1 = child.ChildNodes[0].InnerText;
                    string string2 = child.ChildNodes[1].InnerText;
                    string expectedResult = child.ChildNodes[2].InnerText;
                    yield return new[] { string1, string2, expectedResult };
                }
            }

        }
    }
}
