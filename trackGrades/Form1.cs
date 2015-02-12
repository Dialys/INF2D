using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            label1.Text = "Average: " + average.ToString();
            label2.Text = "Highest: " + highest.ToString();
            label3.Text = "Lowest: " + lowest.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
