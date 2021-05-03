using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    Console.Write('\n');
                    continue;
                }
                {
                    for (int j = 0; j < i + 1; j++)

                        Console.Write("*");
                        Console.Write('\n');
                }
            }
        }
    }
}
