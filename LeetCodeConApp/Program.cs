using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using LeetCodeLibrary;
using NUnit.Framework;

namespace LeetCodeConApp
{
    class Program
    {
        /// <summary>
        /// Main method to invoke solutions from library.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            // 2391. Minimum Amount of Time to Collect Garbage

            MinimumAmountOfTimeToCollectGarbage x = new MinimumAmountOfTimeToCollectGarbage();
            x.GarbageCollection(new string[] { "MMM", "PGM", "GP" }, new int[] { 3, 10 });


            Console.WriteLine();

            // 1689. Partitioning Into Minimum Number Of Deci-Binary Numbers

            //PartitioningIntoMinimumNumberOfDeciBinaryNumbers x = new PartitioningIntoMinimumNumberOfDeciBinaryNumbers();
            //var c = x.MinPartitions("27346209830709182346");

            // 2656. Maximum Sum With Exactly K Elements 

            //MaximumSumWithExactlyKElements x = new MaximumSumWithExactlyKElements();
            //var c = x.MaximizeSum(new int[] { 4, 4, 9, 10, 10, 9, 3, 8, 4, 2, 5, 3, 8, 6, 1, 10, 4, 5, 3, 2, 3, 9, 5, 7, 10, 4, 9, 10, 1, 10, 4 }, 6);

            // 2161. Partition Array According to Given Pivot

            //PartitionArrayAccordingToGivenPivot x = new PartitionArrayAccordingToGivenPivot();
            //var c = x.PivotArray(new int[] { 9, 12, 5, 10, 14, 3, 10 }, 10);

            // 1769. Minimum Number of Operations to Move All Balls to Each Box

            //MinimumNumberOfOperationsToMoveAllBallsToEachBox x = new MinimumNumberOfOperationsToMoveAllBallsToEachBox();
            //var c = x.MinOperations("001011");

            // Find The Original Array of Prefix Xor

            //FindTheOriginalArrayOfPrefixXor x = new FindTheOriginalArrayOfPrefixXor();
            //var c = x.FindArray(new int[] { 5, 2, 0, 3, 1 });

            // 2610. Convert an Array Into a 2D Array With Conditions

            //ConvertAnArrayIntoA2DArrayWithConditions x = new ConvertAnArrayIntoA2DArrayWithConditions();
            //var t = x.FindMatrix(new int[] { 1, 3, 4, 1, 2, 3, 1 });


            // 1374. Generate a String With Characters That Have Odd Counts

            //GenerateAStringWithCharactersThatHaveOddCounts x = new GenerateAStringWithCharactersThatHaveOddCounts();
            //var t = x.GenerateTheString(4);

            // 1827. Minimum Operations to Make the Array Increasing

            //MinimumOperationsToMakeTheArrayIncreasing x = new MinimumOperationsToMakeTheArrayIncreasing();
            //var c = x.MinOperations(new int[] { 1, 5, 2, 4, 1 });

            // 1252. Cells with Odd Values in a Matrix

            //CellsWithOddValuesInAMatrix x = new CellsWithOddValuesInAMatrix();
            //var c = x.OddCells(1, 1, new int[][] { new int[] { 0, 0 }, new int[] { 0, 0 } });

            // 1732. Find the Highest Altitude

            //FindTheHighestAltitude x = new FindTheHighestAltitude();
            //var c = x.LargestAltitude(new int[] { -5, 1, 5, 0, -7 });



            // 2108. Find First Palindromic String in the Array

            //FindFirstPalindromicStringInTheArray x = new FindFirstPalindromicStringInTheArray();
            //var c = x.FirstPalindrome(new string[] { "abc", "car", "ada", "racecar", "cool" });

            // 2000. Reverse Prefix of Word

            //ReversePrefixOfWord x = new ReversePrefixOfWord();
            //var c = x.ReversePrefix("abcdefd", 'd');

            // 2427. Number of Common Factors

            //NumberOfCommonFactors x = new NumberOfCommonFactors();
            //var c = x.CommonFactors(12, 6);


            // 804. Unique Morse Code Words

