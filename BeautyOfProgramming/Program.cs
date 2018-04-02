using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BeautyOfProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            MakeUsage(75f);
        }

		// https://onlinehelp.tableau.com/current/server/en-us/perf_collect_perfmon.htm
        private static void MakeUsage(float level)
        {
            PerformanceCounter p = new PerformanceCounter("Processor Information",
                "% Processor Utility", "_Total");

            int counter = 0;

            while (true)
            {
                //Console.WriteLine(p.NextValue());
                if (p.NextValue() > level)
                {
                    Thread.Sleep(10);
                }
                //else
                //{
                //    counter = (counter + 1) % Int32.MaxValue;
                //}
            }
        }
    }
}
