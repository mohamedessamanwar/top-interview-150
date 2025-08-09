namespace _45._Jump_Game_II
{
    internal class Program
    {
        private int _jumpCount = int.MaxValue; // Track the number of jumps made
        public int CanJump(int[] nums)
        {
            Dictionary<int, bool> memo = new Dictionary<int, bool>();
            int count = 0; // Initialize count to track the number of recursive calls
            CanJumpHelper(nums, 0, memo, ref count);
            return _jumpCount; // Return true if we found a valid path
        }


        private bool CanJumpHelper(int[] nums, int index, Dictionary<int, bool> memo, ref int count)
        {
            // Base case: reached or exceeded the last index
            if (index >= nums.Length - 1)
                return true;

            // Check memoization
            if (memo.ContainsKey(index))
                return memo[index];
            int c = count; // Store the current count for debugging purposes
            count++;
            // Try all possible jumps from current position
            for (int jump = 1; jump <= nums[index]; jump++)
            {
                if (CanJumpHelper(nums, index + jump, memo, ref count))
                {
                    memo[index] = true;
                    // Update the jump count if this path is valid
                    _jumpCount = Math.Min(_jumpCount, count + 1);

                }
                count = c; // Reset count to the previous value after the recursive call
            }


            // No valid path found from this position
            memo[index] = false;
            return false;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            // Test case 1: [2,3,1,1,4] - Expected output: 2 jumps (0->1->4 or 0->2->4)
            int[] nums1 = { 2, 3, 1, 1, 4 };
            program._jumpCount = int.MaxValue; // Reset for new test
            var result1 = program.CanJump(nums1);
            Console.WriteLine($"Input: [{string.Join(",", nums1)}]");
            Console.WriteLine($"Can reach last index: {result1}");
            Console.WriteLine($"Minimum jumps: {(program._jumpCount == int.MaxValue ? "No solution" : program._jumpCount.ToString())}");
            Console.WriteLine();

            // Test case 2: [2,3,0,1,4] - Expected output: 2 jumps
            int[] nums2 = { 2, 3, 0, 1, 4 };
            program._jumpCount = int.MaxValue; // Reset for new test
            var result2 = program.CanJump(nums2);
            Console.WriteLine($"Input: [{string.Join(",", nums2)}]");
            Console.WriteLine($"Can reach last index: {result2}");
            Console.WriteLine($"Minimum jumps: {(program._jumpCount == int.MaxValue ? "No solution" : program._jumpCount.ToString())}");
            Console.WriteLine();

        }
    }
}
