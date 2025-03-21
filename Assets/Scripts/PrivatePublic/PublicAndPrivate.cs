using UnityEngine;

namespace PrivatePublic
{
    public class PublicAndPrivate : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[1]Car 클래스의 객체(인스턴스) 생성
            Car myCar = new Car();

            //[2]Car 클래스의 객체를 통해 public한 필드에 접근해서 사용
            myCar.name = "홍길동";
            Debug.Log(myCar.name);

            //[3]Car 클래스의 rorcp를 통해 private한 필드에 접근해서 사용 (X)
            //myCar.age = 21;
            //myCar.Address = "수원";

            //[2]Car 클래스의 객체를 통해 public한 메서드에 접근해서 사용
            myCar.Hi();

            //[3]Car 클래스의 객체를 통해 private한 필드에 접근해서 사용 (X).
            //myCar.Bye();

            //[3] private한 클래스를 public한 필드에 접근해서 사용
            //myCar.age = 21;
            myCar.SetAge(21);
            int myAge = myCar.GetAge();
            Debug.Log(myAge);
        }
    }

}
