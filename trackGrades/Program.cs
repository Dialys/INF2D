using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trackGrades
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            int[,] grades = new int[,] {{1, 82, 74, 89, 100},
            {2, 93, 96, 85, 86},
            {3, 83, 72, 95, 89},
            {4, 91, 98, 79, 88}};
        }
    }
}
