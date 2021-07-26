using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayPermutation
{
    public class Program
    {
        public void Solve(int[] given, int[] fourCase)
        {
            // Test Cases, pass to permutationList to convert
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
