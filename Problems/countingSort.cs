using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class countingSort
    {
        public static List<int> counting_Sort(List<int> arr)
        {

            var result = new int[100];
            var size = arr.Count;
            for (int i = 0; i < size; i++)
            {
                result[arr[i]]++;

            }
            
            return result.ToList();


        }
    }
}
