using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Candy
    {
        public static int _Candy(int[] ratings)
        {

            int k = 0;
            int n = ratings.Length;
            int[] A = new int[n];
            if (n == 1)
            {
                return 1;
            }
            for (int i = 0; i < n; i++)
            {
                A[i] = 1;
            }
            for (int i = 0; i < n-1; i++)
            {
                 if (ratings[i + 1] > ratings[i])
                {
                    A[i + 1] = A[i] + 1;
                }
            }
            for (int j = n-1; j >0; j--)
            {
                if (ratings[j] < ratings[j - 1] && A[j - 1] <= A[j])
                {
                    A[j - 1] = A[j] + 1;
                }
            }
            return A.Sum();
        }
    }
}
