﻿using System;

namespace Test05
{
    class MainApp5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3,6,9! 3,6,9! 3,6,9! 3,6,9!!");

            for (int i = 0; i <= 100; i++)
            {
                if (i % 15 == 0) Console.WriteLine();

                if (i % 10 == 3 || i % 10 == 6 || i % 10 == 9 ||
                    i / 10 == 3 || i / 10 == 6 || i / 10 == 9)
                    Console.Write("짝!\t");
                else if (i == 0)
                    Console.Write("짝!\t");
                else 
                    Console.Write($"{i}\t");                
            }
        }
    }
}
