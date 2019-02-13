using System;
using System.Threading;


namespace ThreadTest
{
    class Program
    {
        static void A()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Thread a"+i);
            }
            Console.WriteLine("Thread A da hoan thanh");
        }
        static void B()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Thraed b"+i);
            }
            Console.WriteLine("Thread B da hoan thanh");
        }
        static void Main(string[] args)
        {
            ThreadStart threada = new ThreadStart(A);
            ThreadStart threadb = new ThreadStart(B);
            Thread t1 = new Thread(threada);
            Thread t2 = new Thread(threadb);
            t1.Start();
            t2.Start();
            Console.ReadKey();
        }
    }
}
