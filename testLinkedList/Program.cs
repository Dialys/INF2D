using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INF2DProjectsDLL;

namespace testLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a LinkedList and an iterator for the linkedlist
            LinkedList LinkedList = new LinkedList();
            ListIter iter = new ListIter(LinkedList);

            //Add data with the iterator in the linkedlist
            iter.InsertAfter("Test1");
            iter.InsertAfter("Test2");
            iter.InsertAfter("Tets3");
            iter.InsertAfter("Test4");
            
            //Test if the getCurrent method works
            Console.WriteLine(iter.GetCurrent());
            iter.InsertAfter("Test5");
            iter.InsertBefore("Test6");
            iter.InsertAfter("Test7");
           
            //Test if the remove method works
            iter.Remove();

            //Print the list of the linkedlist
            LinkedList.PrintList();
            Console.WriteLine(LinkedList.getFirst());
            
            Console.ReadLine();


        }
    }
}
