

using Problems;

internal class Program
{
    private static void Main(string[] args)
    {
        //matchingstring
        var Arr1 = new List<string>() { "ab", "abd", "ab","c", "ab" };
        var Arr2 = new List<string>() { "ab","abd","ab" };

        var result = matchstring.matching_Strings(Arr1,Arr2);
        Console.WriteLine(result);
        //RotateLeft
        //var Arr= new List<int>() { 1, 2, 3, 4, 5};
        //var result = RotateLeft.rotate_Left(2,Arr);
        //Console.WriteLine(result);
        //Challange
        //var arrr= new List<List<int>> { 
        //    new List<int> { 1,1, 1, 0, 0, 0, },
        //    new List<int> { 0,1, 0, 0, 0, 0, },
        //    new List<int> { 1,1, 1, 0, 0, 0, },
        //    new List<int> { 0,0, 2, 4, 4, 0, },
        //    new List<int> { 0,0,0 , 2, 0, 0, },
        //    new List<int> { 0,0, 1, 2, 4, 0, }
        //};

        //var res = Challange.hourglassSum(arrr);
        //Merge_Sorted_Array
        //   int[] num1 =new int[] { 8, 10, 14,0,0,0 };
        //   int[] num2 = new int[]{ 2, 11, 15 };
        //var res= MergeSortedArray.Merge_Sorted_Array(num1, num1.Length-num2.Length ,num2,num2.Length);


        //RemoveElement
        //int[] nums = new int[]{3,3};
        //var res = RemoveElement.Remove_Element(nums,3);



        //RemoveDuplicates
        //int[] nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        //var res = RemoveDuplicatesfromSortedArray.RemoveDuplicates(nums);


        //Majority Element
        //int[] nums = new int[] { 2,2,0,0,1,1,0,2,2 };
        //var res = MajorityElement.Majority_Element(nums);


        //Majority ElementII
        //int[] nums = new int[] { 1, 2 };
        //var res = MajorityElement_II.Majority_Element(nums);


        //Candy
        //int[] nums = new int[] { 1, 3, 2, 2, 1 };
        //var res = Candy._Candy(nums);



        // 121. Best Time to Buy and Sell Stock
        //int[] nums = new int[] { 1, 2, 3, 4, 5 };
        //var res = BestTimetoBuyandSellStock_II.MaxProfit(nums);

        //Wordsplit
        //string[] wordlist = new string[] { "hellocat", "book, radio, Hello, student, John,Cat"};
        //var res = WordSplit.word_split(wordlist);
        //var res = Binarygap.binary_gap(529);
        //int[] weights = { -2, -3, 4, -1, -2, 1, 5, -3 };
        //var res = LargestSumOfWeights.Largest_SumOf_Weights(weights);
        //var result=   WordBuilder.Word_Builder();

        //int[] weights = { 1, 3, 6, 4, 1, 2 };
        ////int[] weights = {-1,-3};
        //var res = SmallestInteger.Smallest_Integer(weights);

        //fibonacci
        //int[] array = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        //var res = frog_fibonacci.fibonacci_(array);

        //word ladder
        //string beginWord = "hit";
        //string endWord = "cog";
        //List<string> wordList = new List<string> { "hot", "dot", "dog", "lot", "log", "cog" };

        //int result = WordLadder.LadderLength(beginWord, endWord, wordList);

        //concatinate
        //string input = "abacdec";
        //string[] words = { "cat", "cats", "catsdogcats", "dog", "dogcatsdog", "hippopotamuses", "rat", "ratcatdogcat" };
        //var result =Task1.Task_1(input);


        //string[] s = { "abc", "abb", "cb", "a","bbb" };
        //int k = 2;
        //var result = letterfrequenc.ChooseStrings(s,k);
        //plusMins
        //List<int> arr =new  List<int> { -4, 3, -9, 0, 4, 1};
        //plusMinus.plus_Minus(arr);

        //minMaxSum
        //List<int> arr = new List<int> { 256741038, 623958417, 467905213, 714532089, 938071625 };
        //miniMaxSum.miniMax_Sum(arr);
        //timeconversion
        //var ii= timeConversion.time_Conversion("12:45:54AM");
        //median
        //List<int> a = new List<int> { 1, 2, 3, 4, 3, 2, 1 };
        //var f=   Median._median();
        //lonelyinteger
        //List<int> a = new List<int> { 1, 2, 3, 4, 3, 2, 1 };
        //var ii = lonelyinteger.lonely_integer(a);

        //CountingSort
        //List<int> a = new List<int> { 63,54,17,78,43,70,32,97,16,94,74,18,60,61,35,83,13,56,75,52,70,12,24,37,17,0,16,64,34,81,82,24,69,2,30,61,83,37,97,16,70,53,0,61,12,17,97,67,33,30,49,70,11,40,67,94,84,60,35,58,19,81,16,14,68,46,42,81,75,87,13,84,33,34,14,96,7,59,17,98,79,47,71,75,8,27,73,66,64,12,29,35,80,78,80,6,5,24,49,82};
        //var ii = countingSort.counting_Sort(a);
    }
}