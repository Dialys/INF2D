using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INF2DProjectsDLL;

namespace testSearch
{
    class Program
    {
        static void Main(string[] args)
        {
           //Creat an array of integers to search in
            int[] num = new int[8] { 4,8,12,81,38,65,48, 72};

            //Make a search object
            Search src = new Search();

            //Test the search methods
            Console.WriteLine(src.BinarySearch<int>(num, 5));
            Console.WriteLine(src.SequentialSearch<int>(num, 39));
            Console.ReadLine();
        }
    }
}
