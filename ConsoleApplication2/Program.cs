﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            long seed = Environment.TickCount; 	// Prevents the JIT Compiler from optimizing Fkt calls away
            long result = 0;
            int count = 100000000;

            Console.WriteLine("20 Tests to warmup");
             for (int repeat = 0; repeat < 20; ++repeat)
            {
                stopwatch.Reset();
                stopwatch.Start();
                result ^= TestFunction(seed, count);
                stopwatch.Stop();
                Console.WriteLine("Ticks: " + stopwatch.ElapsedTicks + " mS: " + stopwatch.ElapsedMilliseconds);
            }

            Process.GetCurrentProcess().ProcessorAffinity = new IntPtr(2); // Uses the second Core or Processor for the Test
            Process.GetCurrentProcess().PriorityClass =  ProcessPriorityClass.High;  	// Prevents "Normal" processes from interrupting Threads
            Thread.CurrentThread.Priority = ThreadPriority.Highest;  	// Prevents "Normal" Threads from interrupting this thread

            Console.WriteLine("20 Tests with correct preparation");
            Console.WriteLine("Warmup");
            stopwatch.Reset();
            stopwatch.Start();
            while (stopwatch.ElapsedMilliseconds < 1200)  // A Warmup of 1000-1500 mS 
            // stabilizes the CPU cache and pipeline.
            {
                result = TestFunction(seed, count); // Warmup
            }
            stopwatch.Stop();

            for (int repeat = 0; repeat < 20; ++repeat)
            {
                stopwatch.Reset();
                stopwatch.Start();
                result ^= TestFunction(seed, count);
                stopwatch.Stop();
                Console.WriteLine("Ticks: " + stopwatch.ElapsedTicks + " mS: " + stopwatch.ElapsedMilliseconds);
            }
            Console.WriteLine(result); // prevents optimizations 
            Console.ReadLine();
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