using System;

namespace SingletonHandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            DBConn db1 = DBConn.getInstance();
            DBConn db2 = DBConn.getInstance();
            if (db1 == db2)
            {
                Console.WriteLine("Both are from same instance");
            }
            else
            {
                Console.WriteLine("Both are form different instance");
            }
        }
    }
}
