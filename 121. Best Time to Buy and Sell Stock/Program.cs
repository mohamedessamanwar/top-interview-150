namespace _121._Best_Time_to_Buy_and_Sell_Stock
{
    internal class Program
    {
        public int MaxProfitv2(int[] prices)
        {
            int sum = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    sum += prices[i] - prices[i - 1];
                }
            }

            return sum;
        }
        public int MaxProfitV1(int[] prices)
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
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int l = 0;
            int r = 0;
            if(nums2.Length == 0) return;
            if (nums1.Length == 0) 
            {
                Array.Copy(nums2, nums1, n);
                return;
            }
            for (int i = 0; i < m ; i++)
            {
                if (nums1[l] < nums2[r])
                {
                    nums1[i] = nums1[l];
                    l++;
                }
                else
                {
                    int temp = nums1[l];
                    nums1[l] = nums2[r];
                    nums2[r] = temp;
                    l++;
                }
            }
            for (int i = m; i < n+m; i++)
            {
                nums1[i] = nums2[r];
                r++;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
