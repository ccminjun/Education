namespace PropertyTestApp
{
    class Dog
    {
        private int age;
        //private string name;
        //color도 생략(시간 절약)

        public string Name { get; set; } = "멍멍이";  //초기값 지정 자동 구현 property
        public string Color { get; set; } = "누런";

        public int Age
        {
            get => this.age; // 람다식으로 바꿈
            
            set
            {
                if (value < 0)
                {
                    this.age = 1;
                }
                else if (value > 15)
                {
                    this.age = 15;
                }
                else
                {
                    this.age = value;
                }
            }
        }

       /* public string Getname() { return this.name; }

        public void Setname(string name) { this.name = name; }

        //값을 사용
        public int GetAge() { return $"{this.age}세"; }
        //값을 설정
        public void SetAge(int age)
        {
            if (age < 0)
            {
                this.age = 1;
            }
            else if(age > 15)
            {
                this.age = 15;
            }
            else
            {
                this.age = age;
            }
        }*/

        //Eat, Sleep, Bark() 생략... 다 하려면 코딩 시간이 오래 걸리기 때문
    }
}
