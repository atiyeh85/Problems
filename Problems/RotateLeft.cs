using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class RotateLeft
    {
        public static List<int> rotate_Left(int d, List<int> arr)
        {
            
            var n = arr.Count;
            var newArr= new int[n];
            var newindex = 0;

            for (int j = d; j < n; j++)
                {

                newArr[newindex]= arr[j];
                newindex++;

            }
            for (int i = 0; i < d; i++)
            {
                newArr[newindex] = arr[i];
                newindex++;
            }

            return newArr.ToList();

        }
    }
}
