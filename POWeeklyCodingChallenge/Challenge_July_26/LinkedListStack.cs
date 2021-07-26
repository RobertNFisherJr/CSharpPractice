using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_July_26
{
    public class LinkedListStack
    {
        public LinkedList<int> myList { get; set; }
        public LinkedListStack()
        {
            this.myList = new LinkedList<int>();
        }
        public int Pop()
        {
            int firstElement = myList.First();
            myList.RemoveFirst();
            return firstElement;
        }
        public void Push(int element)
        {
            myList.AddFirst(element);
        }
        public int Peek()
        {
            return myList.First();
        }
        public void print()
        {
            Utility.Printer.printIntArrayAsArray(myList.ToList());
        }
    }
}
