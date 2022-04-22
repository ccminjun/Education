using System;
using System.Diagnostics;

namespace InterfaceTestApp
{
    class ConsoleLogger : ILogger  // Ver 1.0 내용
    {
        public void WriteError(string error)
        {
            Debug.WriteLine($"에러: {error}"); //디버깅할때만 나오는 메시지
        }

        public void WriteLog(string message)
        {
            Console.WriteLine($"로그 {DateTime.Now} : {message}");
        }
    }
}
