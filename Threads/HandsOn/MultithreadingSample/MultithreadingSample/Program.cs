using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultithreadingSample
{
    class Program
    {
        static void PrintTheNumbers(object state) {
            Printer task = (Printer)state;
            task.PrintNumbers();
                }
        static void Main(string[] args)
        {
            Console.WriteLine("*****ThreadStart Delegat App *****\n");
            Console.WriteLine("Main thread started. ThreadID = {0}", Thread.CurrentThread.ManagedThreadId);
            Printer p = new Printer();
            WaitCallback workItem = new WaitCallback(PrintTheNumbers);
            for(int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(workItem, p);
            }
            Console.WriteLine("All tasks queued");
            Console.ReadLine();
        }
    }
}
