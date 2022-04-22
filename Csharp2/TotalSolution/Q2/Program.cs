using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("이름을 입력하세요. : ");
            string line1 = Console.ReadLine();

            Console.Write("나이를 입력하세요. : ");
            string line2 = Console.ReadLine();

            Console.Write("주소를 입력하세요. : ");
            string line3 = Console.ReadLine();

            Console.Write($"반갑습니다. 저는 {line3} 에 살고있는 {line2}살 {line1} 입니다. \n\n\n ");
        }
    }
}
