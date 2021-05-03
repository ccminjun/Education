using System;

namespace CodingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //예외가 발생할 가능성이 있는 로직
                Console.Write("값을 입력하세요(소수점을 입력) : ");  //회색부분에 클릭하면 브레이크포인트
                // float input = float.Parse(Console.ReadLine());
                string input = Console.ReadLine();
                float result = float.Parse(input); //예외 발생 위치
                Console.Write($"입력된 값은 {input} 입니다."); //최근 이렇게 많이 씀
                 // Console.WriteLine("숫자값은" + ival.ToString() + " 입니다");
                Console.WriteLine($"숫자값은 {input} 입니다.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외 발생 : {ex.Message}");  //원하는 메시지를 보고싶을때는 ex뒤에다가 message 삽입 or stackTrace, Innerexception
            }
            //C# 4.0
          
/*
            for (int i = 0; i < 10; i++)
           {
               for (int j = 0; j < 10; j++)
               {
                    Console.Write("*");
               }
                Console.WriteLine();*/



           /*for (int i = 2; i < 10; i++)
           {
               for (int j = 1; j < 10; j++)
               {
                   Console.WriteLine($"{i} *{j} = {i * j}");
               } */
          //  } //컨트롤 시프트 슬래쉬 하면 다 주석 잡힘
        }
    }
}