            //UniqueMorseCodeWords x = new UniqueMorseCodeWords();
            //var c = x.UniqueMorseRepresentations(new string[] { "gin", "zen", "gig", "msg" });

            // 2651. Calculate Delayed Arrival Time

            //CalculateDelayedArrivalTime x = new CalculateDelayedArrivalTime();
            //var c = x.FindDelayedArrivalTime(24, 5);

            // 2652. Sum Multiples

            //SumMultiples x = new SumMultiples();
            //var c = x.SumOfMultiples(7);

            // 2553. Separate the Digits in an Array

            //SeparateTheDigitsInAnArray x = new SeparateTheDigitsInAnArray();
            //var c = x.SeparateDigits(new int[] { 13, 25, 83, 77 });

            // 2176. Count Equal and Divisible Pairs in an Array

            //CountEqualAndDivisiblePairsInAnArray x = new CountEqualAndDivisiblePairsInAnArray();
            //var c = x.CountPairs(new int[] { 3, 1, 2, 2, 2, 1, 3 }, 2);


            // 1309. Decrypt String from Alphabet to Integer Mapping

            //DecryptStringFromAlphabetToIntegerMapping x = new DecryptStringFromAlphabetToIntegerMapping();
            //var c = x.FreqAlphabets("26#11#418#5");


            // 1464. Maximum Product of Two Elements in an Array

            //MaximumProductOfTwoElementsInAnArray x = new MaximumProductOfTwoElementsInAnArray();
            //var c = x.MaxProduct(new int[] { 3, 4, 5, 2 });

            // 1967. Number of Strings That Appear as Substrings in Word

            //NumberOfStringsThatAppearAsSubstringsInWord x = new NumberOfStringsThatAppearAsSubstringsInWord();
            //var c = x.NumOfStrings(new string[] { "a", "abc", "bc", "d" }, "abc");

            // 2586. Count the Number of Vowel Strings in Range

            //CountTheNumberOfVowelStringsInRange x = new CountTheNumberOfVowelStringsInRange();
            //x.VowelStrings(new string[] { "ta", "ie", "io", "d", "i" }, 2, 3);



            // 2185. Counting Words With a Given Prefix

            //CountingWordsWithAGivenPrefix x = new CountingWordsWithAGivenPrefix();
            //var c = x.PrefixCount( new string[] { "pay","attention","practice","attend"}, "at");


            // 2485. Find the Pivot Integer

            //FindThePivotInteger x = new FindThePivotInteger();
            //var c = x.PivotInteger(49);


            // 1863. Sum of All Subset XOR Totals

            //SumOfAllSubsetXORTotals x = new SumOfAllSubsetXORTotals();
            //var c = x.SubsetXORSum( new int[] { 3,4,5,6,7,8 });


            // 1768. Merge Strings Alternately

            //MergeStringsAlternately x = new MergeStringsAlternately();
            //var c = x.MergeAlternately("ab", "pqrs");



            // 1844. Replace All Digits with Characters

            //ReplaceAllDigitsWithCharacters x = new ReplaceAllDigitsWithCharacters();
            //var c = x.ReplaceDigits("a1b2c3d4e");

            // 1475. Final Prices With a Special Discount in a Shop

            //FinalPricesWithASpecialDiscountInAShop x = new FinalPricesWithASpecialDiscountInAShop();
            //x.FinalPrices(new int[] { 8, 4, 6, 2, 3 });

            // 1021. Remove Outermost Parentheses

            //RemoveOutermostParentheses x = new RemoveOutermostParentheses();
            //x.RemoveOuterParentheses("(()())(())(()(()))");

            // 2500. Delete Greatest Value in Each Row
            //DeleteGreatestValueInEachRow x = new DeleteGreatestValueInEachRow();
            //var c = x.DeleteGreatestValue(new int[][] { new int[] { 1, 2, 4 }, new int[] { 3, 3, 1 } });


            // 832. Flipping an Image


            // 1534. Count Good Triplets
            //CountGoodTriplets x = new CountGoodTriplets();
            //var c = x.CountGoodTripletss(new int[] { 3, 0, 1, 1, 9, 7 }, 7, 2, 3);




