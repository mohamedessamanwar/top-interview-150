namespace _88._Merge_Sorted_Array
{
    internal class Program
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var arr = new int[m + n];
            int i = 0, j = 0, k = 0;
            while (i < m && j < n)
            {
                if (nums1[i] <= nums2[j])
                {
                    arr[k++] = nums1[i++];
                }
                else
                {
                    arr[k++] = nums2[j++];
                }
            }
            while (i < m)
            {
                arr[k++] = nums1[i++];
            }
            while (j < n)
            {
                arr[k++] = nums2[j++];
            }
            Array.Copy(arr, 0, nums1, 0, m + n);
        }
        static void Main(string[] args)
        {
            var program = new Program();

            // Test case 1: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
            int[] nums1 = [1, 2, 3, 0, 0, 0];
            int[] nums2 = [2, 5, 6];
            program.Merge(nums1, 3, nums2, 3);
            Console.WriteLine($"Test 1 - Expected: [1,2,2,3,5,6], Actual: [{string.Join(",", nums1)}]");

            // Test case 2: nums1 = [1], m = 1, nums2 = [], n = 0
            int[] nums1_2 = [1];
            int[] nums2_2 = [];
            program.Merge(nums1_2, 1, nums2_2, 0);
            Console.WriteLine($"Test 2 - Expected: [1], Actual: [{string.Join(",", nums1_2)}]");

            // Test case 3: nums1 = [0], m = 0, nums2 = [1], n = 1
            int[] nums1_3 = [0];
            int[] nums2_3 = [1];
            program.Merge(nums1_3, 0, nums2_3, 1);
            Console.WriteLine($"Test 3 - Expected: [1], Actual: [{string.Join(",", nums1_3)}]");
        }
    }
}
