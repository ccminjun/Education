using System;

namespace AttributeTestApp
{
    public class Myclass
    {
        // Properties...

        [Obsolete("이 메서드는 폐기되었습니다. NewMethod()로 대체하세요.")]
        public void OldMethod() { Console.WriteLine("무엇인가를 한다"); }
        public void NweMethod() { Console.WriteLine("새로운 무엇인가를 한다"); }  //위에껄 그만쓰고싶은데 아래때문에 수정하기 어려울때...

        public int Plus(int a, int b) { return a + b; }
        public int Divide(int a, int b) { return a / b; }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Myclass mine = new Myclass();
            // mine.OldMethod(); 못쓰는게 아니라 안쓰도록 유도하는 것

            mine.NweMethod();
            var result = mine.Plus(3, 5);
            Console.WriteLine(result);
        }
    }
}
