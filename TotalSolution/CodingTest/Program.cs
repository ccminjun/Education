using System;

namespace CodingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {   // 예외가 발생할 가능서이 있는 로직
                Console.Write("값을 입력하세요(소수점을 입력) : ");
                string input = Console.ReadLine();
                float result = float.Parse(input); // 예외발생
                // C# 4.0 
                Console.WriteLine($"입력된 값은 {result} 입니다.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.StackTrace}");
            }            

            /*for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/


        }
    }
}
