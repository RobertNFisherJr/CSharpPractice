using System;
using J26 = Challenge_July_26;
using Utility;
using ArrayPermutation;

namespace RunProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayPermutations();
            ContiguousArrays();
            LinkedListStack();
        }

        /// <summary>
        /// Solves the Array Permutations problem from Week July 19 2021 Revature Problem:  //
        /// Utilizing recursion, ArrayPermutations finds every possible permutation of a given
        /// array, and prints the results.
        /// 
        /// Link: https://github.com/RobertNFisherJr/CSharpPractice/blob/main/POWeeklyCodingChallenge/ArrayPermutation/Program.cs
        /// Complexity: O^(N!)
        /// </summary>
        public static void ArrayPermutations()
        {
            // Solves the Array Permutations problem from Week July 19 2021 Revature Problem
            int[] given = { 10, 20, 30 };
            // to show more robust results, pass this parameter
            int[] fourCase = { 1, 2, 3, 4 };
            ArrayPermutation.Program s = new ArrayPermutation.Program();
            s.Solve(given);
        }

        /// <summary>
        /// Solves the Contiguous Array equal to sum problem from July 26 2021 Revature Problem: // 
        /// Given an array and a value x, ContiguousArrays will find the first occurence where
        /// a subarray's sum is equivelent to the given value x.
        /// 
        /// Link: https://github.com/RobertNFisherJr/CSharpPractice/blob/main/POWeeklyCodingChallenge/Challenge_July_26/ContiguousArray.cs
        /// Complexity: O^(NLogN)
        /// </summary>
        public static void ContiguousArrays()
        {
            // Solves the Contiguous Array equal to sum problem from July 26 2021 Revature Problem
            int[] arr = { 14, 12, 70, 15, 99, 65, 21, 90 };
            int x = 97;
            J26.ContiguousArray CA = new J26.ContiguousArray();
            CA.Solve(arr, x);
        }
        /// <summary>
        /// Solves the Contiguous Array equal to sum problem from July 26 2021 Revature Problem: // 
        /// LinkedListStack, mimics the charactheristic of a Stack while using a LinkedList.
        /// 
        /// Link: https://github.com/RobertNFisherJr/CSharpPractice/blob/main/POWeeklyCodingChallenge/Challenge_July_26/LinkedListStack.cs
        /// </summary>
        public static void LinkedListStack()
        {
            // Creates a stack using LinkedList for the LinkedListStack problem from July 26 Revature Problem
            J26.LinkedListStack stack = new J26.LinkedListStack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            int top = stack.Peek();
            Console.WriteLine("Peek: " + top);
            Console.Write("Current Linked List: ");
            stack.print();

            stack.Pop();
            Console.Write("Linked List After Pop: ");
            stack.print();
        }
    }
}
