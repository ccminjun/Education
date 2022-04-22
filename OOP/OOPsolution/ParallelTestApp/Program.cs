using System;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine(); // 엔터치면 시작하게 하는 구문
            // 1. 일반적인 방식
            DateTime startTime = DateTime.Now;
            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} : {i}");
            }
            TimeSpan procTime = DateTime.Now - startTime;
            Console.WriteLine($"for 10000 처리 시간 : {procTime.TotalMilliseconds}ms");
            Console.ReadLine();

            // 2. Parallel(병렬처리)
            DateTime pStartTime = DateTime.Now;
            Parallel.For(0, 10000, (i) =>
            {
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} : {i}");
            });
            TimeSpan pProcTime = DateTime.Now - pStartTime;
            Console.WriteLine($"Parallel.for 10000 처리 시간 : {pProcTime.TotalMilliseconds}ms");
            Console.ReadLine(); // for과 시간차이 엄청 남
        }
    }
}
