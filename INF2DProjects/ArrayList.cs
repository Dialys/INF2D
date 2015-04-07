using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Grades
{
    public static class Grades
    {
        // Method to get the average value of an array
        public static double getAverage(int[,] array)
        {
            int lastStudent = array.GetUpperBound(0); // Store the last student
            int lastGrade = array.GetUpperBound(1); // Store the last grade
            int size = array.Length; // Store the array size
            double average = 0.0; // Set average to 0z
            double total = 0; // Set total to 0
            for (int row = 0; row <= lastStudent; row++) // Go through all students
            {
                for (int col = 0; col <= lastGrade; col++) // Go through all grades
                    total += array[row, col]; // Total up all values
                average = total / size; // Divide total with the amount of values in the arraylist
            }
            return average; // Return the average
        }

        // Method to get the higest value of an array
        public static int getHighest(int[,] array)
        {
            int lastStudent = array.GetUpperBound(0); // Store the last student
            int lastGrade = array.GetUpperBound(1); // Store the last grade
            int highest = 0; // Set current highest grade to minimum
            for (int row = 0; row <= lastStudent; row++) // Go through all students
            {
                for (int col = 0; col <= lastGrade; col++) // Go through all grades
                    if (array[row, col] > highest) // If found value is higher than the current highest grade
                    {
                        highest = array[row, col]; // Set highest grade to the found value
                    }
            }
            return highest; // Return the highest grade
        }

        // Method to get the lowest value of an array
        public static int getLowest(int[,] array)
        {
            int lastStudent = array.GetUpperBound(0); // Store the last student
            int lastGrade = array.GetUpperBound(1); // Store the last grade
            int lowest = 100; // Set current lowest grade to max
            for (int row = 0; row <= lastStudent; row++) // Go through all students
            {
                for (int col = 0; col <= lastGrade; col++) // Go through all grades
                    if (array[row, col] < lowest) // If found value is lower than the current lowest grade
                    {
                        lowest = array[row, col]; // Set lowest grade to the found value
                    }
            }
            return lowest; // Return the lowest grade.
        }

        // Method to get the average value of an ArrayList
        public static double getAverage2(ArrayList array)
        {
            double total = 0; // Set total to 0
            double average = 0.0; // Set average to 0
            foreach (Object ar in array) // Go through all values in the arraylist
            {
                total += (int)ar; // Total up all values.
            }
            average = total / array.Count; // Divide total with the amount of values in the arraylist
            return average; // Return the average
        }

        // Method to get the highest value of an ArrayList
        public static double getHighest2(ArrayList array)
        {
            double highest = 0; // Set current highest grade to minimum
            foreach (Object ar in array) // Go through all values in the arraylist
            {
                if ((int)ar > highest) // If the found value is higher than the current highest value
                {
                    highest = (int)ar; // Set highest grade to found value
                }                
            }            
            return highest; // Return the highest grade
        }

        // Method to get the lowest value of an ArrayList
        public static double getLowest2(ArrayList array)
        {
            double lowest = 100; // Set current lowest grade to max
            foreach (Object ar in array) // Go through all values in the arraylist
            {
                if ((int)ar < lowest) // If the found value is lower than the current lowest value
                {
                    lowest = (int)ar; // Set lowest grade to found value
                }
            }
            return lowest; // Return the lowest grade
        }
    }
}
