using ConsoleApp2;
using System;
using System.Collections.Generic;

namespace ConsoleApp2
{

    public       class LinkedList
    {
        public string[] Best_Solutions_CreateAndReduce(string[] items)
        {
            Stack<String> stack = new Stack<String>();

            foreach (String direction in items)
            {
                String lastElement = stack.Count > 0 ? stack.Peek().ToString() : null;

                switch (direction)
                {
                    case "NORTH": if ("SOUTH".Equals(lastElement)) { stack.Pop(); } else { stack.Push(direction); } break;
                    case "SOUTH": if ("NORTH".Equals(lastElement)) { stack.Pop(); } else { stack.Push(direction); } break;
                    case "EAST": if ("WEST".Equals(lastElement)) { stack.Pop(); } else { stack.Push(direction); } break;
                    case "WEST": if ("EAST".Equals(lastElement)) { stack.Pop(); } else { stack.Push(direction); } break;
                }
            }
            String[] result = stack.ToArray();
            Array.Reverse(result);

            return result;
        }
        public bool Best_Solutions_FindMatch(string input)
        {
            Stack<char> stack = new Stack<char>();

            if (input.Length <= 0 || input.Length >= 100) return false;

            foreach (char direction in input.ToCharArray())
            {
                char lastElement = stack.Count > 0 ? stack.Peek() : ' ';
                if (direction == '(' || direction == ')')
                {
                    switch (direction)
                    {
                        case '(': if (')'.Equals(lastElement)) { stack.Pop(); } else { stack.Push(direction); } break;
                        case ')': if ('('.Equals(lastElement)) { stack.Pop(); } else { stack.Push(direction); } break;
                    }
                }
            }
            return (stack.Count > 0) ? false : true;
        }
    
}
    
}
