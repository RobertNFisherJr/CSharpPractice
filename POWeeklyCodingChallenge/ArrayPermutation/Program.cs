using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test Cases, pass to permutationList to convert
            int[] given = {10, 20, 30};
            int[] fourCase = { 1, 2, 3, 4 };
            List<int> permutationList = fourCase.ToList();
            printPermutations("", permutationList);
        }
        // Recursive calls that iterates all positions and swaps the last two
        public static void printPermutations (string workingString, List<int> remainingArray)
        {
            if (remainingArray.Count == 1)
            {
                workingString += remainingArray[0] + "]";
                Console.WriteLine(workingString);
            }
            foreach(int i in remainingArray)
            {
                string temp = workingString;
                if(workingString == "")
                {
                    workingString += "[";
                }
                workingString += i +", ";
                List<int> newList = (from given in remainingArray where given != i select given).ToList();

                printPermutations(workingString, newList);
                workingString = temp;
            }
        }
    }
}
