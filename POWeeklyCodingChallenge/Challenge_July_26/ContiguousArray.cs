using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Challenge_July_26
{
    public class ContiguousArray
    {
        /// <summary>
        /// Finds a continuous subarray of arr whose sum equals the given value x.
        /// </summary>
        /// <param name="arr">Some array that should contain a continuous subarray whos values sum to x</param>
        /// <param name="x">The target sum for a given subarray</param>
        public void Solve(int[] arr, int x)
        {
            int sum = 0;
            List<int> elements = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                elements = new List<int>();
                List<int> indexs = new List<int>();
                indexs.Add(i);
                sum = 0;
                int counter = i;

                while (sum < x)
                {
                    sum += arr[counter];
                    elements.Add(arr[counter]);

                    if (sum == x)
                    {
                        Console.Write("Elements: ");
                        Utility.Printer.printIntArrayAsArray(elements);
                        indexs.Add(counter);
                        Console.Write("Index Between: ");
                        Utility.Printer.printIntArrayAsArray(indexs);
                        return;
                    }

                    counter++;
                    if (counter >= arr.Length)
                    {
                        Console.WriteLine("We have a problem!! This sum does not exist!");
                        return;
                    }
                }
            }

        }
        public ContiguousArray()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("   <-->Contiguous Array<-->");
            Console.WriteLine("------------------------------");
        }
    }
}
