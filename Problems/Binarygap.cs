using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class Binarygap
    {
        public static int binary_gap(int n)
        {
            string binaryRepresentation = Convert.ToString(n, 2);

            // Initialize variables to track the current and maximum zero sequence lengths
            int currentZeroLength = 0;
            int maxZeroLength = 0;

            // Iterate through each character in the binary representation
            foreach (char digit in binaryRepresentation)
            {
                if (digit == '0')
                {
                    // If the current digit is '0', increment the current zero length
                    currentZeroLength++;
                }
                else
                {
                    // If the current digit is '1', update the maximum zero length if needed
                    maxZeroLength = Math.Max(maxZeroLength, currentZeroLength);

                    // Reset the current zero length for the next sequence
                    currentZeroLength = 0;
                }
            }

            // Check for the longest sequence at the end of the binary representation
            maxZeroLength = Math.Max(maxZeroLength, currentZeroLength);

            return maxZeroLength;
            // Implement your solution here
            //List<int> list = new List<int>();
            //List<int> counters = new List<int>();
            //while (N >=2)
            //{
            //    list.Add(N % 2);
            //    N = N / 2;

            //}
            //list.Add(N);

            //for (int i = list.Count - 1; i >= 0; i--)
            //{
            //    int counter = 0;
            //    if (list[i] == 1)
            //    {

            //        for (int j = i - 1; j >= 0; j--)
            //        {

            //            if (list[j]==0)
            //            {
            //                counter = counter + 1;

            //            }
            //            else
            //            {
            //                if (counter>0)
            //                {
            //                    counters.Add(counter);
            //                    break;
            //                }

            //            }

            //        }
            //    }

            //}
            //foreach (var item in counters)
            //{
            //    return item;
            //}
            return 0;
        }
    }
}
