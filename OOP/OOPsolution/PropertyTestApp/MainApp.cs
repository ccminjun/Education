using System;

namespace PropertyTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("강아지객체 생성");
            Dog baekgoo = new Dog();
            //baekgoo.SetAge(5); //5살
            //Console.WriteLine($"백구의 나이는 {baekgoo.GetAge()}살");
            baekgoo.Name = "백구";
            
            baekgoo.Age = 250000;
            Console.WriteLine($"{baekgoo.Name}의 나이는 {baekgoo.Age}세");

            Dog streetDog = new Dog();
            Console.WriteLine($"{streetDog.Name}는 {streetDog.Color}색입니다");

            Dog dog1 = new Dog();
            dog1.Name = "황구";
            dog1.Color = "노랑";
            dog1.Age = 10;

            Dog dog2 = new Dog() // ; 없는게 핵심 위와는 다른방법 좀더 간편함
            {
                Name = "깜장이",
                Age = 5,
                Color = "검정"
            };

            var myInstane = new { Name = "성명건", Age = 44 };
            Console.WriteLine(myInstane.Name);
            Console.WriteLine(myInstane.Age);
        }
    }
}
