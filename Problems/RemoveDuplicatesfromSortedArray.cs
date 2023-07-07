using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class RemoveDuplicatesfromSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            List<int> k = new List<int>();
            for (int current = 0; current < nums.Length; current++)
            {
                int key = nums[current];
                k.Add(current);
                for (int j = current+1; j < nums.Length; j++)
                {
                    if (key != nums[j])
                    {
                        k.Add(j);
                    }
                }
            }
            return 0;
        }
    }
}
