using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2DProjects
{
    public static class Sorting
    {

        //BubbleSort function
        public static void BubbleSort<A>(this A[] array) where A : IComparable<A>
        {
            bool isDone = false;
            for (int outer = array.Length - 1; outer >= 1; outer--)
            {
                for (int inner = 0; inner <= outer - 1; inner++)
                {
                    if (array[inner].CompareTo(array[outer]) > 0)
                    {
                        var temp = array[inner];
                        array[inner] = array[inner + 1];
                        array[inner + 1] = temp;
                        isDone = true;
                    }
                }
                if (!isDone)
                {
                    break;
                }
            }
        }

        //SelectionSort Function
        public static void SelectionSort<A>(this A[] array) where A : IComparable<A>
        {
            int upper = array.Length - 1;
            int min;
            for (int outer = 0; outer <= upper; outer++)
            {
                min = outer;
                for (int inner = outer + 1; inner <= upper; inner++)
                {
                    if (array[inner].CompareTo(array[min]) > 0)
                        min = inner;
                    var temp = array[outer];
                    array[outer] = array[min];
                    array[min] = temp;
                }
            }
        }

        //InsertionSort Function
        public static void InsertionSort<A>(this A[] array) where A : IComparable<A>
        {
            int upper = array.Length - 1;
            int inner;
            for (int outer = 1; outer <= upper; outer++)
            {
                var temp = array[outer];
                inner = outer;
                while (inner > 0 && array[inner - 1].CompareTo(temp) > 0)
                {
                    array[inner] = array[inner - 1];
                    inner -= 1;
                }
                array[inner] = temp;
            }
        }
    }
}

