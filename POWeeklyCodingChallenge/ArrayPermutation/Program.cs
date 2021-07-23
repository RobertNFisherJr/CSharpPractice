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
            // Base Case
            if (remainingArray.Count == 1)
            {
                workingString += remainingArray[0] + "]";
                Console.WriteLine(workingString);
            }
            // Loop through remaining options
            foreach(int i in remainingArray)
            {
                // Store start string as temp
                string temp = workingString;
                // If first case, append first bracket
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
