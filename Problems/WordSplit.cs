using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class WordSplit
    {
       

        public static List<string> word_split(string[] wordlist)

        {
           
            string FirstWord = wordlist[0].ToLower();
           string SecondWord= wordlist[1];
            List<string> Final_List = new List<string>();
            string[] str = SecondWord.Split(',');
            for (int k   = 0; k < str.Count(); k++)
            {
                if (FirstWord.Contains( str[k].Trim().ToLower()))
                {
                    Final_List.Add(str[k]);
                }
            }
            return Final_List;
        }
    }
}
