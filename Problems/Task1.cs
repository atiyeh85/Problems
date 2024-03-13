using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class Task1
    {
        public static int Task_1(string S)
        {

            
            List<string> substrings = SplitString(S);

            return 0;
        }
         static List<string> SplitString(string s)
        {
            List<string> result = new List<string>();

            HashSet<char> uniqueChars = new HashSet<char>();
            int start = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char currentChar = s[i];

                if (uniqueChars.Contains(currentChar))
                {
                    // Found a character that has occurred before, start a new substring
                    result.Add(s.Substring(start, i - start));
                    start = i;
                    uniqueChars.Clear();
                }

                uniqueChars.Add(currentChar);
            }

            // Add the last substring
            result.Add(s.Substring(start));

            return result;
        }
    }
}
