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
            Console.WriteLine("------------------------------");
            Console.WriteLine("   <-->LinkedListStack<-->");
            Console.WriteLine("------------------------------");
        }
        /// <summary>
        /// Removes the "Top" element in the LinkedListStack
        /// </summary>
        /// <returns>Top element</returns>
        public int Pop()
        {
            int firstElement = myList.First();
            myList.RemoveFirst();
            return firstElement;
        }
        /// <summary>
        /// Adds the given integer to the LinkedListStack
        /// </summary>
        /// <param name="element">Some given integer</param>
        public void Push(int element)
        {
            myList.AddFirst(element);
        }
        /// <summary>
        /// Returns the top integer of the LinkedListStack without removing it from the list
        /// </summary>
        /// <returns></returns>
        public int Peek()
        {
            return myList.First();
        }
        /// <summary>
        /// Prints the list as an array, this is primarily used to get a visual of what the current LinkedList looks like.
        /// </summary>
        public void print()
        {
            Utility.Printer.printIntArrayAsArray(myList.ToList());
        }
    }
}
