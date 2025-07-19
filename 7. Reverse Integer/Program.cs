namespace _7._Reverse_Integer
{
    internal class Program
    {
        public int Reverse(int x)
        {
            if (x >= int.MaxValue || x <= int.MinValue)
            {
                return 0;
            }

            bool min = false;
            if (x < 0)
            {
                min = true;
                x= Math.Abs(x);
            }
            var y = x.ToString().ToCharArray();
            int l = 0;
            int r = y.Length-1;
            while (l < r) {
               var s = y[l];
                y[l] = y[r];
                y[r] = s;
                l++;
                r--;
            }
            var result = long.Parse(new string(y));
            if (result > int.MaxValue || result < int.MinValue)
            {
                return 0;
            }
            if (min)
            {
                result = -result;
            }
           

            return (int)result; 
        }
            static void Main(string[] args)
            {
                Program program = new Program();

                // Test cases for reverse integer
                int[] testCases = { -2147483648, -123, 120, 0, 1534236469, -2147447412 };

                Console.WriteLine("Testing Reverse Integer:");
                Console.WriteLine("========================");

                foreach (int testCase in testCases)
                {
                    try
                    {
                        int result = program.Reverse(testCase);
                        Console.WriteLine($"Input: {testCase,12} -> Output: {result,12}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Input: {testCase,12} -> Error: {ex.Message}");
                    }
                }
            }
    }
}
