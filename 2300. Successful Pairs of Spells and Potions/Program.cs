namespace _2300._Successful_Pairs_of_Spells_and_Potions
{
    internal class Program
    {
        public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
        {
            Array.Sort(potions);
            var result = new int[spells.Length];

            for (int i = 0; i < spells.Length; i++)
            {
                int left = 0;
                int right = potions.Length - 1;
                int firstValidIndex = potions.Length; // Default: no valid potions

                // Binary search for first potion where spell * potion >= success
                while (left <= right)
                {
                    int mid = left + (right - left) / 2;

                    if ((long)potions[mid] * spells[i] >= success)
                    {
                        firstValidIndex = mid;
                        right = mid - 1; // Look for earlier valid potion
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }

                result[i] = potions.Length - firstValidIndex;
            }

            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
