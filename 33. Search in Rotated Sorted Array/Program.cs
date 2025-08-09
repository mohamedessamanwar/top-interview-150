namespace _33._Search_in_Rotated_Sorted_Array
{
    internal class Program
    {
        public int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }

                // Determine which side is properly sorted
                if (nums[left] <= nums[mid])
                {
                    // Left side is sorted
                    if (nums[left] <= target && target < nums[mid])
                    {
                        right = mid - 1; // Target is in the left half
                    }
                    else
                    {
                        left = mid + 1; // Target is in the right half
                    }
                }
                else
                {
                    // Right side is sorted
                    if (nums[mid] < target && target <= nums[right])
                    {
                        left = mid + 1; // Target is in the right half
                    }
                    else
                    {
                        right = mid - 1; // Target is in the left half
                    }
                }
            }
            return -1; // Target not found
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
