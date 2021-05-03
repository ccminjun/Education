using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTest
{
    class Cat : Animal
    {
        // 아래 간단한 이유 Dog 와 동일 에니멀을 상속받았기 때문에
        // 특성 --> 속성

        //기본 생성자
        public Cat() { this.Age = 0; } //this 쓰면 속성이 바로 나옴. Age와 color


        //액션 -> 메서드
        public void Meow()
        {
            Console.WriteLine("야옹!");
        }
    }
}
