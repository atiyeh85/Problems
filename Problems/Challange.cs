using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class  Challange
    {
        public static int hourglassSum(List<List<int>> arr)
        {
            var sum = new List<int>();
            var n = arr.Count;
            for (int i = 0; i < n - 2; i++)
            {

                for (int j = 0; j < n - 2; j++)
                {
                    sum.Add( arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
                        + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2]);

                }
            }
            return sum.Max();
        }
    }

}
