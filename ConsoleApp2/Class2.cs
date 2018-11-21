using System;
using System.Collections.Generic;
using System.Text;
 
namespace tenMinutesWalk
{
    using System;
    using Solution;
    using System.Linq;
    class Program
    {
        public static bool IsValidWalk(string[] walk)
        {
            Array.ForEach(walk, x => Console.Write($"{x} "));
            if (walk.Length != 10) return false;
            var culture = new System.Globalization.CultureInfo("en-US");
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = culture;
            string[] input = walk.Select(elm => elm
                .Replace("n", "1")
                .Replace("s", "-1")
                .Replace("w", "0.33")
                .Replace("e", "-0.33")
            ).ToArray();
            return input.Aggregate(0.0, (acc, elm) =>
            {
                // Console.WriteLine($"acc: {acc}, elm: {Convert.ToDouble(elm)}");
                return acc + Double.Parse(elm);
            }) == 0.0;
        }
        static void Main(string[] args)
        {
            SolutionTest tests = new SolutionTest();
            tests.SampleTest();
        }
    }
}

namespace Solution
{
    using tenMinutesWalk;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest()
        {
            // Assert.AreEqual(true, Program.IsValidWalk(new string[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" }), "should return true");
            Assert.AreEqual(false, Program.IsValidWalk(new string[] { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" }), "should return false");
            Assert.AreEqual(false, Program.IsValidWalk(new string[] { "w" }), "should return false");
            Assert.AreEqual(false, Program.IsValidWalk(new string[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" }), "should return false");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        string s1 = "scriptingjav";
        string s2 = "javascript";

        Console.WriteLine(Scramble(s1, s2));
        Console.ReadLine();

    }
    public static bool Scramble(string str1, string str2)
    {
        var grouped = str2
                 .GroupBy(s => s)
                 .Select(g => new { Symbol = g.Key, Count = g.Count() });

        foreach (var key in grouped)
        {
            if (str1.Contains(key.Symbol))
            {
                if (!(key.Count <= str1.Count(w => w == key.Symbol)))
                    return false;
            }
            else
                return false;
        }
        return true;
    }
}