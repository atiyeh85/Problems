using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal  class BestTimeto_BuyandSellStock
    {
        
        public static  int MaxProfit(int[] prices)
        {
            // O(n) solution
            int maxprofit = 0;
            int min = prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i]<min)
                {
                    min = prices[i];
                }
                else if (prices[i]-min>maxprofit)
                {
                    maxprofit = prices[i];
                }

            }
            return maxprofit;


            // My Own Solution
            //int maxProfit = 0;
            //int n = prices.Length;
            //int j = 1;
            //for (int i = 0; i < n - 1; i++)
            //{
            //    j = i + 1;

            //    if (j <= n - 1 && prices[j] < prices[i])
            //    {
            //        continue;
            //    }

            //    while (j <= n - 1 && prices[j] > prices[i])
            //    {
            //        if (prices[j] - prices[i] > maxProfit)
            //        {
            //            maxProfit = prices[j] - prices[i];
            //        }
            //        j++;

            //    }
            //}
            //return maxProfit;
        }
    }
}
