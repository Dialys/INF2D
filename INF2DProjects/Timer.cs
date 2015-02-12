using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace INF2DProjectsDLL
{
    public class Timer
    {
        //Create the stopwatch
        Stopwatch stopwatch = new Stopwatch();

        //Method to start the stopwatch
        public void Start()
        {
            long seed = Environment.TickCount; 	// Prevents the JIT Compiler from optimizing Fkt calls away
            long result = 0;
            int count = 100000000;

            //20 test to warmup
            for (int repeat = 0; repeat < 20; ++repeat)
            {
                stopwatch.Reset();
                stopwatch.Start();
                result ^= TestFunction(seed, count);
                stopwatch.Stop();
            }

            Process.GetCurrentProcess().ProcessorAffinity = new IntPtr(2); // Uses the second Core or Processor for the Test
            Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;  	// Prevents "Normal" processes from interrupting Threads
            Thread.CurrentThread.Priority = ThreadPriority.Highest;  	// Prevents "Normal" Threads from interrupting this thread
            stopwatch.Reset();
            stopwatch.Start();
            while (stopwatch.ElapsedMilliseconds < 1500)  // A Warmup of 1000-1500 mS 
            // stabilizes the CPU cache and pipeline.
            {
                result = TestFunction(seed, count); // Warmup
            }
                stopwatch.Stop();
                stopwatch.Reset();
                stopwatch.Start();
        }
        
        //Method to stop the stopwatch
        public void Stop()
        {
            stopwatch.Stop();
        }

        public string getTime()
        {
            return "Ticks: " + stopwatch.ElapsedTicks + " mS: " + stopwatch.ElapsedMilliseconds;
        }



        public static long TestFunction(long seed, int count)
        {
            long result = seed;
            for (int i = 0; i < count; ++i)
            {
                result ^= i ^ seed;
            }
            return result;
        }

    }
}
