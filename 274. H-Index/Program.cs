namespace _274._H_Index
{
    internal class Program
    {
        public int HIndex(int[] citations)
        {
            Array.Sort(citations);
            int r = citations.Length;
            int m = r - 0 / 2;
            int l = 0;
            int max = 0;
            while (r > l)
            {
                m = (r + l) / 2;
                int c = HIndexHelper(citations, m);
                if (c >= m)
                {
                    max = m;
                    l = m + 1;
                }
                else
                {
                    r = m - 1;
                }


            }
            return max;
        }
        public int HIndexHelper(int[] citations, int i)
        {
            int c = 0;
            for (int j = 0; j < citations.Length; j++)
            {
                if (citations[j] >= i)
                {
                    c++;
                }
            }
            return c;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            // Test case 1: [3,0,6,1,5] -> expected h-index = 3
            int[] citations1 = { 3, 0, 6, 1, 5 };
            int result1 = program.HIndex(citations1);
            Console.WriteLine($"Test 1: citations = [{string.Join(", ", citations1)}], h-index = {result1}");

            // Test case 2: [1,3,1] -> expected h-index = 1
            int[] citations2 = { 1, 3, 1 };
            int result2 = program.HIndex(citations2);
            Console.WriteLine($"Test 2: citations = [{string.Join(", ", citations2)}], h-index = {result2}");

            // Test case 3: [100] -> expected h-index = 1
            int[] citations3 = { 100 };
            int result3 = program.HIndex(citations3);
            Console.WriteLine($"Test 3: citations = [{string.Join(", ", citations3)}], h-index = {result3}");

            // Test case 4: [0,0] -> expected h-index = 0
            int[] citations4 = { 0, 0 };
            int result4 = program.HIndex(citations4);
            Console.WriteLine($"Test 4: citations = [{string.Join(", ", citations4)}], h-index = {result4}");
        }
    }
}
