namespace _1456._Maximum_Number_of_Vowels_in_a_Substring_of_Given_Length
{
    internal class Program
    {
        public int MaxVowels(string s, int k)
        {
            int maxVowelCount = 0;
            int currentVowelCount = 0;
            string vowels = "aeiouAEIOU";
            var set = new HashSet<char>(vowels);
            int c = 0; 
            for (int i = 0; i < s.Length; i++)
            {
                if (vowels.Contains(s[i]))
                {
                    currentVowelCount++;
                }
                if (i-c+1>k)
                {
                    if (vowels.Contains(s[c]))
                    {
                        currentVowelCount--;
                    }
                      c++;
                }
                maxVowelCount = Math.Max(maxVowelCount, currentVowelCount);
            }

            return maxVowelCount;
        }
            static void Main(string[] args)
            {
                var program = new Program();

                // Test cases with fun examples
                Console.WriteLine("🎵 Testing Maximum Vowels in Substring! 🎵\n");

                // Test case 1: Musical word
                string test1 = "abciiidef";
                int k1 = 3;
                int result1 = program.MaxVowels(test1, k1);
                Console.WriteLine($"🎼 Word: '{test1}', Length: {k1} → Max vowels: {result1}");

                // Test case 2: Programming term
                string test2 = "aeiou";
                int k2 = 2;
                int result2 = program.MaxVowels(test2, k2);
                Console.WriteLine($"🔤 Word: '{test2}', Length: {k2} → Max vowels: {result2}");

                // Test case 3: Fun phrase
                string test3 = "leetcode";
                int k3 = 3;
                int result3 = program.MaxVowels(test3, k3);
                Console.WriteLine($"💻 Word: '{test3}', Length: {k3} → Max vowels: {result3}");

                // Test case 4: Challenging case
                string test4 = "rhythms";
                int k4 = 4;
                int result4 = program.MaxVowels(test4, k4);
                Console.WriteLine($"🥁 Word: '{test4}', Length: {k4} → Max vowels: {result4}");

                Console.WriteLine("\n✨ Testing complete! ✨");
            }
    }
}
