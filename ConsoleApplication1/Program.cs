using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {
            static void Main(string[] args)
        {
            #region bubble
            string[] bubbleArray = {"test", "hoi", "appel", "peer", "banaan", "kip", "doos"};
            Console.WriteLine("BubbleSort");

            Console.Write("Array: ");
            foreach (string str in bubbleArray)
            {
                Console.Write(str + " ");
            }

            Console.WriteLine();
            //Sorting.InsertionSort<string>(bubbleArray);

            Console.Write("Sorted: ");
            foreach (string str in bubbleArray)
            {
                Console.Write(str + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            //Random rnd = new Random(100);
            //int[] bubbleArray2 = new int[5000];

            //for (int i = 0; i < 5000; i++)
            //{
            //    bubbleArray2[i] = rnd.Next(100);
            //}

            int[] bubbleArray2 = { 9, 4, 6, 10, 11, 2, 3 };

            Console.Write("Array: ");
            foreach (int i in bubbleArray2)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            
            //Sorting.InsertionSort<int>(bubbleArray2);
            
            Console.Write("Sorted: ");
            foreach (int i in bubbleArray2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            #endregion bubble

            #region selection
            string[] selectionArray = { "test", "hoi", "appel", "peer", "banaan", "kip", "doos" };

            Console.WriteLine("SelectionSort");

            Console.Write("Array: ");
            foreach (string str in selectionArray)
            {
                Console.Write(str + " ");
            }

            Console.WriteLine();
            //Sorting.InsertionSort<string>(selectionArray);

            Console.Write("Sorted: ");
            foreach (string str in selectionArray)
            {
                Console.Write(str + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            int[] selectionArray2 = { 9, 4, 6, 10, 11, 2, 3 };

            Console.Write("Array: ");
            foreach (int i in selectionArray2)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            //Sorting.InsertionSort<int>(selectionArray2);


            Console.Write("Sorted: ");
            foreach (int i in selectionArray2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            #endregion selection

            #region insertion

            Console.WriteLine("InsertionSort");

            string[] insertionArray = { "test", "hoi", "appel", "peer", "banaan", "kip", "doos" };

            Console.Write("Array: ");
            foreach (string str in insertionArray)
            {
                Console.Write(str + " ");
            }

            Console.WriteLine();
            //Sorting.InsertionSort<string>(insertionArray);


            Console.Write("Sorted: ");
            foreach (string str in insertionArray)
            {
                Console.Write(str + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            int[] insertionArray2 = { 9, 4, 6, 10, 11, 2, 3 };

            Console.Write("Array: ");
            foreach (int i in insertionArray2)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            //Sorting.InsertionSort<int>(insertionArray2);

            Console.Write("Sorted: ");
            foreach (int i in insertionArray2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            #endregion insertion

            Console.ReadLine();
        }
        }
    }