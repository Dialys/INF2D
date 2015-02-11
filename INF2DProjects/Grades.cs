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
            //int[,] grades = new int[,] {{1, 82, 74, 89, 100},
            //{2, 93, 96, 85, 86},
            //{3, 83, 72, 95, 89},
            //{4, 91, 98, 79, 88}};
            int lastStudent = array.GetUpperBound(0);
            int lastGrade = array.GetUpperBound(1);
            double average = 0.0;
            int total;
            for (int row = 0; row <= lastStudent; row++)
            {
                total = 0;
                for (int col = 0; col <= lastGrade; col++)
                    total += array[row, col];
                average = total / lastGrade;
                //Console.WriteLine("Average grade: " + average);
            }
            return average;
        }
    }
}