            // 1323. Maximum 69 Number
            //Maximum69Number x = new Maximum69Number();
            //x.Maximum69Numberr(9999);

            // 2037. Minimum Number of Moves to Seat Everyone

            //MinimumNumberOfMovesToSeatEveryone x = new MinimumNumberOfMovesToSeatEveryone();
            //var c = x.MinMovesToSeat(new int[] { 3, 1, 5 }, new int[] { 2, 7, 4 });

            // 2220. Minimum Bit Flips to Convert Number
            //MinimumBitFlipsToConvertNumber x = new MinimumBitFlipsToConvertNumber();
            //var c = x.MinBitFlips(3, 4);

            // 1290. Convert Binary Number in a Linked List to Integer
            //ConvertBinaryNumberInALinkedListToInteger x = new ConvertBinaryNumberInALinkedListToInteger();
            //ListNode t = new ListNode() { val = 1};
            //t.next = new ListNode() { val = 0 };
            //t.next = new ListNode() { val = 1 };
            //var c = x.GetDecimalValue(t);


            // 1614. Maximum Nesting Depth of the Parentheses
            //MaximumNestingDepthOfTheParentheses x = new MaximumNestingDepthOfTheParentheses();
            //x.MaxDepth("(1+(2*3)+((8)/4))+1");

            // 1688. Count of Matches in Tournament

            //CountOfMatchesInTournament x = new CountOfMatchesInTournament();
            //var c = x.NumberOfMatches(7);


            // 1859. Sorting the Sentence

            //SortingTheSentence x = new SortingTheSentence();
            //var c = x.SortSentence("sentence4 a3 is2 This1");


            // 2194. Cells in a Range on an Excel Sheet

            //CellsInARangeOnAnExcelSheet x = new CellsInARangeOnAnExcelSheet();
            //var c = x.CellsInRange("U7:X9");

            // 1282. Group the People Given the Group Size They Belong To
            //GroupThePeopleGivenTheGroupSizeTheyBelongTo x = new GroupThePeopleGivenTheGroupSizeTheyBelongTo();
            //var c = x.GroupThePeople(new int[] { 3, 3, 3, 3, 3, 1, 3 });


            // 2545. Sort the Students by Their Kth Score

            //SortTheStudentsByTheirKthScore x = new SortTheStudentsByTheirKthScore();
            //var c = x.SortTheStudents(new int[][] { new int[] { 10, 6, 9, 1 }, new int[] { 7, 5, 11, 2 }, new int[] { 4, 8, 3, 15 } }, 2);




            // 704. Binary Search

            //BinarySearch x = new BinarySearch();
            //var c = x.Search(new int[] { -1, 0, 3, 5, 9, 12 }, 9);



            // 807. Max Increase to Keep City Skyline

            //MaxIncreaseToKeepCitySkyline x = new MaxIncreaseToKeepCitySkyline();
            //var c = x.MaxIncreaseKeepingSkyline(new int[][] { new int[] { 3, 0, 8, 4 }, new int[] { 2, 4, 5, 7 }, new int[] { 9, 2, 6, 3 }, new int[] { 0, 3, 1, 0 } });



            // 1828. Queries on Number of Points Inside a Circle

            //QueriesOnNumberOfPointsInsideACircle x = new QueriesOnNumberOfPointsInsideACircle();
            //var points = new int[][] { new int[] { 1, 3 }, new int[] { 3, 3 }, new int[] { 5, 3 }, new int[] { 2, 2 } };
            //var queries = new int[][] { new int[] { 2, 3, 1 }, new int[] { 4, 3, 1 }, new int[] { 1, 1, 2 } };
            //var c = x.CountPoints(points, queries);



            // 1791. Find Center of Star Graph

            //FindCenterOfStarGraph x = new FindCenterOfStarGraph();
            //var c = x.FindCenter(new int[][] { new int[] { 1, 2 }, new int[] { 5, 1 }, new int[] { 1, 3 }, new int[] { 1, 4 } } ); 

            // 1486. XOR Operation in an Array

