using System.Linq;

namespace _560._Subarray_Sum_Equals_K
{
    internal class Program
    {
        public int SubarraySum(int[] nums, int k)
        {
            var dic = new Dictionary<int, int>();
            dic.Add(0, 1);
            int prefixSum = 0;
            int count = 0; 
            for (int i = 0; i < nums.Length; i++) { 
                prefixSum += nums[i];
                if (dic.ContainsKey(prefixSum-k))
                {
                    count += dic[prefixSum - k]; 
                }
                if (dic.ContainsKey(prefixSum)){
                    dic[prefixSum]++;
                }
                else
                {
                    dic[prefixSum] = 1;
                }
            
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
