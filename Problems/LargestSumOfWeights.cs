using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class LargestSumOfWeights
    {
        public static int Largest_SumOf_Weights(int[] Weights)

        {

            int Best_Sum = 0;
            int Current_Sum = 0;
            Current_Sum = Best_Sum = Weights[0];
            for (int i=0;i<= Weights.Length-1; i++)
            {

                Current_Sum = Math.Max(Weights[i], Weights[i] + Current_Sum);
                Best_Sum = Math.Max(Current_Sum, Best_Sum);
            }
            return Best_Sum;
        }
    }
}
