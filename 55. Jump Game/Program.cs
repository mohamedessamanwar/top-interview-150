namespace _55._Jump_Game
{
    internal class Program
    {
        public bool CanJump(int[] nums)
        {
            Dictionary<int, bool> memo = new Dictionary<int, bool>();
            return CanJumpHelper(nums, 0, memo);
        }


        private bool CanJumpHelper(int[] nums, int index, Dictionary<int, bool> memo)
        {
            // Base case: reached or exceeded the last index
            if (index >= nums.Length - 1)
                return true;

            // Check memoization
            if (memo.ContainsKey(index))
                return memo[index];

            // Try all possible jumps from current position
            for (int jump = 1; jump <= nums[index]; jump++)
            {
                if (CanJumpHelper(nums, index + jump, memo))
                {
                    memo[index] = true;
                    return true;
                }
            }

            // No valid path found from this position
            memo[index] = false;
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
