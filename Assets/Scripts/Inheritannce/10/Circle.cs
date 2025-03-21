using UnityEngine;

namespace Inheritance10
{
    public class Circle : Shape
    {
        //필드
        private int size;       //반지름

        //생성자
        public Circle(int _size)
        {
            this.size = _size;
        }

        //부모클래스의 추상 메서드(GetArea()를 구현)
        public override double GetArea()
        {
            return size * size * System.Math.PI;
        }
    }

}
