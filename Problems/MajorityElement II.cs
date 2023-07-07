using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class MajorityElement_II
    {
        public static IList<int> Majority_Element(int[] nums)
        {
            List<int> k = new List<int>();
            int count = 0;
            int current = 0;
            double occure = 0.0;
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
                occure = nums.Length / 3;
                if (current> occure)
                {
                  k.Add(  nums[i]);
                }
               
                current = 0;

            }
            return k;

        }
    }
}
