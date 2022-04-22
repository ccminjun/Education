using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Q1
    {
        static void Main(string[] args)
        {
            Console.Write("원의 반지름을 입력하세요. : ");
            double input = double.Parse(Console.ReadLine());
            double result = input * input * Math.PI;
            Console.Write($"원의 반지름은 {result} 입니다. \n\n\n ");
        }
    }
}