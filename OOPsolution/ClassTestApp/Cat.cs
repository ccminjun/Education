using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTestApp
{
    class Cat : Animal
    {
       // public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }

        public Cat() { /* Noting */ }  //시작 컴파일러가 만들어줌
        public Cat(string name, string color, int age)
        {
            //부를 때 initalization (초기화) 라고 부름
            this.Name = name;
            this.Color = color;
            this.Age = age;

        }
        
        public Cat(string name, string color)
        {
            this.Name = name;
            this.Color = color;
        }

        public Cat(string color, int age)  //칼라랑 네임 위치 바꾸면 컴퓨터 구분 못해서 오류가 남, string 두개 연달아 하면 안됨
        {
            this.Color = color;
            this.Age = age;
        }

        public void Meow() { Console.WriteLine($"{this.Color} 고양이 {this.Name}, 야옹!"); } //책처럼 해도 괜찮지만 이게 더 편함.

        public override void Sleep()  //override 를 통해 재정의하는 과정
        {
            // base.Sleep(); //부모가 한 일 다시 쓰는것 Animal에서 한 것 먼저 처리한 것 (부모의 Sleep()실행
            // 이후 자식 클래스의 Sleep을 실행
            Console.WriteLine($"{this.Color} 고양이 {this.Name}이(가) ZZ잡니다!");
        }
    }
}
