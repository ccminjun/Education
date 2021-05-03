using System;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[100];
            int i;
            for (i = 1; i <= 100; i++)
            {
                if (i % 10 == 3 || i % 10 == 6 || i % 10 == 9)
                {
                    Console.Write("짝");
                }
                else if (i / 10 == 3 || i / 10 == 6 || i / 10 == 9)
                {
                    Console.Write("짝");
                }
                else
                {
                    Console.Write($"{i}");
                }
            }
          
        }
    }
}
