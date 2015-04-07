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
            LinkedList LinkedList = new LinkedList();
            ListIter iter = new ListIter(LinkedList);

            iter.InsertAfter("Test1");
            iter.InsertAfter("Test2");
            iter.InsertAfter("Tets3");
            iter.InsertAfter("Test4");
            Console.WriteLine(iter.GetCurrent());
            iter.InsertAfter("Test5");
            iter.InsertBefore("Test6");
            iter.InsertAfter("Test7");
            iter.Remove();
            LinkedList.PrintList();
            Console.WriteLine(LinkedList.getFirst());

           
            Console.ReadLine();


        }
    }
}
