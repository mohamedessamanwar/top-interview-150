using System;
using System.Collections.Generic;
using System.Linq;

namespace _49._Group_Anagrams
{
    internal class Program
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
                var groups = new Dictionary<string, List<string>>();
            
            for (int i = 0; i < strs.Length; i++)
            {
                var chars = strs[i].ToCharArray();
                Array.Sort(chars);
                var sortedKey = new string(chars);
                
                if (groups.ContainsKey(sortedKey))
                {
                    groups[sortedKey].Add(strs[i]);
                }
                else
                {
                    groups[sortedKey] = new List<string> { strs[i] };
                }
            }
           // var nb = groups.Values.ToList(); 
            return groups.Values.Cast<IList<string>>().ToList();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
