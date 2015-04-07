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

            //if you want the bubble algorithm
            if (line == "bubble")
            {
                bubbleFunction();
                Console.ReadLine();
            }
            //if you wnat the select algorithm
            else if (line == "select")
            {
                selectFunction();
                Console.ReadLine();
            }
            //if you want the insert algorithm
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
         
           //Sort the string array with the bubblesort
            Sorting.BubbleSort<string>(bubbleArray);
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
           //Sort the integer array with the bubblesort 
           Sorting.BubbleSort<int>(bubbleArray2);
           
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
           //Make an integer and a string array
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
           //Sort the string array with the selectionsort
           Sorting.SelectionSort<string>(selectArray);
                     
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
           //Sort the integer array with the selectionsort
           Sorting.SelectionSort<int>(selectArray2);
           
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
           //Make a integer array and an string array
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
           
           //Sort the string array with the insertionsort
           Sorting.InsertionSort<string>(insertArray);
         
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

           //Sort the integer array with the insertionsort
           Sorting.InsertionSort<int>(insertArray2);
           Console.Write("Sorted array: ");
           foreach (int i in insertArray2)
           {
               Console.Write(i + " ");
           }
           Console.WriteLine();   
       }

    }
}

