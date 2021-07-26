using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public static class Printer
    {
        public static void printIntArrayAsArray(List<int> arr)
        {
            string toPrint = "[";
            foreach(int i in arr)
            {
                toPrint += i + ", ";
            }
            if (toPrint != "[")
                toPrint = toPrint.Substring(0, toPrint.Length - 2) + "]";
            else
                toPrint += "]";
            Console.WriteLine(toPrint);
        }
    }
}
