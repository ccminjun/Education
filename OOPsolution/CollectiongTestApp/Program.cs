using System;
using System.Collections;

namespace CollectiongTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int a = 123;
            object obj = a;

            Console.WriteLine("a의 타입 : " + a.GetType());
            Console.WriteLine("obj의 타입 : " + a.GetType());
            Console.WriteLine("b의 값 ");

            string str = "문자열임";
            obj = str;

            Console.WriteLine("str의 값 : "+ str);
            Console.WriteLine("obj의의 값 : "+ obj);*/


            Console.WriteLine("ArrayList 예제");

            ArrayList list = new ArrayList(); // 사이즈 지정X
            list.Add(3);
            list.Add(67);
            list.Add(1);
            list.Add(30);
            list.Add(14);

            foreach (var item in list)
            {
                Console.WriteLine(item);

            }

            list.Sort();

            foreach(var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            list.Reverse();

            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            list.Add(100);

            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            list.Insert(2, 88); // 0 1 2순서인데 2번에 88을 넣음

            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            list.RemoveAt(5);

            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            int index100 = list.IndexOf(100);
            Console.WriteLine($"100의 위치  { index100}");

            list.Remove(88); //5라는 값을 지우라는 것이라 변화가 없음 88은 변화가 있음
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            list.Add(14);
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            list.Add(135);
            list.Add(14);

            int index14 = list.IndexOf(14);
            Console.WriteLine($"14의 위치  { index14}"); // 원래 첫번째꺼랑 마지막꺼밖에 안찾음, 찾으려면 for문 돌려야 함

            int lstindex14 = list.LastIndexOf(14);
            Console.WriteLine($"14의 위치  { lstindex14}");

            Console.WriteLine($"총 갯수 {list.Count}");
            Console.WriteLine($"리스트 마지막값 {list[list.Count - 1]}");
        }
    }
}
