using System;
using System.Threading;

namespace UsingInterfaceTextApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // 이전 생략 3000라인
            var monitor1 = new ExtendedMonitor(new ConsoleLogger(DateTime.Now)); //F11 누르면 ConsoleLogger 먼저 감
            monitor1.PrintLog("로그내용입니다!");

            var monitor = new ExtendedMonitor(new FileLogger("210504.log"));
            monitor.PrintLog("로그내용입니다!");

            Thread.Sleep(5000); //시간 딜레이 1000ms => 1sec
            // 이하 생략 1400라인
            monitor.PrintLog("이하 오류가 발생했습니다.");

            Console.WriteLine("프로그램종료");
        }
    }
}
