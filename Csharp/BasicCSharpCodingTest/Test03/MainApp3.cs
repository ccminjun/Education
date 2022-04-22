using System;

namespace Test03
{
    class MainApp3
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5) Console.WriteLine();
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");                   
                }                
                Console.WriteLine();
            }
        }
    }
}
