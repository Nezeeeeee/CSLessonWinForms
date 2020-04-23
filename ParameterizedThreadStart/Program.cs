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
            int number = 4;
            //Создаем новый поток
            Thread myThread = new Thread(Count);
            myThread.Start(number);

            for(int i = 1; i < 9; i++)
            {
                Console.WriteLine("Главный поток:");
                Console.WriteLine(i*i);
                Thread.Sleep(300);
            }
        }

        public static void Count(object x)
        {
            for (int i = 1; i < 9; i++)
            {
                int n = (int)x;

                Console.WriteLine("Второй поток:");
                Console.WriteLine(i * n);
                Thread.Sleep(400);
            }
        }
    }
}
