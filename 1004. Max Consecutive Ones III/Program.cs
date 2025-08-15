namespace _1004._Max_Consecutive_Ones_III
{
    internal class Program
    {
        public int LongestOnes(int[] nums, int k)
        {
            int left = 0;
            int right = 0;
            int zeroCount = 0;
            int maxLength = 0;

            while (right < nums.Length)
            {
                if (nums[right] == 0)
                {
                    zeroCount++;
                }

                while (zeroCount > k)
                {
                    if (nums[left] == 0)
                    {
                        zeroCount--;
                    }
                    left++;
                }

                maxLength = Math.Max(maxLength, right - left + 1);
                right++;
            }

            return maxLength;
        }
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 0, 0, 1, 1, 1, 0, 1 };
            int k = 2;

            Program program = new Program();
            int result = program.LongestOnes(nums, k);
            Console.WriteLine(result);
        }
    }
}
