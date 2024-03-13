using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class SmallestInteger
    {
        public static int Smallest_Integer(int[] A) {

                  

            var positiveinteger = A.Where(item => item > 0).Distinct().OrderBy(item => item);
            int CurrentSmallest = 1;

            foreach (var item in positiveinteger)
            {
                if (item == CurrentSmallest)
                {
                    CurrentSmallest+=1;
                }
                else
                {
                    break;
                }
            }

            return CurrentSmallest;
        }
    }


         
}
