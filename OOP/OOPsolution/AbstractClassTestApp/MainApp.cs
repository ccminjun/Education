using System;

namespace AbstractClassTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            /* AbstractBase obj = new AbstractBase(); // new 사용할 수 없음 파생클래스만 사용 가능*/
            AbstractBase obj = new Derived();
            obj.PublicMethod();
            obj.AbstractMethod(); //두개가 나옴. AbstractMethod 와 Derived 도 나옴
        }
    }
}
