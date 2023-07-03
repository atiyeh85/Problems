using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class MergeSortedArray
    {
        public static int[] Merge_Sorted_Array(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = 0; i < n; i++)
            {
                nums1[m + i] = nums2[i];
            }
            int p = 0;
            int r = nums1.Count() - 1;
            var res = merge_sort(nums1, p, r);
            return res;
        }

        public static int[] merge_sort(int[] nums1, int p, int r)
        {

            if (p >= r)
            {
                return nums1;
            }
            var q = Math.Abs((p + r) / 2);
            merge_sort(nums1, p, q);
            merge_sort(nums1, q + 1, r);
            int[] B = merge(nums1, p, q, r);
            return B;
        }
        public static int[] merge(int[] nums1, int p, int q, int r)
        {
            var mL = q - p + 1;
            var mR = r - q;
            int[] L = new int[mL];
            int[] R = new int[mR];
            for (int i = 0; i < mL; i++)
            {
                L[i] = nums1[p + i];
            }
            for (int j = 0; j < mR; j++)
            {
                R[j] = nums1[q + j + 1];

            }
            int c = 0;
            int d = 0;
            int k = p;
            while (c < mL && d < mR)
            {

                if (L[c] < R[d])
                {
                    nums1[k] = L[c];
                    c++;
                }
                else
                {
                    nums1[k] = R[d];
                    d++;
                }
                k++;
            }

            while (c < mL)
            {
                nums1[k] = L[c];
                c++;
                k++;
            }
            while (d < mR)
            {
                nums1[k] = R[d];
                d++;
                k++;
            }
            return nums1;
        }
    }
}
