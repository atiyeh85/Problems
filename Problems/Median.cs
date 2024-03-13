using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class Median
    {
        public static int _median()
        {
            List<int> arr = new List<int> { 0, 1, 2, 4, 6, 5, 3 };
            var arrSorted = arr.OrderBy(x => x).ToList();
            var size = arrSorted.Count;
            var mid = arrSorted.Count / 2;
            var result = 0;
            if (arrSorted.Count % 2 == 0)
            {
                result = arrSorted[mid] + arrSorted[mid - 1] / 2;
            }
            else
            {
                result = arrSorted[mid];
            }
            return result;
        }
       
    }
}
