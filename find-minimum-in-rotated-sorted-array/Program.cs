namespace find_minimum_in_rotated_sorted_array
{
    internal class Program
    {

        public int FindMin(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] > nums[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            return nums[left];
        }
        static void Main(string[] args)
        {
            int[] nums = { 3, 4, 5, 1, 2 };
            Program program = new Program();
            int min = program.FindMin(nums);
            Console.WriteLine($"The minimum value in the rotated sorted array is: {min}");
        }
    }
}
