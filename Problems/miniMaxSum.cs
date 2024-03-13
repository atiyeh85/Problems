using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class miniMaxSum
    {
        public static void miniMax_Sum(List<int> arr)
        {
            var sortedArray=arr.OrderBy(x => x).ToList();
            long maxValue = 0;
            long minValue = 0;
            for (int i = 1; i < sortedArray.Count; i++)
            {
                maxValue += (int)sortedArray[i];
            }
            for (int i = 0; i < sortedArray.Count-1; i++)
            {
                minValue += (int)sortedArray[i];
            }
            Console.WriteLine(string.Format("{0} {1}", minValue, maxValue));
            var ss=string.Format("{0} {1}", minValue, maxValue );
        }
    }
}
