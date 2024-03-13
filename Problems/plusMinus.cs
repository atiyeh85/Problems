using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class plusMinus
    {
        public static void plus_Minus(List<int> arr)
        {
            decimal countZero = 0;
            decimal countPositive = 0;
            decimal countNegative = 0;
            var n = arr.Count;
            for (int i = 0; i < arr.Count; i++)
            {
                
                if (arr[i] < 0) { countNegative++; }
                else if (arr[i] > 0) { countPositive++; }
                else if (arr[i] == 0) { countZero++; }
            }
            var ss = Math.Round((countPositive / n), 6);
            var dd = Math.Round((countNegative / n), 6);
            var gg = Math.Round((countZero / n), 6);



        }
    }
}
