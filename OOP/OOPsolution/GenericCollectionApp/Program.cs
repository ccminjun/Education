using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace GenericCollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("일반화 컬렉션 테스트 ==== ");

            List<int> list = new List<int>();
            for(int i = 1; i<=100; i++)
            {
                list.Add(i);
            }

            var sum = 0;
            foreach(var item in list)
            {
                sum += item;
            }
            Console.WriteLine($"1~100의 합 ={sum}");
            list.RemoveAt(10);  // 다 사용할 수 있음
            list.Insert(11, 5000); //11번째 항을 5000으로 바꿈
            var index60 = list.IndexOf(60);
            Console.WriteLine($"60의 위치는 {index60}");

            foreach(var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            Queue<string> lines = new Queue<string>();
            lines.Enqueue("첫번쩨 손님");
            lines.Enqueue("두번쩨 손님");
            lines.Enqueue("세번쩨 손님");
            lines.Enqueue("네번쩨 손님");

            while (lines.Count > 0)
            {
                Console.WriteLine(lines.Dequeue());
            }

            //중요 !! dics는 하나는 1 둘은 2로 대체해주는 것
            Dictionary<string, int> dics = new Dictionary<string, int>();
            dics["하나"] = 1;
            dics["둘"] = 2;
            dics["셋"] = 3;
            dics["넷"] = 4;
            dics["다섯"] = 5;

            Console.WriteLine(dics["하나"]);
            Console.WriteLine(dics["셋"]);
            Console.WriteLine(dics["다섯"]);

            foreach (var item in dics)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}
