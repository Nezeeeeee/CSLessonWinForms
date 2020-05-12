using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ClassMutex
{
    class Program
    {
        static Mutex mutexObj = new Mutex();
        static int x = 0;
        static void Main(string[] args)
        {
            for(int i = 0; i < 5; i++)
            {
                Thread myThread = new Thread(Count);
                myThread.Name = $"Поток {i}";
                myThread.Start();
            }
        }

        public static void Count()
        {
            mutexObj.WaitOne();
            x = 1;
            for(int i = 1; i < 9; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
                x++;
                Thread.Sleep(100);
            }

            mutexObj.ReleaseMutex();
        }
    }
}
