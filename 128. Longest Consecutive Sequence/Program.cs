namespace _128._Longest_Consecutive_Sequence
{
    internal class Program
    {
        public int LongestConsecutive(int[] nums)
        {
            if (nums.Length == 0) return 0;
    
            var numSet = new HashSet<int>(nums); // O(n) construction with duplicates handled automatically
            int maxLength = 0;
    
            foreach (int num in numSet)
            {
                // Only start counting from the beginning of a sequence
                if (!numSet.Contains(num - 1))
                {
                    int currentNum = num;
                    int currentLength = 1;
            
                    // Count consecutive numbers going forward
                    while (numSet.Contains(currentNum + 1))
                    {
                        currentNum++;
                        currentLength++;
                    }
            
                    maxLength = Math.Max(maxLength, currentLength);
                }
            }
    
            return maxLength;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
