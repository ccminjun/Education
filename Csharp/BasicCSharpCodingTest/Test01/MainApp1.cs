using System;

namespace Test01
{
    class MainApp1
    {
        static void Main(string[] args)
        {
            Console.Write("원의 반지름을 입력하세요 : ");
            var radius = float.Parse(Console.ReadLine());
            double PI = 3.1415926535897931;
            Console.WriteLine($"원의 넓이는 {radius * radius * PI}");
        }
    }
}
