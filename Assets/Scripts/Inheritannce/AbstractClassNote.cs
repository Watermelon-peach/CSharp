using UnityEngine;

namespace Inheritance10
{
    public class AbstractClassNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Square 클래스의 인스턴스 생성
            Square square = new Square(10);
            Debug.Log(square.GetArea());

            //Circle 클래스의 인스턴스 생성
            Circle circle = new Circle(10);
            Debug.Log(circle.GetArea());
        }
    }

}
