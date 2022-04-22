using System;

namespace DelegateChainApp
{
    delegate int Calculate(int a, int b); //계산 대리자 선언
    class Program
    {
        static void Main(string[] args)
        {
            /*#region

            Calculate calc;
            //무명함수 표현 1
            *//*calc = delegate (int a, int b)
            {
                return a + b;
            };*//*
            //무명함수 표현 2 = 람다식
            calc = (a, b) => a + b;
            Console.WriteLine($"a + b = {calc(3, 5)}");
            
            #endregion*/
             FireStation station = new FireStation();
             ThereIsAFire fireHouse = new ThereIsAFire(station.Call119);
             fireHouse += new ThereIsAFire(station.ShotOut);
             fireHouse += new ThereIsAFire(station.Escape);
             //대리자 실행
             fireHouse("우리집");

             ThereIsAFire fireWoorim = new ThereIsAFire(station.Call119);
             fireWoorim += new ThereIsAFire(station.Escape);
             //대리자실행
             fireWoorim("우림라이온벨리A");

        }
    }
}

