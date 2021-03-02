using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Async1
{
    class Program
    {

        public async static Task TaskFirst()
        {
            Task<string>  FirstTask = TaskSecond();
            string message = await FirstTask;
            Console.WriteLine(message);
            Console.Read();
        }
        public async static Task<string> TaskSecond()
        {
             Thread.Sleep(1000);
             return "This is returned from Second Task Function";
        }
        public static void Main(string[] args)
        {
             TaskFirst();
        }
    }
}
