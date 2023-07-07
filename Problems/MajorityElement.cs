using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class MajorityElement
    {
        public static int Majority_Element(int[] nums)
        {
            // My Own Solution #1
            int k = 0;
            int count = 0;
            int current = 0;
            List<int> A = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!A.Contains(nums[i]))
                {
                    A.Add(nums[i]);
                }
                else
                {
                    continue;
                }
                for (int j = i; j < nums.Length; j++)
                {
                    
                    if (nums[j] == nums[i])
                    {
                        current++;
                    }
                }
                if (current>count)
                {
                    count = current;
                    k=nums[i];
                }
                current = 0;

            }
            return k;




            // My Own Solution #2
            //int k = 0;
            //int count = 0;
            //int current = 0;
            //List<int> A = new List<int>();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (!A.Contains(nums[i]))
            //    {
            //        A.Add(nums[i]);
            //    }
            //}
            //for (int i = 0; i < A.Count; i++)
            //{
            //    foreach (var item in nums)
            //    {
            //        if (item == A[i])
            //        {
            //            current++;
            //        }
            //    }


            //    if (current > count)
            //    {

            //        count = current;
            //        k = A[i];
            //    }
            //    current = 0;
            //    if (count > nums.Length / 2) break;
            //}
            //return k;
        }
    }
}
