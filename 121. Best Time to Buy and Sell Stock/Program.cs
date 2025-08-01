namespace _121._Best_Time_to_Buy_and_Sell_Stock
{
    internal class Program
    {
        public int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length == 0) return 0;

            int maxProfit = 0;
            int minPrice = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }
                else
                {
                    maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
                }
            }

            return maxProfit;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
