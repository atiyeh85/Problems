using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class BestTimetoBuyandSellStock_II
    {
        public static int MaxProfit(int[] prices)
        {
            int maxprofit = 0;
            int min1 = prices[0];
            int max1 = 0;
            int max2 = 0;
            int min2 = 0;
            int k = 0;
            for (int i = 1; i < prices.Length-2; i++)
            {
                if (prices[i] < min1)
                {
                    min1 = prices[i];
                }
                else
                {
                    max1 = prices[i] - min1;
                    min2 = prices[i + 1];
                    for (int j = prices[i + 1] + 1; j < prices.Length; j++)
                    {
                        if (prices[j] < min2)
                        {
                            min2 = prices[j];
                        }
                        else
                        {
                            max2 = prices[j] - min2;
                            if (max1 + max2 > maxprofit)
                            {
                                maxprofit = max1 + max2;
                            }
                        }
                    }
                }   
            }
            return maxprofit;
        }
    }
}
