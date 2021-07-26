using System;
using J26 = Challenge_July_26;
using Utility;

namespace RunProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] given = { 10, 20, 30 };
            int[] fourCase = { 1, 2, 3, 4 };
            //ArrayPermutation.Program s = new ArrayPermutation.Program();
            int[] arr = { 14, 12, 70, 15, 99, 65, 21, 90 };
            int x = 97;
            J26.ContiguousArray CA = new J26.ContiguousArray();
            CA.Solve(arr, x);
            
        }
    }
}
