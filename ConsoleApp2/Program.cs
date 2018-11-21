using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayDiff test = new ArrayDiff();
           Console.WriteLine( test.FirstNonRepeatingLetter("a"));
            Console.WriteLine(test.FirstNonRepeatingLetter("stress"));
            Console.Write(test.FirstNonRepeatingLetter("moonmen"));
            Console.Write(test.test("!moonmBn"));
        }

    }
}
