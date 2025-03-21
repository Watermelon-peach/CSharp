using UnityEngine;

namespace Inheritance10
{
    //정사각형을 관리하는 클래스
    //Shape(추상클래스)를 상속받는 자식 클래스
    public class Square : Shape
    {
        //필드
        private int size;   //한변의 길이

        //생성자
        public Square(int _size)
        {
            this.size = _size;
        }

        //부모클래스의 추상 메서드(GetArea())를 구현
        public override double GetArea()
        {
            return size * size;
        }
    }

}
