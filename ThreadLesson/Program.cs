using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем новый поток
            Thread myThread = new Thread(new ThreadStart(Count));
            myThread.Start(); //Запускаем поток

            for(int i  = 1; i < 9; i++)
            {
                Console.WriteLine("Главный поток");
                Console.WriteLine(i*i);
                Thread.Sleep(300);
            }

            Thread myThread2 = new Thread(Count2);
            myThread2.Start();
        }

        public static void Count()
        {
            for(int i =1; i <9; i++)
            {
                Console.WriteLine("Второй поток:");
                Console.WriteLine(i * i);
                Thread.Sleep(400);
            }
        }

        public static void Count2()
        {
            for(int i =1; i<9; i++)
            {
                Console.WriteLine("Третий поток:");
                int a = 2+3;
                int sum = a*i;
                Console.WriteLine(sum);
                Thread.Sleep(400);
                
            }
        }
    }
}
