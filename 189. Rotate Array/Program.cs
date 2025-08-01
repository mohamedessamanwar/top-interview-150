namespace _189._Rotate_Array
{
    internal class Program
    {
        public void Rotate(int[] nums, int k)
        {
            int n = nums.Length;
            if (n == 1 || n == 0) return;
            int effectiveK = k % n;

            var temp = new int[n];
            int j = 0;
            if (effectiveK == 0) return;

            // Copy elements from (n - effectiveK) to end
            for (int i = n - effectiveK; i < n; i++)
            {
                temp[j++] = nums[i];
            }
            // Copy elements from start to (n - effectiveK - 1)
            for (int i = 0; i < n - effectiveK; i++)
            {
                temp[j++] = nums[i];
            }
            Array.Copy(temp, nums, n);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
