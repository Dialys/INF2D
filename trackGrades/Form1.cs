using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Grades;

namespace trackGrades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int[,] grades = new int[,] {{1, 82, 74, 89, 100},
            {2, 93, 96, 85, 86},
            {3, 83, 72, 95, 89},
            {4, 91, 98, 79, 88}};

            double average = Grades.Grades.getAverage(grades);
            double highest = Grades.Grades.getHighest(grades);
            double lowest = Grades.Grades.getLowest(grades);

            label1.Text = average.ToString();
            label2.Text = highest.ToString();
            label3.Text = lowest.ToString();

            ArrayList grade = new ArrayList();
            int lastStudent = grades.GetUpperBound(0);
            int lastGrade = grades.GetUpperBound(1);
            int high = 0;
            for (int row = 0; row <= lastStudent; row++)
            {
                for (int col = 0; col <= lastGrade; col++)
                    if (grades[row, col] > high)
                    {
                        grade.Add(grades[row, col]);
                    }
            }

            double gemiddelde = Grades.Grades.getAverage2(grade);
            double hoogste = Grades.Grades.getHighest2(grade);
            double laagste = Grades.Grades.getLowest2(grade);

            label4.Text = gemiddelde.ToString();
            label5.Text = hoogste.ToString();
            label6.Text = laagste.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
