using System;

namespace AbstractFactoryHandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            Client cl = new Client();
            cl.Invoke();
        }
    }
}
