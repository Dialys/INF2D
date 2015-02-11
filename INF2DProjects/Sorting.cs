using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2DProjects
{
    public static class Sorting
    {
       
        //Bubblesort function
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
    }
}
