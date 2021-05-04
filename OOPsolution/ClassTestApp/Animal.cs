using System;

namespace ClassTestApp
{
    class Animal
    {
        private int UniqueId { get; set; }
        protected string Name { get; set; } //Main에 오류가 남 protected라 설정을 안해주면 why 상속받은 자식한테만 사용 할 수 있기 때문에

        public void Eat(string meal)
        {
            Console.WriteLine($"{this.Name} 이 {meal}을 먹습니다.");
        }
        public virtual void Sleep()
        {
            Console.WriteLine($"{this.Name}이(가) 잡니다/");
        }
    }
}
