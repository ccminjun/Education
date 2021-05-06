using System;

namespace AbstractClassTestApp
{
    class Derived : AbstractBase //base의 반대 개념 Derived, interface를 사용하면 interface가 밑줄이 긁히지만 추상클래스는 Derived가 밑줄 긁힘
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("Derived.AbstractMethod() 실행!");
            base.ProtectedMethod();
        }
    }
}
