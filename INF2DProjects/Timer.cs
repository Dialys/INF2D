using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Timer
{
    class Timer
    {
        //Create the stopwatch
        Stopwatch sw = new Stopwatch();

        //Method to start the stopwatch
        public void start()
        {
            sw.Reset();
            sw.Start();
        }
        
        //Method to stop the stopwatch
        public void stop()
        {
            sw.Stop();
        }

        //Method to return the elapsed time
        public string getTime()
        {
            TimeSpan ts = sw.Elapsed;
            return ts.ToString();
        }

    }
}
