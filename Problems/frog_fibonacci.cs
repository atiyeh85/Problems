using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class frog_fibonacci
    {
        public static int fibonacci_(int[] A)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < A.Length; i++)
            {

                if (A[i] == 1)
                {

                    list.Add(i);
                }
            }
            if (list.Count!=0)
            {
                return fibonacci_cal(list.Min());
            }
            else 
            {
                return -1;
            }

            
        }
        static int fibonacci_cal(int n)
        {
            if (n <= 1) return 1;
            else if (n >= 2)
            {

                return fibonacci_cal(n - 1) + fibonacci_cal(n - 2);
            }
            return n;
        }
    }
}
