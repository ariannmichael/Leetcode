public class Solution
{
 public int MaxProfit(int[] prices)
 {
  int profit = 0;
  int left = 0;
  int right = 0;

  while (right < prices.Length)
  {
   if (prices[left] > prices[right])
   {
    left = right;
   }

   profit = Math.Max(profit, prices[right] - prices[left]);
   right++;
  }

  return profit;
 }
}