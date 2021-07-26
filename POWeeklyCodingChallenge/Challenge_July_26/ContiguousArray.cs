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

                Console.WriteLine(arr[i]);
                while(sum < x)
                {
                    sum += arr[counter];
                    elements.Add(arr[counter]);

                    if (sum == x)
                    {
                        Console.WriteLine("Elements: ");
                        Utility.Printer.printIntArrayAsArray(elements);
                        indexs.Add(counter);
                        Console.WriteLine("Index Between: ");
                        Utility.Printer.printIntArrayAsArray(indexs);
                        return;
                    }

                    counter++;
                    if(counter >= arr.Length)
                    {
                        Console.WriteLine("We have a problem!! This sum does not exist!");
                        return;
                    }
                }
                Console.WriteLine("Sum: " + sum);
            }
            Utility.Printer.printIntArrayAsArray(elements);
        }
    }
}
