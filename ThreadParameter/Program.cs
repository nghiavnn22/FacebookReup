using System;
using System.Threading;

namespace ThreadParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Dowork);
            t1.Start();
            Program program = new Program();
            Thread t2 = new Thread(program.DoMoreWork);
            t2.Start("Huu Nghia");
            Console.ReadKey();
        }
        public void uploadImagetoPage(string page,string filepath,string )
        {

        }
        static void Dowork(object data)
        {
            Console.WriteLine("This is static method");
            Console.WriteLine("Paremeter {0}:" ,data);
        }
        void DoMoreWork(object data)
        {
            Console.WriteLine("This is instance method");
            Console.WriteLine("Paremeter {0}:", data);
        }
    }
}
