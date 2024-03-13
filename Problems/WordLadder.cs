using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class WordLadder
    {
        public static int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            HashSet<string> wordSet = new HashSet<string>(wordList);

            if (!wordSet.Contains(endWord))
                return 0;

            Queue<string> queue = new Queue<string>();
            queue.Enqueue(beginWord);

            int ladderLength = 1;

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;

                for (int i = 0; i < levelSize; i++)
                {
                    string currentWord = queue.Dequeue().ToLower();

                    for (int j = 0; j < currentWord.Length; j++)
                    {
                        char[] wordChars = currentWord.ToCharArray();

                        for (char c = 'a'; c <= 'z'; c++)
                        {
                            wordChars[j] = c;
                            string newWord = new string(wordChars);

                            if (newWord.Equals(endWord))
                                return ladderLength + 1;

                            if (wordSet.Contains(newWord))
                            {
                                queue.Enqueue(newWord);
                                wordSet.Remove(newWord);
                            }
                        }
                    }
                }

                ladderLength++;
            }

            return 0;
        }
    }
}
