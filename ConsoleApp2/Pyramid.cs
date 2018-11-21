using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Pyramid
    {
        List<Line> Lines { get; set; }
        int SpaceCount { get; set; }
        public string[] BestPractices(int nFloors)
        {
            var result = new string[nFloors];
            for (int i = 0; i < nFloors; i++)
                result[i] = string.Concat(new string(' ', nFloors - i - 1),
                                          new string('*', i * 2 + 1),
                                          new string(' ', nFloors - i - 1));
            return result;
        }
        public List<string> Calculate(int totalLines)
        {
            SpaceCount = (totalLines + totalLines) - 1; // 3 lines = 5 stars = 5 spaces

            List<Line> lines = new List<Line>();

            for(int i = 1; i<= totalLines; i++)
            {
                Line lineItem = new Line();
                lineItem.NumberOfStars = i + i - 1;
                int remainder;
                int quotient = Math.DivRem(SpaceCount, 2, out remainder);
                lineItem.StartingPosition = (quotient + remainder) - i;
                lines.Add(lineItem);
            }
           return Print(lines, SpaceCount);
        }
        public List<string> Print(List<Line> lines, int spaceCount)
        {
            List<string> printLines = new List<string>();
            foreach(var item in lines)
            {
                var str = string.Empty;
                var i = 1;
                while (i <= item.StartingPosition)
                {
                    Console.Write(" ");
                    str += " ";
                    i += 1;
                } 
                int star = 1;
                while (star <= item.NumberOfStars)
                {
                    Console.Write("*");
                    str += "*";
                    star += 1;
                }
                int leaveGaps = 1;
                while (leaveGaps <= spaceCount - (item.StartingPosition +  item.NumberOfStars))
                {
                    Console.Write(" ");
                    str += " ";
                    leaveGaps += 1;
                }
                Console.WriteLine();
                printLines.Add(str);
            }
            return printLines;
        }
    }
    public class Line
    {
        public int NumberOfStars { get; set; }
        public int StartingPosition { get; set; }
    }
}
