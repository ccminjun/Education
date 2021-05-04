using System;

namespace InterfaceTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("콘솔로거 사용합니다");

            //ILogger을 수정하여 ConsoleLogger로 수정하려면 : ILogger 지우면 가능함. 그러나 ILogger라는 약속을 가지면 좀 더 편한 작업 가능
            ILogger logger = new ConsoleLogger(); // 자식은 부모로 형변환 가능 자식은 부모의 모든것을 가지고 있기 때문 
            logger.WriteLog("기본 콘솔 로그입니다.");
            logger.WriteError("에러메시지!!!!!!");

            ILogger logger2 = new ClimateLogger();
            logger2.WriteLog("흐림//");
            // logger2.WriteError("!!!!!"); //실행 오류 (예외 발생) 그냥 나뒀기 때문에 사용하면 오류 남

            ILogger clmLogger = new FileLogger(); // ClimateLogger 였는데 간단히 FileLogger로 바꿀 수 있음. ver 1.0 ClimateLogger -> ver 1.2 FileLogger 변경
            clmLogger.WriteLog("맑음");
            clmLogger.WriteError("문제 발생!");

        }
    }
}