            //XOROperationInAnArray x = new XOROperationInAnArray();
            //var c = x.XorOperation(5, 0);

            // 1342. Number of Steps to Reduce a Number to Zero

            //NumberOfStepsToReduceANumberToZero x = new NumberOfStepsToReduceANumberToZero();
            //var c = x.NumberOfSteps(14);


            // 1022. Sum of Root To Leaf Binary Numbers



            //Console.WriteLine();
            // 2236. Root Equals Sum of Children

            // 2520. Count the Digits That Divide a Number

            //CountTheDigitsThatDivideNumber x = new CountTheDigitsThatDivideNumber();
            //var c = x.CountDigits(7);



            // 94. Binary Tree Inorder Traversal

            // 64. Minimum Path Sum

            //MinimumPathSum x = new MinimumPathSum();
            ////var c = x.MinPathSum(new int[][] { new int[] { 1, 3, 1 }, new int[] { 1, 5, 1 }, new int[] { 4, 2, 1 } });
            //var c = x.MinPathSum(new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 } });


            // 938. Range Sum of BST

            //RangeSumOfBST x = new RangeSumOfBST();


            // 1603. Design Parking System

            // 1572. Matrix Diagonal Sum

            //MatrixDiagonalSum x = new MatrixDiagonalSum();
            //int[][] matrix = new int[][] { new int[] { 5 }};
            //x.DiagonalSum(matrix);


            //Console.WriteLine();

            // 1476. Subrectangle Queries

            //SubrectangleQueries obj = new SubrectangleQueries(new int[][] { new int[] { 1, 2, 1 }, new int[] { 4, 3, 4 }, new int[] { 3, 2, 1}, new int[] { 1, 1, 1} });
            //var firstVal = obj.GetValue(0, 2);
            //obj.UpdateSubrectangle(0, 0, 3, 2, 5);
            //obj.UpdateSubrectangle(3, 0, 3, 2, 10);


            //obj.UpdateSubrectangle(row1, col1, row2, col2, newValue);
            //int param_2 = obj.GetValue(row, col);

            // 1281. Subtract the Product and Sum of Digits of an Integer

            //SubtractTheProductandSumOfDigitsOfAnInteger x = new SubtractTheProductandSumOfDigitsOfAnInteger();
            //var c = x.SubtractProductAndSum(234);


            // 2160. Minimum Sum of Four Digit Number After Splitting Digits

            //MinimumSumofFourDigitNumberAfterSplittingDigits x = new MinimumSumofFourDigitNumberAfterSplittingDigits();
            //var c = x.MinimumSum(2932);



            // 2413. Smallest Even Multiple

            //SmallestEvenMultiple x = new SmallestEvenMultiple();
            //var c = x.SmallesttEvenMultiple(5);



            // 2363. Merge Similar Items

            //MergeSimilarItems x = new MergeSimilarItems();
            //int[][] ite1 = new int[][]
            //{
            //     new int[] { 1, 1 }
            //    ,new int[] { 4, 5 }
            //    ,new int[] { 3, 8 }
            //};
            //int[][] ite2 = new int[][]
            //{
            //     new int[] { 2, 1 }
            //    ,new int[] { 3, 2 }
            //    //,new int[] { 1, 3 }
            //};
            //var c = x.MergeSimilarItemss(ite1, ite2);



            // 2341.Maximum Number of Pairs in Array

            //MaximumNumberOfPairsInArray x = new MaximumNumberOfPairsInArray();
            //var c = x.NumberOfPairs(new int[] { 1, 1 });


            // 118. Pascal's Triangle

            //PascalTriangle x = new PascalTriangle();
            //x.Generate(5);


            // 1379. Find a Corresponding Node of a Binary Tree in a Clone of That Tree
            // TODO: add binary tree impl. to test bt Problems

            //object p = BinaryTree(new int?[] { 7, 4, 3, null, null, 6, 19 });
            //FindCorrespondingNodeOfABinaryTreeInACloneOfThatTree x = new FindCorrespondingNodeOfABinaryTreeInACloneOfThatTree();
            //TreeNode treeNode = x.GetTargetCopy((), new TreeNode(), new TreeNode() );


