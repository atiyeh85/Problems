﻿

using Problems;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] num1 =new int[] { 8, 10, 14,0,0,0 };
        int[] num2 = new int[]{ 2, 11, 15 };
     var res= MergeSortedArray.Merge_Sorted_Array(num1, num1.Length-num2.Length ,num2,num2.Length);
    }
}