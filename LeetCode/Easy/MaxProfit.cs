using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class MaxProfit
    {
        public int MaxProfitFunc(int[] prices)
        {
            int left = 0;
            int right = 1;
            int maxProfit = 0;
    
            while (right < prices.Length)
            {
                if (prices[left] < prices[right])
                {
                    int profit = prices[right] - prices[left];

                    if (profit >  maxProfit) 
                        maxProfit = profit;
                }
                else 
                    left = right;

                right++;
            }        
            return maxProfit;
        }

        public int MaxProfitFunc0(int[] prices)
        {
            int min = prices[0];
            int max = prices[0];
            int profit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                int price = prices[i];
                if (price < min)
                {
                    if (max - min > profit)
                        profit = max - min;
                    min = price;
                    max = price;
                }
                else if (price > max)
                {
                    max = price;
                }
            }

            if (profit < max - min)
                return max - min;

            return profit;
        }

        public void MaxProfitTest()
        {
            int[] prices = { 7, 1, 5, 3, 6, 4 };
            int result = MaxProfitFunc(prices);
            Console.WriteLine("Expected: 5");
            Console.WriteLine("Output: " + result);

            int[] prices1 = { 7, 2, 5, 3, 9, 1, 6 };
            int result1 = MaxProfitFunc(prices1);
            Console.WriteLine("Expected: 7");
            Console.WriteLine("Output: " + result1);

            int[] prices2 = { 4, 11, 2, 7, 1 };
            int result2 = MaxProfitFunc(prices2);
            Console.WriteLine("Expected: 7");
            Console.WriteLine("Output: " + result2);


        }
    }
}