            // 1370. Increasing Decreasing String

            //IncreasingDecreasingString x = new IncreasingDecreasingString();
            //x.SortString("leetcode");

            // 1436. Destination City

            //DestinationCity x = new DestinationCity();
            //x.DestCity(new List<List<string>>() { new List<string>() { "London", "New York" },new List<string>() { "New York", "Lima" }, new List<string>() { "Lima","Sao Paulo"}});



            // 1832. Check if the Sentence Is Pangram

            //CheckIfTheSentenceIsPangram x = new CheckIfTheSentenceIsPangram();
            //var c = x.CheckIfPangram("thequickbrownfoxjumpsoverthelazydog");


            // 2399. Check Distances Between Same Letters

            //CheckDistancesBetweenSameLetters x = new CheckDistancesBetweenSameLetters();
            //x.CheckDistances("abaccb", new int[] { 1, 3, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });


            // 2154. Keep Multiplying Found Values by Two

            //KeepMultiplyingFoundValuesByTwo x = new KeepMultiplyingFoundValuesByTwo();
            //x.FindFinalValue(new int[] { 5, 3, 6, 1, 12 }, 3);

            // 2357. Make Array Zero by Subtracting Equal Amounts
            //MakeArrayZeroBySubtractingEqualAmounts x = new MakeArrayZeroBySubtractingEqualAmounts();
            //x.MinimumOperations(new int[] { 1, 5, 0, 3, 5 });



            // 1748. Sum of Unique Elements

            //SumOfUniqueElements x = new SumOfUniqueElements();
            //x.SumOfUnique(new int[] { 1, 2, 3, 4, 5 });




            // 2103. Rings and Rods

            //RingsAndRods x = new RingsAndRods();
            //var c = x.CountPoints("B0B6G0R6R0R6G9");


            // 557. Reverse Words in a String III

            //ReverseWordsInAString x = new ReverseWordsInAString();
            //var c = x.ReverseWords("Let's take LeetCode contest");


            // 2315. Count Asterisks

            //CountAsterisks x = new CountAsterisks();
            //var c = x.CountAsteriskss("yo|uar|e**|b|e***au|tifu|l");


            // 1684. Count the Number of Consistent Strings

            //CountTheNumberOfConsistentStrings x = new CountTheNumberOfConsistentStrings();

            //var c = x.CountConsistentStrings("ba", new string[] { "ad", "bd", "aaab", "baa", "badab" });



            // 709. To Lower Case

            // 2325. Decode the Message

            //DecodeTheMessage x = new DecodeTheMessage();
            //var c = x.DecodeMessage("the quick brown fox jumps over the lazy dog", "vkbs bs t suepuv");




            // 1221. Split a String in Balanced Strings

            //SplitAStringInBalancedString x = new SplitAStringInBalancedString();
            //var c = x.BalancedStringSplit("RLRRLLRLRL");


            // 1678. Goal Parser Interpretation

            //GoalParser x = new GoalParser();
            //var c = x.Interpret("G()()()()(al)");



            // 771. Jewels and Stones

            //JewelsAndStones x = new JewelsAndStones();
            //var c = x.NumJewelsInStones("aA", "aAAbbbb");



            // 1108. Defanging an IP Address

            //DefangIp x = new DefangIp();
            //var c = x.DefangIPaddr("1.1.1.1");



            // 2187. Minimum Time to Complete Trips

            //MinimumTimeToCompleteTrips x = new MinimumTimeToCompleteTrips();
            //var c = x.MinimumTime(new int[] { 9, 3, 10, 5 }, 2); // exp 5


            // 1588. Sum of All Odd Length Subarrays

            //SumOfAllOddLengthSubarrays x = new SumOfAllOddLengthSubarrays();
            //var c = x.SumOddLengthSubarrays(new int[] { 1, 4, 2, 5, 3 });
            //var c = x.SumOddLengthSubarrays(new int[] { 1 });




            //Console.WriteLine();

            // 2574. Left and Right Sum Differences

