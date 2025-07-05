namespace _3._Longest_Substring_Without_Repeating_Characters
{
    internal class Program
    {
        public int LengthOfLongestSubstring(string s)
        {
            int count = 0;
            int left = 0;
            var hashMap = new HashSet<char>();
            for (int i = 0; i < s.Length; i++) {
                while (hashMap.Contains(s[i]))
                {
                    hashMap.Remove(s[left]);
                    left++;
                }
                hashMap.Add(s[i]);
                count = Math.Max(count, hashMap.Count);
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
