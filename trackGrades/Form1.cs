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

            double poep = Grades.Grades.getAverage(grades);

            hoi.Text = poep.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
