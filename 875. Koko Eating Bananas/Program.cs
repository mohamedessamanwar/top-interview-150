namespace _875._Koko_Eating_Bananas
{
    internal class Program
    {
        public int MinEatingSpeed(int[] piles, int h)
        {
            int left = 1, right = 0;
            int result = 0;
            foreach (int pile in piles)
            {
                right = Math.Max(right, pile);
            }
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                long hoursNeeded = 0;
                foreach (int pile in piles)
                {
                    hoursNeeded += (pile + mid - 1) / mid; // Ceiling division: equivalent to Math.Ceiling(pile / (double)mid)
                }
                if (hoursNeeded <= h)
                {
                    result = mid; // Valid speed found, try to find a smaller one
                    right = mid - 1; // Search for smaller speed
                }
                else
                {
                    left = mid + 1; // Speed too slow, increase speed
                }
            }
            return result; // The minimum speed that allows Koko to eat all bananas in h hours

        }
        static void Main(string[] args)
        {
            Program program = new Program();

            //// Test case 1: Basic example
            int[] piles1 = { 3, 6, 7, 11 };
            int h1 = 8;
            Console.WriteLine($"Test 1 - Piles: [{string.Join(", ", piles1)}], Hours: {h1}");
            Console.WriteLine($"Result: {program.MinEatingSpeed(piles1, h1)} bananas/hour\n");

            // Test case 2: Tight constraint
            int[] piles2 = { 30, 11, 23, 4, 20 };
            int h2 = 5;
            Console.WriteLine($"Test 2 - Piles: [{string.Join(", ", piles2)}], Hours: {h2}");
            Console.WriteLine($"Result: {program.MinEatingSpeed(piles2, h2)} bananas/hour\n");

            // Test case 3: Plenty of time
            int[] piles3 = { 30, 11, 23, 4, 20 };
            int h3 = 6;
            Console.WriteLine($"Test 3 - Piles: [{string.Join(", ", piles3)}], Hours: {h3}");
            Console.WriteLine($"Result: {program.MinEatingSpeed(piles3, h3)} bananas/hour\n");

            // Test case 4: Single pile
            int[] piles4 = { 312884470 };
            int h4 = 968709470;
            Console.WriteLine($"Test 4 - Single large pile: {piles4[0]}, Hours: {h4}");
            Console.WriteLine($"Result: {program.MinEatingSpeed(piles4, h4)} bananas/hour");

            Console.WriteLine("\n🍌 Koko is happy! All tests completed! 🐵");
        }
    }
}
