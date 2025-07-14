namespace _80._Remove_Duplicates_from_Sorted_Array_II
{
    internal class Program
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int l = 0; // left pointer (position to place next unique number)

            for (int r = 1; r < nums.Length; r++)
            {
                if (nums[r] != nums[l])
                {
                    l++;
                    nums[l] = nums[r];
                }
            }

            return l + 1; // number of unique elements
        }

        public int RemoveDuplicates1(int[] nums)
        {
            if (nums.Length <= 2) return nums.Length;

            int i = 2; // Position to place next valid element

            for (int j = 2; j < nums.Length; j++)
            {
                // Only add element if it's different from element 2 positions back
                if (nums[j] != nums[i - 2])
                {
                    nums[i] = nums[j];
                    i++;
                }
            }

            return i;
        }
        static void Main(string[] args)
        {
            var program = new Program();
            
            Console.WriteLine("Testing Remove Duplicates from Sorted Array II");
            Console.WriteLine(new string('=', 50));
            
            // Test Case 1: [1,1,1,2,2,3] -> [1,1,2,2,3]
            int[] nums1 = {1, 1, 1, 2, 2, 3};
            int[] original1 = (int[])nums1.Clone();
            int length1 = program.RemoveDuplicates(nums1);
            Console.WriteLine($"Input: [{string.Join(", ", original1)}]");
            Console.WriteLine($"Output: [{string.Join(", ", nums1.Take(length1))}]");
            Console.WriteLine($"Length: {length1}");
            Console.WriteLine();
            
            // Test Case 2: [0,0,1,1,1,1,2,3,3] -> [0,0,1,1,2,3,3]
            int[] nums2 = {0, 0, 1, 1, 1, 1, 2, 3, 3};
            int[] original2 = (int[])nums2.Clone();
            int length2 = program.RemoveDuplicates(nums2);
            Console.WriteLine($"Input: [{string.Join(", ", original2)}]");
            Console.WriteLine($"Output: [{string.Join(", ", nums2.Take(length2))}]");
            Console.WriteLine($"Length: {length2}");
            Console.WriteLine();
            
            // Test Case 3: Single element
            int[] nums3 = {1};
            int[] original3 = (int[])nums3.Clone();
            int length3 = program.RemoveDuplicates(nums3);
            Console.WriteLine($"Input: [{string.Join(", ", original3)}]");
            Console.WriteLine($"Output: [{string.Join(", ", nums3.Take(length3))}]");
            Console.WriteLine($"Length: {length3}");
            Console.WriteLine();
            
            // Test Case 4: All same elements
            int[] nums4 = {2, 2, 2, 2, 2};
            int[] original4 = (int[])nums4.Clone();
            int length4 = program.RemoveDuplicates(nums4);
            Console.WriteLine($"Input: [{string.Join(", ", original4)}]");
            Console.WriteLine($"Output: [{string.Join(", ", nums4.Take(length4))}]");
            Console.WriteLine($"Length: {length4}");
        }
    }
}
