using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class matchstring
    {
        public static List<int> matching_Strings(List<string> stringList, List<string> queries)
        {
            var newList = new int[queries.Count];
            var index = 0;
            var frequency = 0;
            foreach (var item in queries)
            {
                for (int i = 0; i < stringList.Count; i++)
                {
                    if (stringList[i] ==item)
                    {
                        frequency++;
                    }
                }
                newList[index] = frequency;
                frequency= 0;
                index++;
            }
            return newList.ToList();
        }
    }
}
