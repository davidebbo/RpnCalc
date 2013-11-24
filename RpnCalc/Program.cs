using System;
using System.Collections.Generic;

namespace RpnCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();
            for (; ; )
            {
                try
                {
                    Console.Write("> ");
                    string line = Console.ReadLine();
                    if (line == null) break;

                    foreach (string token in line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        if (token == "+") stack.Push(stack.Pop() + stack.Pop());
                        else if (token == "-") stack.Push(-(stack.Pop() - stack.Pop()));
                        else if (token == "*") stack.Push(stack.Pop() * stack.Pop());
                        else stack.Push(Int32.Parse(token));
                    }

                    Console.WriteLine(stack.Peek() + "\n");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
