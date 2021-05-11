using System;

namespace DelegateTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //일반적 호출
            Console.Write("첫번째 숫자를 입력하세요. : ");
            int input1 = int.Parse(Console.ReadLine());
            Console.Write("두번째 숫자를 입력하세요. : ");
            int input2 = int.Parse(Console.ReadLine());
            Calculator calc = new Calculator();
            Console.WriteLine($"합은 = {calc.Plus(input1, input2)}");

           /* Console.WriteLine($"3 + 5 = {calc.Plus(3, 5)}");
            Console.WriteLine($"3 / 5 = {calc.Divide(3, 5)}");*/

            //대리자 호출
            CalcDelegate callBack;
            callBack = new CalcDelegate(calc.Plus);
            Console.WriteLine($"3 + 5 = {callBack(3, 5)}");
            callBack = new CalcDelegate(calc.Multiple);
            Console.WriteLine($"3 x 5 = { callBack(3, 5)}"); 


        }
    }
}
