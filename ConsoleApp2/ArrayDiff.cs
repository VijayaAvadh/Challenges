using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    public class ArrayDiff
    {
        public   int[] ArrayDiffa(int[] a, int[] b)
        {
            var sb = new HashSet<int>(b);
            return Array.FindAll(a, x => !sb.Contains(x));
        }

        public   string FirstNonRepeatingLetter(string s)
        {
            var onlyOnce = s.GroupBy(x => x).Select(x => new { Key = x.Key, Count = x.Count() }).Where(x => x.Count == 1).FirstOrDefault()?.Key;

            return onlyOnce.ToString() ?? string.Empty;
        }
        public string test(string inputString)
        {
            string result = "";

            string input = s.ToString().ToLower();
            char c = input.Where((t) => { return input.IndexOf(t) == input.LastIndexOf(t); }).FirstOrDefault();
            int index = input.IndexOf(c);
            if (index >= 0) result = s[index].ToString();

            return result;

        }
    }
}
