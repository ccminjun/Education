using System;
using System.IO;

namespace FileReadingTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullPath = @"C:\Test\help\PFRO.log";
            StreamReader sr = new StreamReader(new FileStream(fullPath, FileMode.Open));

            while(sr.EndOfStream == false)
            {
                Console.WriteLine(sr.ReadLine());
            }

            sr.Close(); //필수
                        //텍스트파일 읽어오는 부분
            Console.WriteLine("텍스트 파일 읽기 완료");


            string Writepath = @"C:\Test\help\CMJ.txt";
            StreamWriter sw = new StreamWriter(new FileStream(Writepath, FileMode.Create));

            sw.Write("Hello, Wolrd!\n");
            sw.Write("안녕하세요\n");
            sw.Write(3.141592f);
            sw.Close(); //필수

            Console.WriteLine("텍스트 파일 실행 완료");
        }
    }
}
