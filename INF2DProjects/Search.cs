using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2DProjectsDLL
{
    class Search
    {
        /// Uses a sequentialsearch on the specified array
        public Boolean SequentialSearch<T>(T[] objs, T obj) where T : IComparable<T>
        {
            for (int i = 0; i < objs.Length - 1; i++)
            {
                T temp = (T) objs.GetValue(i);
                if (temp.CompareTo(obj) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        /// Uses a binarysearch on the specified array
        public Boolean BinarySearch<T>(T[] objs, T obj) where T : IComparable<T>
        {
            int upperBound, lowerBound, mid;
            upperBound = objs.Length - 1;
            lowerBound = 0;

            while (lowerBound <= upperBound)
            {
                mid = (upperBound + lowerBound) / 2;
                if (objs[mid].CompareTo(obj) == 0)
                {
                    return true;
                }
                else
                {
                    if (obj.CompareTo(objs[mid]) == 1)
                    {
                        upperBound = mid - 1;
                    }
                    else
                    {
                        lowerBound = mid + 1;
                    }
                }
            }
            return false;
        }

        //find min
        static int FindMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
                if (arr[i] < min)
                    min = arr[i];
            return min;
        }

        //find max
        static int FindMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
                if (arr[i] > max)
                    max = arr[i];
            return max;
        }
    
    }
}
