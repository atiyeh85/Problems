using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Problems
{

    internal class Fibonacci
    {

        public static int fibonacci_(int[] array)
        {
            int result = fibonacci_cal(4);
            return result;
        }
        static int fibonacci_cal(int n)
        {
            if (n == 1) return 1;
            else if (n == 0) return 0;
            else if (n >= 2)
            {

                return fibonacci_cal(n - 1) + fibonacci_cal(n - 2);
            }
            return n;
        }
    }
}
