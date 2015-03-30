using System;
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

            //Prevents the JIT Comipler from optimizing Fkt calls away
            long seed = Environment.TickCount; 	
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

            //Zorgt ervoor dat de Second Core gebruikt wordt
            Process.GetCurrentProcess().ProcessorAffinity = new IntPtr(2); 
            //Voorkomt dat "normale processen" de thread niet interrupten
            Process.GetCurrentProcess().PriorityClass =  ProcessPriorityClass.High;
            //Voorkomt dat "normale threads" de thread niet interrupten
            Thread.CurrentThread.Priority = ThreadPriority.Highest;  

            Console.WriteLine("Warmup");
            stopwatch.Reset();
            stopwatch.Start();
            //Warmup zorgt ervoor dat de CPU Cache en de pipeline gestabilliseerd wordt
            //Warmup tussen de 1000 en 1500 ms
            while (stopwatch.ElapsedMilliseconds < 1200) 
            {
                //De warmup
                result = TestFunction(seed, count);
            }
            stopwatch.Stop();

            //
            for (int repeat = 0; repeat < 20; ++repeat)
            {
                stopwatch.Reset();
                stopwatch.Start();
                result ^= TestFunction(seed, count);
                stopwatch.Stop();
                Console.WriteLine("Ticks: " + stopwatch.ElapsedTicks + " mS: " + stopwatch.ElapsedMilliseconds);
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }

        //Functie voor de warmup
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