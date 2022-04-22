using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTest
{
    // Access Modifier : public(공용), protected, private(가장 보안적으로 철저하게 막아버리는 것)
    // 아래 private 로 바꾸는 순간 Dog와 Cat은 상속 받을 수 없음.
    // protected 하위 부모를 상속받은 것은 다 쓸 수 있음.전체 클래스에서는 쓰지 않는게 좋음.
    // 예로 Age를 프라이빗 나머지는 프로텍티드로 하면 Age는 상속 불가능 하지만 나머지는 상속 받을 수 있음.

    class Animal
    {

        public int Age { get; set; }

        public Animal() { this.Age = 0; }

        public void Eat() { Console.WriteLine("먹습니다"); }
        public void Sleep() { Console.WriteLine("잡니다"); }
    }
}
