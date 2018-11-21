
namespace ConsoleApp2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public static class ToSmallest
    {
        public static long[] Smallest(long n)
        {
            var nums = n.ToString().ToList().ConvertAll(c => (int)Char.GetNumericValue(c));

            var rtnVars = new long[] { n, 0, 0 };

            for (int i = 0; i < nums.Count; i++)
            {
                for (int j = 0; j < nums.Count; j++)
                {
                    var testDigits = new List<int>(nums);
                    var d = nums[i];
                    testDigits.RemoveAt(i);
                    testDigits.Insert(j, d);
                    var testSmallest = testDigits.DigitListToLong();
                    if (testSmallest < rtnVars[0])
                    {
                        rtnVars[0] = testSmallest;
                        rtnVars[1] = i;
                        rtnVars[2] = j;
                    }
                }
            }

            return rtnVars;
        }

        public static long DigitListToLong(this List<int> digitList)
        {
            long rtnVal = 0;

            for (int i = digitList.Count; i > 0; i--)
            {
                rtnVal += digitList[digitList.Count - i] * (long)Math.Pow(10, i - 1);
            }
            return rtnVal;
        }

    }
}