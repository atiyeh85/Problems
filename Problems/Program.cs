

using Problems;

internal class Program
{
    private static void Main(string[] args)
    {
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
        int[] nums = new int[] { 1, 2 };
        var res = MajorityElement_II.Majority_Element(nums);
    }
}