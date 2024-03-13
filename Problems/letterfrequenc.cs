using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class letterfrequenc
    {
      public  static int ChooseStrings(string[] s, int k)
        {
            int maxStringCount = 0;
            int Count = 0;

            Dictionary<char, int> letterFrequency = new Dictionary<char, int>();
            foreach (string str in s)
            {
                foreach (char c in str)
                {
                    if (!letterFrequency.ContainsKey(c))
                    {
                        letterFrequency[c] = 1;
                        Count++;
                    }
                    else
                    {
                        letterFrequency[c]++;
                    }
                }
                if (Count>k)
                {
                    break;
                }
                else if(Count==k)
                {
                    maxStringCount++;
                }
                else if(Count<k)
                {
                    maxStringCount++;
                    k = k - Count;
                }
            }

            foreach (char letter in letterFrequency.Keys.OrderByDescending(c => letterFrequency[c]))
            {
                
            }

            return maxStringCount;
        }
    }
}

