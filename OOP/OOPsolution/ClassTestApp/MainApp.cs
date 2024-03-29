﻿using System;
using System.Runtime.ExceptionServices;

namespace ClassTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("고양이 객체 생성");
            Cat kitty = new Cat("키티", 3);
           // kitty.Name = "키티";
            kitty.Age = 3;
            kitty.Color = "하얀색";
            kitty.Meow();

            Cat nero = new Cat("네로", "검은", 12);
         /*   {
                Name = "네로",
                Age = 12,
                Color = "검은색"
            }; // ...아래 알트+엔터 누르면 간단하게 바꿀수 있는 툴(컨텐츠 어시스트 옵션) 중간에는 어시스트 옵션 사용한 것*/
            nero.Meow();

            Cat mimi = new Cat("미미", "노랑", 3); //추가생성자 (위의 기본생성자랑 다름)
            mimi.Meow();

            Cat coco = new Cat("코코", "얼룩이");
            coco.Age = 2;
            coco.Meow();
            
            Cat noname = new Cat("야옹이", "은색", 10);
            // noname.Name = "야옹이";
            noname.Meow();
            noname.Sleep();

            var list = (First : "Cat", Second: "Dog", Third: "Pig", 55);
            Console.Write($" 튜플 첫번째 : {list.First}");
            Console.Write($" 튜플 두번째 : {list.Second}");
            Console.Write($" 튜플 세번째 : {list.Third}");
            Console.Write($" 튜플 네번째 : {list.Item4}");

        }
    }
}
