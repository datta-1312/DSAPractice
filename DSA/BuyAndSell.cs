public class BuyAndSell
{
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int firstMinIndex = 0, firstMinValue = int.MaxValue;
        int lastMaxValue = 0;

        for(int i = 0; i < prices.Length; i++)
        {
            if(firstMinValue > prices[i])
            {
                firstMinIndex = i;
                firstMinValue = prices[i];
            }
        }
        firstMinIndex++;
        if(firstMinIndex >= prices.Length)
        {
            return 0;
        }
        for(int i = firstMinIndex; i < prices.Length; i++)
        {
            if(lastMaxValue < prices[i])
            {
                lastMaxValue = prices[i];
            }
        }

        maxProfit = lastMaxValue - firstMinValue;
        return maxProfit;
    }
}