            //LeftAndRightSumDifferences x = new LeftAndRightSumDifferences();
            //var c = x.LeftRigthDifference(new int[] { 10, 4, 8, 3 });



            // 2418. Sort the People

            //SortThePeople x = new SortThePeople();
            //var c = x.SortPeople(new string[] { "Mary", "John", "Emma" }, new int[] { 180, 165, 170 });



            // 1913. Maximum Product Difference Between Two Pairs

            //MaximumProductDifference x = new MaximumProductDifference();
            //var c = x.MaxProductDifference(new int[] { 5, 6, 2, 7, 4 });


            // 2006. Count Number of Pairs With Absolute Difference K

            //CountNumberOfPairsWithAbsoluteDifferenceK x = new CountNumberOfPairsWithAbsoluteDifferenceK();
            //var c = x.CountKDifference(new int[] { 3, 2, 1, 5, 4 }, 2);


            // 1816. Truncate Sentence

            //TruncateSentence x = new TruncateSentence();
            //var c = x.TruncateSentencee("Hello how are you Contestant", 4);


            // 1662. Check If Two String Arrays are Equivalent

            //TwoStringArraysAreEquivalent x = new TwoStringArraysAreEquivalent();
            //var c = x.ArrayStringsAreEqual(new string[] { "abc", "d", "defg" }, new string[] { "abcd", "defg" });

            //2373.Largest Local Values in a Matrix

            //LargestLocalValuesInAMatrix x = new LargestLocalValuesInAMatrix();

            //int[][] c = new int[][]
            //{
            //     new int[] {9, 9, 8, 1}
            //    ,new int[] {5, 6, 2, 6}
            //    ,new int[] {8, 2, 6, 4}
            //    ,new int[] {6, 2, 2, 2}
            //};

            //var d = x.LargestLocal(c);

            //x.LargestLocal(c);

            //Console.WriteLine();


            // 2367. Number of Arithmetic Triplets

            //NumberOfArithmeticTriplets x = new NumberOfArithmeticTriplets();
            //var nums = new int[] { 0, 1, 4, 6, 7, 10 };
            //var diff = 3;
            //x.ArithmeticTriplets(nums, diff);


            // 912. Sort an Array

            //SortAnArray x = new SortAnArray();
            //int[] c = new int[] { 5, 2, 3, 1 };
            //x.SortArray(c);

            //Console.WriteLine();
            // 1773. Count Items Matching a Rule

            //CountItemsMatchingARule x = new CountItemsMatchingARule();
            //string[][] y = new string[][] { new string[] { "phone", "silver", "pixel" }
            //,  new string[] { "computer", "silver", "lenovo"}
            //, new string[] {"phone", "gold", "iphone"}};

            //var c = x.CountMatches(y, "color", "silver");

            //Console.WriteLine();

            // 1656. Design an Ordered Stream

            //OrderedStream x = new OrderedStream(5);

            //var a = x.Insert(3, "ccccc");
            //var b = x.Insert(1, "aaaaa");
            //var c = x.Insert(2, "bbbbb");
            //var d = x.Insert(5, "eeeee");
            //var e = x.Insert(4, "ddddd");

            //Console.WriteLine();
            // 1528. Shuffle String

            //ShuffleString x = new ShuffleString();
            //var c = x.RestoreString("codeleet", new int[] { 4,5,6,7,0,2,1,3});
            //Console.WriteLine();

            // 1313. Decompress Run-Length Encoded List

            //DecompressRunLengthEncodedList x = new DecompressRunLengthEncodedList();
            //x.DecompressRLElist(new int[] { 1, 2, 3, 4 });

            // 1389. Create Target Array in the Given Order

            //CreateTargetArrayintheGivenOrder x = new CreateTargetArrayintheGivenOrder();
            //int[] nums = new int[] { 1, 2, 3, 4, 0 };
            //int[] index = new int[] { 0, 1, 2, 3, 0 };

            //var res = x.CreateTargetArray(nums, index);
            //Console.WriteLine();

            // 1720. Decode XORed Array

