namespace _209._Minimum_Size_Subarray_Sum
{
    internal class Program
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            int sum = 0;
            int l = 0;
            int min = int.MaxValue;
            for (int r = 0; r < nums.Length; r++)
            {
                sum += nums[r];
                while (sum >= target)
                {
                    min = Math.Min(min, r - l + 1);
                    sum -= nums[l];
                    l++;
                }
              //  min = Math.Min(min, r-l+1);
            }
            if(min == int.MaxValue)return 0;
            return min;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
