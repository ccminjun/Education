using System;

namespace ExceptionTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("프로그램 시작");

            int[] array = new int[5];

            try // 트라이 캐치 쓸 때 for문을 안에 넣어주는게 좋음
            {
                for (int i = 0; i <= 5; i++)
                {
                    array[i] = (i + 1); // 1,2,3,4,5
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"문제 발생 {ex.Message} 관리자에게 문의하세요 : Main(16~)"); //ex 뒤에 . 붙이면 여러가지 볼 수 있음
            }
            
            Console.WriteLine("다른 로직 수행");
            //...

            int[] list = { 107, 108, 109 };

            try
            {
                string message = null;
                Console.WriteLine(message.Length);
                
                var result = list[1] / 0;
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(list[i]);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"예외 발생 : {ex.Message}");
                // IndexOutOfRange 예외시 다른 일 처리
                Console.WriteLine("IndexOutOfRangeException 이후 처리!");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine($"예외 발생 : {ex.Message}");
                Console.WriteLine("DivideByZeroException 이후 처리!");
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine($"예외 발생 : {ex.Message}");
                Console.WriteLine("입력 제대로 해주세요");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"예외 발생 : {ex.Message}"); //퉁치기
            }
            finally
            {
                //14:00에 하겠습니다.
                Console.WriteLine("Finally 언제든지 실행됨");
            }
            Console.WriteLine("프로그램 종료");
        }
    }
}
