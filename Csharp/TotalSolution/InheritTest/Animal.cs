using System;

namespace InheritTest
{
    // Access Modifier : public, protected, private
    class Animal
    {
        protected int Age { get; set; }
        
        protected Animal() { this.Age = 0; }

        protected void Eat() { Console.WriteLine("먹습니다"); }
        protected void Sleep() { Console.WriteLine("잡니다"); }
    }
}
