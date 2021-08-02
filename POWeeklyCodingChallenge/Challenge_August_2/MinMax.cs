using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Challenge_August_2
{
    public class MinMax
    {
        /// <summary>
        /// Finds the minimum value 'min', and maximum value 'max' from the given array 'arr'. 
        /// The value will be unique in the arr in which any given index n arr[n] and min index
        /// m such that arr[n] != arr[m]
        /// </summary>
        /// <param name="arr"></param>
        public void Solve(int[] arr)
        {
            Dictionary<int, int> arrCount = new Dictionary<int, int>();
            foreach(int i in arr)
            {
                if (arrCount.ContainsKey(i))
                    arrCount[i]++;
                else
                    arrCount.Add(i, 1);
            }
            int max = int.MinValue;
            int min = int.MaxValue;
            foreach (KeyValuePair<int,int> KVP in arrCount)
            {
                if (KVP.Key >= max && KVP.Value == 1)
                    max = KVP.Key;
                if (KVP.Key <= min && KVP.Value == 1)
                    min = KVP.Key;
            }
            Console.Write("Given Array: ");
            Utility.Printer.printIntArrayAsArray(arr.ToList());
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
        }
        public MinMax()
        {

            Console.WriteLine("------------------------------");
            Console.WriteLine("       <-->MinMax<-->");
            Console.WriteLine("------------------------------");
        }
    }
}
