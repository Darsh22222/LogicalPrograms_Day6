using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    class StopWatch
    {
        public static void Calculate()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(6);
            }
            sw.Stop();
            Console.WriteLine("The elapse time is:{0:hh\\:mm\\:ss}", sw.Elapsed);
        }
    }
}
