using LeetCodeLibrary;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTestsLib
{
    [TestFixture]
    public class LCTests
    {
        [Test]
        public void MinPartitionsTest()
        {
            PartitioningIntoMinimumNumberOfDeciBinaryNumbers x = new PartitioningIntoMinimumNumberOfDeciBinaryNumbers();
            var res = x.MinPartitions("27346209830709182346");

            Assert.AreEqual(res, 9);
        }

        [TestCase(new string[] { "G", "P", "GP", "GG" }, new int[] { 2, 4, 3 }, 21)]
        [TestCase(new string[] { "MMM", "PGM", "GP" }, new int[] { 3, 10 }, 37)]
        public void GarbageCollectionTest(string[] garbage, int[] travel, int expected)
        {
            MinimumAmountOfTimeToCollectGarbage x = new MinimumAmountOfTimeToCollectGarbage();
            var result = x.GarbageCollection(garbage, travel);

            Assert.AreEqual(result, expected);
        }

        [TestCase("IDID", new int[] { 0, 4, 1, 3, 2 })]
        [TestCase("III", new int[] { 0, 1, 2, 3 })]
        [TestCase("DDI", new int[] { 3, 2, 0, 1 })]
        public void DIStringMatch(string s, int[] expected)
        {
            DIStringMatch x = new DIStringMatch();
            var result = x.DiStringMatch(s);
            Assert.AreEqual(result, expected);
        }

    }
}
