using System;

namespace ArrayClassTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array 클래스 사용");

            int[] array = new int[] { 5, 7, 3, 1, 9, 10, 4, 8, 2, 6 }; //배열 초기화

            foreach(var item in array)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            System.Array.Sort(array); //Sort를 넣는순간 오름차순 연결 ex) 네이버 가격비교 같은 것, system 안써도 됨

            foreach(var item in array)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            Array.Reverse(array);
            foreach(var item in array) //내림차순 정렬
            {
                Console.Write($"{item}\t");
            }

            Console.WriteLine();
            int index7 = Array.IndexOf(array, 7);
            Console.WriteLine($"7의 위치는 {index7}");

            Array.Resize<int>(ref array, 11);
            array[10] = 100;
            foreach(var item in array)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }
    }
}
