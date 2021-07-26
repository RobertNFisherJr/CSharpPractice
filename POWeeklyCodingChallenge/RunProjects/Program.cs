using System;
using J26 = Challenge_July_26;
using Utility;

namespace RunProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solves the Array Permutations problem from Week July 19 2021 Revature Problem
            int[] given = { 10, 20, 30 };
            int[] fourCase = { 1, 2, 3, 4 };
            //ArrayPermutation.Program s = new ArrayPermutation.Program();
            
            // Solves the Contiguous Array equal to sum problem from July 26 2021 Revature Problem
            int[] arr = { 14, 12, 70, 15, 99, 65, 21, 90 };
            int x = 97;
            J26.ContiguousArray CA = new J26.ContiguousArray();
            //CA.Solve(arr, x);

            J26.LinkedListStack stack = new J26.LinkedListStack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            int top = stack.Peek();
            Console.WriteLine(top);
            stack.print();

            stack.Pop();
            stack.print();
        }
    }
}
