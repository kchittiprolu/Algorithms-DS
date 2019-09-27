using System;
namespace Algorithms_DS.Arrays
{
    public class MaxProfitSellingStockOnce
    {
    public int MaxProfit(int[] prices) {
       int min = Int32.MaxValue;
       int maxProfit = Int32.MinValue;
        
        for(int i=0; i<prices.Length; i++)
        {
            if(prices[i] - min > maxProfit)
                maxProfit = prices[i] - min;
            if(prices[i] < min)
                min = prices[i];
        }
        return maxProfit;
    }

        public int MaxProfitNegative(int[] prices) {
             int buy = prices[0];
             int maxProfit = Int32.MinValue;
        
        for(int i=1; i<prices.Length; i++)
        {
            if(maxProfit < prices[i] - buy)
                maxProfit = prices[i] - buy;
            if(prices[i] < buy)
              buy = prices[i];
        }
        return maxProfit;
    }

    }
}