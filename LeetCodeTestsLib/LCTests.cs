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



        [Test]
        public void MaxWidthOfVerticalArea()
        {
            WidestVerticalAreaBetweenTwoPointsContainingNoPoints x = new WidestVerticalAreaBetweenTwoPointsContainingNoPoints();
            var set1 = x.MaxWidthOfVerticalArea(new int[][] { new int[] { 8, 7 }, new int[] { 9, 9 }, new int[] { 7, 4 }, new int[] { 9, 7 } });
            Assert.AreEqual(set1, 1);
            var set2 = x.MaxWidthOfVerticalArea(new int[][] { new int[] { 3, 1 }, new int[] { 9, 0 }, new int[] { 1, 0 }, new int[] { 1, 4 }, new int[] { 5, 3 }, new int[] { 8, 8 } });
            Assert.AreEqual(set2, 3);
        }

        [TestCase(9, false)]
        [TestCase(4, false)]
        public void isStrictlyPalindromic(int testCase, bool expected)
        {
            StrictlyPalindromicNumber x = new StrictlyPalindromicNumber();
            var result = x.isStrictlyPalindromic(testCase);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new string[] { "7868190130M7522", "5303914400F9211", "9273338290F4010" }, 2)]
        [TestCase(new string[] { "1313579440F2036", "2921522980M5644" }, 0)]
        public void CountSeniors(string[] details, int expected)
        {
            NumberOfSeniorCitizens x = new NumberOfSeniorCitizens();
            var result = x.CountSeniors(details);
            Assert.AreEqual(result, expected);
        }

        [TestCase(new string[] { "d", "b", "c", "b", "c", "a" }, 2, "a")]
        [TestCase(new string[] { "aaa", "aa", "a" }, 1, "aaa")]
        [TestCase(new string[] { "a", "b", "a" }, 3, "")]
        public void KthDistinctStringInAnArray(string[] arr, int k, string expected)
        {
            KthDistinctStringInAnArray x = new KthDistinctStringInAnArray();
            var result = x.KthDistinct(arr, k);

            Assert.AreEqual(result, expected);

        }


        [TestCase(new string[] { "alic3", "bob", "3", "4", "00000" }, 5)]
        [TestCase(new string[] { "1", "01", "001", "0001" }, 1)]
        public void MaximumValue(string[] strs, int expected)
        {
            MaximumValueOfAStringInAnArray x = new MaximumValueOfAStringInAnArray();
            var result = x.MaximumValue(strs);
            Assert.AreEqual(result, expected);

        }

        [TestCase("egcfe", "efcfe")]
        [TestCase("abcd", "abba")]
        [TestCase("seven", "neven")]
        public void MakeSmallestPalindrome(string s, string expected)
        {
            LexicographicallySmallestPalindrome x = new LexicographicallySmallestPalindrome();
            var result = x.MakeSmallestPalindrome(s);
            Assert.AreEqual(result, expected);

        }

        [TestCase(new string[] { "cd", "ac", "dc", "ca", "zz" }, 2)]
        [TestCase(new string[] { "ab", "ba", "cc" }, 1)]
        [TestCase(new string[] { "aa", "ab" }, 0)]
        [TestCase(new string[] { "wk", "xf", "ot", "je", "hd", "kw", "fx", "to", "ej" }, 4)]
        public void MaximumNumberOfStringPairs(string[] words, int expected)
        {
            FindMaximumNumberOfStringPairs x = new FindMaximumNumberOfStringPairs();
            var result = x.MaximumNumberOfStringPairs(words);
            Assert.AreEqual(result, expected);

        }

        [TestCase(new int[] { 3, 1, 2, 1 }, 5, new int[] { 2, 1, 2, 1 })]
        [TestCase(new int[] { 4, 1, 2, 2 }, 4, new int[] { 3, 1, 2, 0 })]
        [TestCase(new int[] { 7, 5, 5, 8, 3 }, 8, new int[] {6,5,0,7,5})]
        public void ProcessQueries(int[] queries, int m, int[] expected )
        {
            QueriesOnAPermutationWithKey x = new QueriesOnAPermutationWithKey();
            var result = x.ProcessQueries(queries, m);
            Assert.AreEqual(result, expected);

        }

        [TestCase(3, new int[] { 0, 1 }, "RRDDLU", new int[] { 1, 5, 4, 3, 1, 0 })]
        [TestCase(2, new int[] { 1, 1 }, "LURD", new int[] { 4, 1, 0, 0 })]
        [TestCase(1, new int[] { 0, 0 }, "LRUD", new int[] { 0, 0, 0, 0 })]
        public void ExecuteInstructions(int n, int[] startPos, string s, int[] expected )
        {
            ExecutionOfAllSuffixInstructionsStayingInAGrid x = new ExecutionOfAllSuffixInstructionsStayingInAGrid();
            var result = x.ExecuteInstructions(n, startPos, s);
            Assert.AreEqual(result, expected);

        }

    }
}
