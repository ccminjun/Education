using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTest
{

    class Dog : Animal
    {
        //Animal을 상속받았기 때문에 생략 가능
        // 특성 --> 속성
        // public int Age { get; set; } //get 값을 가져오는 것 set 값 지정
        public string Color { get; set; }


        //기본 생성자
        public Dog() { this.Age = 0; this.Color = "흰색"; } //this 쓰면 속성이 바로 나옴. Age와 color


        //액션 -> 메서드
        /* public void Eat()
        {
            Console.WriteLine("냠냠 먹습니다."); //한줄로 써도 되고 두줄로 써도 되고
        }
        public void Sleep() 
        { 
            Console.WriteLine("쿨쿨 잠을 잡니다."); 
        }
        */
        public void Bark()  
        {
            Console.WriteLine("왈왈!");   
        }
    }
}
