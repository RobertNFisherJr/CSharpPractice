using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayPermutation
{
    public class Program
    {
        public string permutatedArray { get; set; }
        public int index { get; set; }
        /// <summary>
        /// Calls on recursive function printPermutations, to find every possible permutation
        /// of the given array. The number of results will be equivelent to arr.Length factorial.
        /// </summary>
        /// <param name="arr">array that you would like permutated</param>
        public void Solve(int[] arr)
        {
            this.index = 0;
            this.permutatedArray = "";
            // Test Cases, pass to permutationList to convert
            List<int> permutationList = arr.ToList();
            printPermutations("", permutationList);
        }
        /// <summary>
        /// Recursive calls that iterates all positions looping through their given options
        /// </summary>
        /// <param name="workingString">A string that holds the current values of the array being constructed</param>
        /// <param name="remainingArray">The remaining options for the method to select</param>
        public void printPermutations (string workingString, List<int> remainingArray)
        {
            // Base Case
            if (remainingArray.Count == 1)
            {
                this.index += 1;
                workingString += remainingArray[0] + "]";
                this.permutatedArray = workingString;
                Console.WriteLine("Permutation " + index + ":\t" + workingString);
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
        public Program()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("  <-->Array Permutation<-->");
            Console.WriteLine("------------------------------");
        }
    }
}
