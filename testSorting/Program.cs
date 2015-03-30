using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INF2DProjectsDLL;

namespace testSorting{
    class Program
    {
        //Main method of this program
        //The main program is used to choose a sorting algorithm
        public static void Main(string[] args)
        {
            Console.Write("Type: bubble, select or insert");
            Console.WriteLine();
            //Reads the input of the user to see which algorithm to use
            string line = Console.ReadLine();

            if (line == "bubble")
            {
                bubbleFunction();
                Console.ReadLine();
            }
            else if (line == "select")
            {
                selectFunction();
                Console.ReadLine();
            }
            else if (line == "insert")
            {
                insertFunction();
                Console.ReadLine();
            }

        }

        //Method for the bubble algorithm
       static void bubbleFunction()
        {
           //Make 2 types of array, 1 of strings and 1 of integers 
           string[] bubbleArray = { "asd", "xvf", "sdgaah", "wqrq", "xcv", "grs" };
            int[] bubbleArray2 = { 8, 5, 2, 6, 7, 2, 1 };
           //Make a timer to see how long it takes to execute the algorithm 
           Timer timer = new Timer();
            Console.WriteLine("BubbleSort");
            Console.Write("Array: ");
            foreach (string str in bubbleArray)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
            timer.Start();
            Sorting.BubbleSort<string>(bubbleArray);
            timer.Stop();

            Console.WriteLine(timer.getTime());
            Console.Write("Sorted Array: ");
            foreach (string str in bubbleArray)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
            Console.Write("Array: ");
            foreach (int i in bubbleArray2)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            timer.Start();
            Sorting.BubbleSort<int>(bubbleArray2);
            timer.Stop();
            Console.WriteLine(timer.getTime());

            Console.Write("Sorted Array: ");
            foreach (int i in bubbleArray2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }

       static void selectFunction()
       {
           string[] selectArray = { "asd", "xvf", "sdgaah", "wqrq", "xcv", "grs" };
           int[] selectArray2 = { 8, 5, 2, 6, 7, 2, 1 };
           Timer timer = new Timer();

           Console.WriteLine("SelectionSort");
           Console.Write("Array: ");
           foreach (string str in selectArray)
           {
               Console.Write(str + " ");
           }

           Console.WriteLine();
           timer.Start();
           Sorting.SelectionSort<string>(selectArray);
           timer.Stop();
           Console.WriteLine("Time to execute: " + timer.getTime());
          
           Console.Write("Sorted array: ");
           foreach (string str in selectArray)
           {
               Console.Write(str + " ");
           }

           Console.WriteLine();
           Console.WriteLine();

           Console.Write("Array: ");
           foreach (int i in selectArray2)
           {
               Console.Write(i + " ");
           }

           Console.WriteLine();

           timer.Start();
           Sorting.SelectionSort<int>(selectArray2);
           timer.Stop();
           Console.WriteLine("Time to execute: " + timer.getTime());
           Console.Write("Sorted Array: ");
           foreach (int i in selectArray2)
           {
               Console.Write(i + " ");
           }
           Console.WriteLine();
           Console.ReadLine();
       }

       static void insertFunction()
       {
           string[] insertArray = { "asd", "xvf", "sdgaah", "wqrq", "xcv", "grs" };
           int[] insertArray2 = { 8, 5, 2, 6, 7, 2, 1 };
           Timer timer = new Timer();
           Console.WriteLine("InsertionSort");
           Console.Write("Array: ");
           foreach (string str in insertArray)
           {
               Console.Write(str + " ");
           }

           Console.WriteLine();
           timer.Start();
           Sorting.InsertionSort<string>(insertArray);
           timer.Stop();
           Console.WriteLine("Time to execute: " + timer.getTime());

           Console.Write("Sorted array: ");
           foreach (string str in insertArray)
           {
               Console.Write(str + " ");
           }

           Console.WriteLine();
           Console.WriteLine();

           Console.Write("Array: ");
           foreach (int i in insertArray2)
           {
               Console.Write(i + " ");
           }

           Console.WriteLine();
           timer.Start();
           Sorting.InsertionSort<int>(insertArray2);
           timer.Stop();
           Console.WriteLine("Time to execute: " + timer.getTime()); 
           Console.Write("Sorted array: ");
           foreach (int i in insertArray2)
           {
               Console.Write(i + " ");
           }
           Console.WriteLine();   
       }

    }
}

