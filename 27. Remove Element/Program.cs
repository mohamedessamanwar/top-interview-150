namespace _27._Remove_Element
{
    internal class Program
    {
        public int RemoveElement(int[] nums, int val)
        {
            int left = 0;
            int right = nums.Length - 1;
            
            while (left <= right)
            {
                if (nums[left] == val)
                {
                    // Swap with element from right that's not equal to val
                    nums[left] = nums[right];
                    right--; // Shrink the valid range
                }
                else
                {
                    left++; // Move to next element
                }
            }
            
            return left; // left now points to the new length
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            int[] nums = { 2 };
            int val = 3;
            
            Console.WriteLine($"Original array: [{string.Join(", ", nums)}]");
            Console.WriteLine($"Value to remove: {val}");
            
            int newLength = program.RemoveElement(nums, val);
            
            Console.WriteLine($"New length: {newLength}");
            Console.WriteLine($"Modified array: [{string.Join(", ", nums.Take(newLength))}]");
        }
    }
}
