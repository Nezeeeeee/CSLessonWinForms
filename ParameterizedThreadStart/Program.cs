using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ParameterizedThreadStart
{
    class Program
    {
        //Потоки с параметрами и ParameterizedThreadStart
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            counter.x = 4;
            counter.y = 5;

            Thread myThread = new Thread(Count);
            myThread.Start(counter);

            for(int i = 1; i < 9; i++)
            {
                Console.WriteLine("Главный поток:");
                Console.WriteLine(i*i);
                Thread.Sleep(300);
            }
        }

        public static void Count(object obj)
        {
            for (int i = 1; i < 9; i++)
            {
                Counter c = (Counter)obj;

                Console.WriteLine("Второй поток:");
                Console.WriteLine(i*c.x * c.y);
            }
        }
    }

    public class Counter
    {
        public int x;
        public int y;
    }
}
