using UnityEngine;

namespace Property
{
    public class PropertyFull : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[1]Person 클래스의 인스턴스 생성
            Person person = new Person();

            //[2] 메서드 이용 name 값 저장 및 사용
            person.SetName("방국봉");
            Debug.Log(person.GetName());

            //[3] property(속성) 이용, 필드(name)값 저장 및 사용
            //Name 속성의 set
            person.Name = "뿌뿌뿡";
            Debug.Log(person.Name);
        }
    }

}
