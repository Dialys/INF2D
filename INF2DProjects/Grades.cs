using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public static class Grades
    {
        public static double getAverage(int[,] array)
        {
            int lastStudent = array.GetUpperBound(0);
            int lastGrade = array.GetUpperBound(1);
            int size = array.Length;
            double average = 0.0;
            double total = 0;
            for (int row = 0; row <= lastStudent; row++)
            {
                for (int col = 0; col <= lastGrade; col++)
                    total += array[row, col];
                average = total / size;
            }
            return average;
        }

        public static int getHighest(int[,] array)
        {
            int lastStudent = array.GetUpperBound(0);
            int lastGrade = array.GetUpperBound(1);
            int highest = 0;
            for (int row = 0; row <= lastStudent; row++)
            {
                for (int col = 0; col <= lastGrade; col++)
                    if (array[row, col] > highest)
                    {
                        highest = array[row, col];
                    }
            }
            return highest;
        }

        public static int getLowest(int[,] array)
        {
            int lastStudent = array.GetUpperBound(0);
            int lastGrade = array.GetUpperBound(1);
            int lowest = 100;
            for (int row = 0; row <= lastStudent; row++)
            {
                for (int col = 0; col <= lastGrade; col++)
                    if (array[row, col] < lowest)
                    {
                        lowest = array[row, col];
                    }
            }
            return lowest;
        }
    }
}
