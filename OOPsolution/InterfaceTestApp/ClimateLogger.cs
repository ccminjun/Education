using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTestApp
{
    class ClimateLogger : ILogger  // Ver 1.0에서 개발
    {
        public void WriteError(string error)
        {
            throw new NotImplementedException(); //  WriteError 구현 하지 않으려면 그냥 틀 자체로 나두면 됨
        }

        public void WriteLog(string weather)
        {
            Console.WriteLine($"날씨로그 : [{DateTime.Now.ToShortDateString()}] : 현재날씨 {weather}");
        }
    }
}