            //DecodeXORedArray x = new DecodeXORedArray();
            //var c = new int[] { 1, 2, 3 };
            //var z = 1;
            //var t = x.Decode(c, z);

            //Console.WriteLine();
            // 2535. Difference Between Element Sum and Digit Sum of an Array

            //DifferenceBetweenElementSumAndDigitSum x = new DifferenceBetweenElementSumAndDigitSum();
            //var c = new int[] { 1, 2, 3, 4 };
            //var t = x.DifferenceOfSum(c);

            // 1365.How Many Numbers Are Smaller Than the Current Number

            // 1431. Kids With the Greatest Number of Candies

            //KidsWithGreatestNumberCandies x = new KidsWithGreatestNumberCandies();
            //var c = new int[] { 2, 3, 5, 1, 3 };
            //var t = x.KidsWithCandies(c, 3);

            // 2114. Maximum Number of Words Found in Sentences

            //MaximumNumberOfWordsFoundInSentences x = new MaximumNumberOfWordsFoundInSentences();
            //var c = new string[] { "alice and bob love leetcode", "i think so too", "this is great thanks very much" };
            //var res = x.MostWordsFound(c);

            // 1672. Richest Customer Wealth

            //RichestCustomerWealth x = new RichestCustomerWealth();
            //var c = new int[][] { new int[] { 1, 4, 2 }, new int[] { 3, 6, 8 } };
            //x.MaximumWealth(c);

            // 1480. Running Sum of 1d Array


            //RunningSumOf1dArray x = new RunningSumOf1dArray();
            //var c = new int[] { 1, 1, 1, 1, 1 };
            //var t = x.RunningSum(c);
            //Console.WriteLine();
            // 1512. Number of Good Pairs


            //x.NumIdenticalPairs(c);
            //NumberOfGoodPairs x = new NumberOfGoodPairs();
            //var c = new int[] { 1, 2, 3, 1, 1, 3 };

            // 2011. Final Value of Variable After Performing Operations

            //FinalValue x = new FinalValue();
            //var op = new string[] { "X++", "++X", "--X", "X--" };
            //var c = x.FinalValueAfterOperations(op);

            //1470. Shuffle the Array

            //int[] nums = { 1, 1, 2, 2 };
            //int n = 2;

            //ShuffleTheArray x = new ShuffleTheArray();
            //x.Shuffle(nums, n);



            //2469. Convert the Temperature

            //ConvertTheTemperature x = new ConvertTheTemperature();

            //var c = x.ConvertTemperature(36.50);

            //Console.Read();
            //1929. Concatenation of Array

            //int[] nums = { 1, 3, 2, 1 };
            //ConcatenationOfArray x = new ConcatenationOfArray();
            //x.GetConcatenation(nums);


            //1920. Build Array from Permutation
            //int[] nums = { 0, 2, 1, 5, 3, 4 };

            //BuildArrayFromPermutation x = new BuildArrayFromPermutation();
            //var y = x.BuildArray(nums);

            //TODO: unfinished
            //48.Rotate Image
            //Input: matrix = [[1, 2, 3],[4,5,6],[7,8,9]]
            //Output:[[7,4,1],[8,5,2],[9,6,3]]

            //int[][] matrix = new int[][] {  
            //                   new int[] { 1, 2, 3 },
            //                   new int[] { 4, 5, 6 },
            //                   new int[] { 7, 8, 9 },
            //                };


            //RotateImageSolution.Rotate(matrix);


            //Console.WriteLine(16%4);
            //342.Power of Four
            //n = 16
            //n = 5
            //bool answ = PowerOfFourSolution.IsPowerOfFour(4);

            //26.Remove Duplicates from Sorted Array
            //nums = [1, 1, 2]
            //int z = RemoveDuplicatesSolution.RemoveDuplicates(new int[3] { 1, 1, 2 });

            //9.Palindrome Number
            //x = 121;
            //Console.WriteLine(PalindromeNumber.IsPalindrome(10));

            //1.Two Sum
            //nums = [3, 2, 4], target = 6
            //var t = TwoSumSolution.TwoSum(new int[] { 3, 3 }, 6);

        }
    }
}
