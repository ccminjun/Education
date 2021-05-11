using System;
using System.Threading;

namespace BasicThreadTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // DoSomething();
            Thread th1 = new Thread(DoSomething);
            th1.Start();
            //th1.Join();

            DoOtherting();

            //th1.Abort(); // 더이상 사용 안함
            //th1.Interrupt(); //스레드를 waitsleepjoin상태일때 사용하지만 현재는 잘 사용 안함
        }

        private static void DoOtherting()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine($"DoOtherthing : {i}");
                Thread.Sleep(10); //10ms
            }
        }

        private static void DoSomething()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine($"DoSomething : {i}");
                Thread.Sleep(10); //10ms
            }
        }
    }
}
