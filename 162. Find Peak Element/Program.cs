namespace _162._Find_Peak_Element
{
    internal class Program
    {
        public int FindPeakElement(int[] nums)
        {
            int left = 0, right = nums.Length - 1;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] > nums[mid + 1])
                {
                    right = mid; // Move left
                }
                else
                {
                    left = mid + 1; // Move right
                }
            }
            return left; // or right, both are the same at this point

        }
        public int PeakIndexInMountainArray(int[] arr)
        {
            int left = 0, right = arr.Length - 1;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] > arr[mid + 1])
                {
                    right = mid; // Move left
                }
                else
                {
                    left = mid + 1; // Move right
                }
            }
            return left; // or right, both are the same at this point

        }
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 1 };
            Program program = new Program();
            int peak = program.FindPeakElement(nums);
            Console.WriteLine($"Peak element is at index: {peak}");
        }
    }
}
