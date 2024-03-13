using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class FindConcatenatedWords
    {
        public static IList<string> FindConcatenated_Words(string[] words)
        {
            HashSet<string> wordSet = new HashSet<string>(words);
            List<string> concatenatedWords = new List<string>();

            foreach (string word in words)
            {
                wordSet.Remove(word); // Exclude the current word from the set for the current iteration
                if (CanFormWord(word, wordSet))
                {
                    concatenatedWords.Add(word);
                }
                wordSet.Add(word); // Add the word back to the set for the next iteration
            }

            return concatenatedWords;
        }

        static bool CanFormWord(string word, HashSet<string> wordSet)
        {
            if (wordSet.Count == 0)
            {
                return false;
            }

            bool[] dp = new bool[word.Length + 1];
            dp[0] = true;

            for (int end = 1; end <= word.Length; end++)
            {
                for (int start = 0; start < end; start++)
                {
                    string currentSubstring = word.Substring(start, end - start);
                    if (dp[start] && wordSet.Contains(currentSubstring))
                    {
                        dp[end] = true;
                        break;
                    }
                }
            }

            return dp[word.Length];
        }
    }
}
